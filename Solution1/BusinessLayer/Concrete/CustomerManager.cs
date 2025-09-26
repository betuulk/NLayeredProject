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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void BDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> BGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer BGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void BInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void BUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
