﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentalCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentalCar;Trusted_Connection=true");

        }

        public DbSet<Car> Cars{ get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}