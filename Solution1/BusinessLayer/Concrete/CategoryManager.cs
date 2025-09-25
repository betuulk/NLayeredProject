using BusinessLayer.Abstract;
using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Burada Category sınıfı için CRUD işlemleri geliştirilecek 
/// Bu CRUD işlemleri için asıl bağlı olduğu DataAccessLayer'daki yapı çağırılacak DEPENDENCY INJECTION 

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService 
    {
        public void BDelete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> BGetAll()
        {
            throw new NotImplementedException();
        }

        public Category BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void BInsert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void BUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
