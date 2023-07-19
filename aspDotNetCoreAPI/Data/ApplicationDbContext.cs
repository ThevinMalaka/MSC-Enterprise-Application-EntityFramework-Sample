//using System;
//using aspDotNetCoreAPI;
//using Microsoft.EntityFrameworkCore;

//namespace aspDotNetCoreAPI.Data
//{
//	public class ApplicationDbContext: DbContext
//	{
//        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
//        }
//    }
//}



using aspDotNetCoreAPI;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}
