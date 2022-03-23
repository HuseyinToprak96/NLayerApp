using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
       //Tümünü Getir//GetAll
        IQueryable<T> Where(Expression<Func<T,bool>> expression);//Iqueryable kullanır isek yazılan her sorguda veri tabanına gitmez..
                                                                 //Tolist() vb. kullanımlarda sadece veri tabanına gider.
                                                                 //Bu kullanımda örneğin...
                                                                 //productRepository.where(x=>x.id>5).ToListAsync();
                                                                 //Der isek veri tabanında veri işlemi yapar.
                                                                 //List demez isek OrderBy ve benzeri işlemleri veri tabanına gitmedende uygulayabiliriz.
        IQueryable<T> Any(Expression<Func<T, bool>> expression);//Varmı Yokmu?Kontrol
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);  
        Task AddAsync(T entity);  
        Task AddRangeAsync(IEnumerable<T> entities);
        //Soyut nesneler ile çalışmak önemlidir.
        //T tipi olması ondandır..
        void Update(T entity);//Update veya Removeun asenkronu yoktur.
        //Uzun süren bir işlem olmadığından asenkron işlemi uygulanmaz.
        //EF Core kısmında...
        void Remove(T entity);  
        void RemoveRange(IEnumerable<T> entities); 
        //Memory de tutar topluca siler.
    }
}
