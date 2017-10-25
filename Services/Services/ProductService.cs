using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess;
using Entities.Models;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        //public DbContext DbContext => (new BaseRepository<Product, int>());

        public int Create(ProductDTO objectDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(ProductDTO objectDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ProductDTO objectDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, ProductDTO objectDto)
        {
            throw new NotImplementedException();
        }
    }
}
