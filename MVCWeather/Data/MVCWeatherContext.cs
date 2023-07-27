using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWeather.Models;

namespace MVCWeather.Data
{
    public class MVCWeatherContext : DbContext
    {
        public MVCWeatherContext (DbContextOptions<MVCWeatherContext> options)
            : base(options)
        {
        }

        public DbSet<MVCWeather.Models.Weather> Weather { get; set; } = default!;
    }
}
