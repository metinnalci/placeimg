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
    public class CategoryRepository : ICategory
    {
        private readonly ImageContext context;
        public CategoryRepository()
        {
            context = new ImageContext();
        }
        public object CategoryVM { get; private set; }

        public Category FirstOrDefault(Expression<Func<Category, bool>> predicate)
        {
            var category = context.Set<Category>().FirstOrDefault(predicate);

            return category;
        }

        public List<Category> GetCategories()
        {
            List<Category> category = new List<Category>();
            category = context.Set<Category>().ToList();

            return category;
        }
    }
}
