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
            _object=context.Set<T>();
        }
        public void Delete(T entity)
        {
          
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
