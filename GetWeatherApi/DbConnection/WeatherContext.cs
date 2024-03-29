﻿using GetWeatherApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetWeatherApi.DbConnection
{
    public class WeatherContext:DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }

        public DbSet<WeatherEntity> WeatherEntities { get; set; }
    }
}
