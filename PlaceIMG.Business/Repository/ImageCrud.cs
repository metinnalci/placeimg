using PlaceIMG.Business.Interfaces;
using PlaceIMG.Data.Models.Context;
using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Business.Repository
{
    public class ImageCrud : IImageCrud
    {
        private readonly ImageContext context;
        public void Add(Image image)
        {
            context.Set<Image>().Add(image);
        }
    }
}
