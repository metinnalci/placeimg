using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Business.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
