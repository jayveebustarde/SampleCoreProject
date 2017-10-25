using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BaseRepository<TObject, TKey>
        where TObject : class
    {
        #region Fields

        internal OrderDirectoryContext Context;
        internal DbSet<TObject> DbSet;
        DbContextOptions<OrderDirectoryContext> dbOtions;

        #endregion

        #region Constructor

        public BaseRepository()
        {
            this.dbOtions = new DbContextOptions<OrderDirectoryContext>();
            this.Context = new OrderDirectoryContext(this.dbOtions);
            this.DbSet = this.Context.Set<TObject>();
        }
        #endregion
        

        #region Public Methods

        #region Async Methods
        public virtual async Task<IEnumerable<TObject>> GetAllAsync() => await DbSet.ToListAsync();
        public virtual async Task<TObject> GetByIdAsync(TKey id) => await DbSet.FindAsync(id);
        public virtual async Task<IEnumerable<TObject>> FindAllAsync(Expression<Func<TObject, bool>> predicate) => await DbSet.Where(predicate).ToListAsync();
        public virtual async Task<TObject> FindAsync(Expression<Func<TObject, bool>> match) => await DbSet.SingleOrDefaultAsync(match);
        #endregion

        public IQueryable<TObject> FindAllWithInclude(Expression<Func<TObject,bool>> predicate, params string[] include)
        {
            IQueryable<TObject> query = DbSet;
            query = include.Aggregate(query, (current, inc) => current.Include(inc));
            return query.Where(predicate);
        }

        public virtual void Insert(TObject entity) => DbSet.Add(entity);
        public virtual void Update(TObject entityToUpdate) => Context.Entry(entityToUpdate).State = EntityState.Modified;
        public virtual void Delete(TObject entityToDelete) => DbSet.Remove(entityToDelete);
        public bool Exists(object primaryKey) => DbSet.Find(primaryKey) != null;
        public int Count() => DbSet.Count();
        #endregion
    }
}
