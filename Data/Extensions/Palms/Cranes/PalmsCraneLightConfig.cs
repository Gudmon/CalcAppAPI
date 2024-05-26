﻿using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneLightConfig
    {
        public static void ConfigureMultiplePalmsCraneLights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneLight>().HasData(
              new CraneLight
              {
                  Id = 1,
                  Name = "LED munkalámpák a darugémre, 2 db",
                  Code = "L1",
                  Price = "510"
              }
              );
        }
    }
}
