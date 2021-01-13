using PlaceIMG.Business.Interfaces;
using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PlaceIMG.Business.Repository
{
    public class ImageRepository : IImage
    {
        public double GetRatio(double width, double height)
        {
            throw new NotImplementedException();
        }

        public Image PickOne(Expression<Func<Image, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
