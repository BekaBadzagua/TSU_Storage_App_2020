using DAL.Context;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class UOW : IUOW
    {
        private StoreDbContext _context;

        private IProductRepository _productRepository;
        private IStoreInterface _storeRepository;
        private IStoreProductInterface _storeProductRepository;

        public UOW(StoreDbContext context)
        {
            _context = context;
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_context);
                return _productRepository;
            }
        }

        public IStoreInterface Store
        {
            get
            {
                if (_storeRepository == null)
                    _storeRepository = new StoreRepository(_context);
                return _storeRepository;
            }
        }

        public IStoreProductInterface StoreProduct
        {
            get
            {
                if (_storeProductRepository == null)
                    _storeProductRepository = new StoreProductRepository(_context);
                return _storeProductRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
