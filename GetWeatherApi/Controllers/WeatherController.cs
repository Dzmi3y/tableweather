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
        private WeatherContext db;
        public WeatherController(WeatherContext dbContext)
        {
            this.db = dbContext;
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
