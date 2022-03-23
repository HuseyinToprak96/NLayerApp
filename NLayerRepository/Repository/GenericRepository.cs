using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayerCore.Repositories;
namespace NLayerRepository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;//Protected yapma sebebim eğer burda 
        //bulunan Metotlar tüm tablolar için işimizi görmüyor ise farklı classlar oluşturmak gerekebilir. Oralardan erişebilmek için kullanılır.
        private readonly DbSet<T> _dbSet;
        //Hangi tabloda işlem yapacağını seçmek için...
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet=_context.Set<T>();

        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity); 
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
           await _dbSet.AddRangeAsync(entities);
        }

        public IQueryable<T> Any(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
           return await _dbSet.AnyAsync(expression);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.AsNoTracking().AsQueryable();
            //AsNoTracking() EF Core çektiği dataları memory e almasın anlamındadır.

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            //_context.Entry(entity).State= EntityState.Deleted; alttaki aynı amaçla kullanılır.
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
