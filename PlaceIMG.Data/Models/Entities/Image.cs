using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PlaceIMG.Data.Models.Entities
{
    public class Image : BaseEntity
    {
        public string ImgPath { get; set; }
        public double Ratio { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsDeleted { get; set; }
        public int? CatID { get; set; }
        [ForeignKey("CatID")]
        public Category Category { get; set; }
    }
}
