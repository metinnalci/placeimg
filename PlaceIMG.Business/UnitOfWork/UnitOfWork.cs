using PlaceIMG.Business.Interfaces;
using PlaceIMG.Data.Models.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceIMG.Business.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ImageContext _imageContext;

        public UnitOfWork(ImageContext imageContext)
        {
            _imageContext = imageContext;
        }
       
        public int SaveChanges()
        {
            try
            {
                return _imageContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _imageContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
