using PlaceIMG.Business.Interfaces;
using PlaceIMG.Data.Models.Context;
using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PlaceIMG.Business.Repository
{
    public class ImageRepository : IImage
    {
        private readonly ImageContext context;
        public ImageRepository()
        {
            context = new ImageContext();
        }
        public double GetRatio(double width, double height)
        {
            var ratio = width / height;
            return ratio;
        }

        public Image PickOne(Expression<Func<Image, bool>> predicate)
        {
            var image = context.Set<Image>().FirstOrDefault(predicate);
            return image;
        }
    }
}
