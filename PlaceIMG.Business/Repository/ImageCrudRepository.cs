using PlaceIMG.Business.Interfaces;
using PlaceIMG.Data.Models.Context;
using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Business.Repository
{
    public class ImageCrudRepository : IImageCrud
    {
        private readonly ImageContext context;
        public ImageCrudRepository()
        {
            context = new ImageContext();
        }
        public void Add(Image image)
        {
            image.AddDate = DateTime.Now;
            image.IsDeleted = false;
            context.Set<Image>().Add(image);
        }
    }
}
