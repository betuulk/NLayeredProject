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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        { 
            _orderDal = orderDal; 
        }
        public void BDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> BGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order BGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void BInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void BUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
