using Microsoft.EntityFrameworkCore;
using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Data.Models.Context
{
    public class ImageContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"serverparametreleri");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}




//add-migration ve update-database yapılmalı...
