using BusinessLayer.Abstract;
using NtierProjectDataAccessLayer.Abstract;
using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Burada Category sınıfı için CRUD işlemleri geliştirilecek 
/// Bu CRUD işlemleri için asıl bağlı olduğu DataAccessLayer'daki yapı çağırılacak -> DEPENDENCY INJECTION 

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService 
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }
        public void BDelete(Category entity)
        {
            _categoryDal.Delete(entity); //Delete methodu DAL'dan geliyor. IGenericDal 
        }

        public List<Category> BGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category BGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void BInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void BUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
