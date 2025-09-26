using NtierProjectDataAccessLayer.Abstract;
using NtierProjectDataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace NtierProjectDataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        ProjectContext context = new ProjectContext();
        DbSet<T> _object;  // field readonly 
        public GenericRepository()   //constructor
        {
            _object=context.Set<T>(); //veritabanı ile iletişimi kuruyor ilgili entity tablosunu tutuyor 
        }
        public void Delete(T entity)
        {
          var deletedEntity=context.Entry(entity);  // Entry DbSet içerisinde hazır gelen bir metot - Entry üzerinden ilgili nesnenin durumu(State) görülebilir
          deletedEntity.State = EntityState.Deleted;
          context.SaveChanges();
        }
        // Entity Frameork her nesne için bir durum tutar 
        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);  //_object zaten DbSet türünde 
        }

        public void Insert(T entity)
        {
            var addedEntity=context.Entry(entity); // eklenecek entity durumu alındı
            addedEntity.State=EntityState.Added;
            context.SaveChanges();  
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity); // eklenecek entity durumu alındı
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
