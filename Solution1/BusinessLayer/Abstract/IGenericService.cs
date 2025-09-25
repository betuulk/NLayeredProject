using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        void BInsert(T entity);
        void BUpdate(T entity);
        void BDelete(T entity);
        List<T> BGetAll(); 
        T BGetById(int id);
    }
}
