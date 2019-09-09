using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetWeatherApi.Entities
{
    public class WeatherEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public decimal Temperature { get; set; }
    }
}
