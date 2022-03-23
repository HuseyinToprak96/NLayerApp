using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.Services
{
    public interface IService<T> where T : class
    {
        //Açıklamalar IGenericRepository Kısmında (NLayerCore/Repositories Klasörü içinde)
     // Dönüş Tipleri farklı olcak
     //isimlendirmelerin aynı olması açısından aynısını copy paste yaptık.

        Task<T> GetByIdAsync(int id);
        //GetAll ı IENUMERABLE yapma  nedenimiz aynı amaçla kullanacağımızın fakat farklı şekilde kullanabileceğimizi anlamamızdır.

      Task<IEnumerable<T>> GetAllAsync();//Tüm data gelsin diye içindekileri sildik.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);//Task yapma nedenimiz SaveChanges() yapcak olması
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);  
    }
}
