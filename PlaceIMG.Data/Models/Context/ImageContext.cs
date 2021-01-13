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
            optionsBuilder.UseNpgsql(@"Server=ec2-54-195-247-108.eu-west-1.compute.amazonaws.com
;Database=dav2rosrm03b0v;UID=lvzegvgmspykdd;PWD=d0ecee59ece60b79a6d70880690851d0fec8d0a794872d15cd2410d2751c0bf6;SSL Mode= Require;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}




