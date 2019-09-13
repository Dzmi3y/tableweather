using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GetWeatherApi.DbConnection;
using GetWeatherApi.Entities;

namespace GetWeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        WeatherContext db;
        public WeatherController(WeatherContext dbContext)
        {
            this.db = dbContext;
            Init();
        }

        private void Init()
        {
            if (!db.WeatherEntities.Any())
            {
                db.WeatherEntities.AddRange(
                    new WeatherEntity() { CityName = "C1", Temperature = 13 },
                    new WeatherEntity() { CityName = "C2", Temperature = 23 },
                    new WeatherEntity() { CityName = "C3", Temperature = 432 },
                    new WeatherEntity() { CityName = "C4", Temperature = 2 },
                    new WeatherEntity() { CityName = "C5", Temperature = 4 }
                    );
                db.SaveChanges();
            }

        }


        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<string> result = new List<string>();

            if (db.WeatherEntities.Any())
            {
                foreach (var weatherEntity in db.WeatherEntities)
                {
                    result.Add(weatherEntity.CityName);
                }

                return result;
            }
            return NotFound();
        }

        [HttpGet("{nameCity}")]
        public ActionResult<decimal> GetTemperature(string nameCity)
        {
            var currentWeater = db.WeatherEntities.FirstOrDefault(c => c.CityName == nameCity);

            if (!(currentWeater is null))
            {
                return currentWeater.Temperature;
            }

            return NotFound();
        }
    }
}
