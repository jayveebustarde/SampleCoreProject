using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class OrderDirectoryUnitOfWork : IDisposable
    {
        #region Constructor
        public OrderDirectoryUnitOfWork()
        {
            //_context = new OrderDirectoryContext();
        }
        #endregion

        #region Fields
        private bool _disposed;
        private OrderDirectoryContext _context;

        private BaseRepository<Product, int> _productRepository;

        public BaseRepository<Product, int> ProductRepository
        {
            get
            {
                if(this._productRepository == null)
                {
                    this._productRepository = new BaseRepository<Product, int>();
                }
                return _productRepository;
            }
            set { _productRepository = value; }
        }



        #endregion

        public virtual void Dispose(bool disposing)
        {
            if(!this._disposed && disposing)
            {

            }
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
