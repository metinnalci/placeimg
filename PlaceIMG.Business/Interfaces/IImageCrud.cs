using PlaceIMG.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Business.Interfaces
{
    public interface IImageCrud
    {
        void Add(Image image);
    }
}
