using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PlaceIMG.Business.Interfaces
{
    public interface ICategory
    {
        List<Category> GetCategories();
        Category FirstOrDefault(Expression<Func<Category, bool>> predicate);
    }
}
