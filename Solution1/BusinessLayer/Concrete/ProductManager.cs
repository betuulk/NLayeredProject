using BusinessLayer.Abstract;
using NtierProjectDataAccessLayer.Abstract;
using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void BDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> BGetAll()
        {
            return _productDal.GetAll();
        }

        public Product BGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void BInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void BUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
