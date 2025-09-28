using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; } // Her ürünün ait olduğu bir kategori olmalı // Foreign Key
        public  virtual Category Category { get; set; } // Herbir ürünün bir tane kategorisi olacak -- Bir kategorinin birden fazla ürünü olabilir
        public List<Order> Orders { get; set; } // sipariş listesini dönecek - Order türünde bu ürünün bulunduğu sipariş nesnelerini dönecek

    }
}
