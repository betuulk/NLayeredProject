using NtierProjectDataAccessLayer.Abstract;
using NtierProjectDataAccessLayer.Context;
using NtierProjectDataAccessLayer.Repositories;
using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierProjectDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            using(var context= new ProjectContext())
            {
                return context.Products
                      .Include(x => x.Category)
                      .ToList();

                //EF'de Includde demek Product'ı getirirken bağlı olduğu Category bilgisini de getir 
                //ProductId = 1 ProductName = "Laptop" Category = { CategoryId = 10, CategoryName = "Electronics" } şeklinde liste dönüyor
            }
            /// yeni bir DB nesnesi oluşturdum
            /// using → işi bitince otomatik kapat, yani DB bağlantısını serbest bırak.
            /// Products → DbSet<Product> tipinde bir koleksiyon. Yani veritabanındaki Products tablosu.
            /// .Include(x => x.Category) ile Her product’ın bağlı olduğu Category bilgisini de beraber getir (JOIN gibi).


        }
    }
}
