using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBaseService<TObject, TKey>
    {
        //DbContext DbContext { get; }

        Task<IEnumerable<TObject>> GetAllAsync();
        Task<TObject> GetByIdAsync(TKey id);
        TKey Create(TObject objectDto);
        Task<TKey> CreateAsync(TObject objectDto);
        bool Update(TKey id, TObject objectDto);
        Task<bool> UpdateAsync(TKey id, TObject objectDto);

    }
}
