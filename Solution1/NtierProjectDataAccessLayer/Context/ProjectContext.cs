using Solution1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierProjectDataAccessLayer.Context
{
    public class ProjectContext : DbContext // veritabanına yansıyacak sınıflar buraya eklenmeli
    {
        public DbSet<Category> Categories { get; set; }  // C# tarafında kullanılacak sınıf - sql e yansıyacak TABLO ismi yalın - çoğul hal
        public DbSet<Product> Products { get; set; } 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
