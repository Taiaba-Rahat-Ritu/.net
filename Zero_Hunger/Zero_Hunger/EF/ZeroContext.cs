using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Zero_Hunger.EF.Models;

namespace Zero_Hunger.EF
{
    public class ZeroContext : DbContext
    {
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Distribution> Distributions { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}