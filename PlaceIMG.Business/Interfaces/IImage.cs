using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PlaceIMG.Business.Interfaces
{
    public interface IImage
    {
        Image PickOne(Expression<Func<Image, bool>> predicate);
        double GetRatio(double width, double height);

    }
}
