using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using NtierProjectDataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1: Form
    {
        private readonly ICategoryService _categoryService;

        public Form1()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            // new EfCategoryDal() → DAL nesnesi oluşturulur (GenericRepository 'de DbSet ile tabloya ulaşılıyor)(EF kullanarak DB ile konuşacak).
            //DEpendency Injection uygulamak içinde CategoryManager içerisine değişken olarak EfDal nesnesi gönderiliyor 
            //burada EfDal IDal'ı implemente ediyor - Manager da Service'i implemente ediyor 
            //burada ınterface türünde değişkene class atanabilir C# buna “Polymorphism (çok biçimlilik) 
            //(Yani interface üzerinden çağrı yapılıyor, ama arkada gerçek class çalışıyor) !!
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = _categoryService.BGetAll();
            dataGridView1.DataSource = category;
        }
    }
}
