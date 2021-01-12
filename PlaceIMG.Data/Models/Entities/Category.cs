using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Data.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CatName { get; set; }
        public int TopCatID { get; set; }
    }
}
