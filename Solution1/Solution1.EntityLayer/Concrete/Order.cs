using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }  //siparişin içerisinde ürünü aldık 1toN İLİŞKİ
        public int CustomerId { get; set; }   // sipariş hangi müşteride 346 ıd'li müşteri
        public virtual Customer Customer { get; set; }  // o müşterinin diğer bilgilerine ulaşmak için 
    }
}
