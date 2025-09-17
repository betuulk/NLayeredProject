using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } // codefirst yaklaşımına göre veritabanında birincil anahtar ve otomatik artan olması için bu isimlendirme
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } 
    }
}
