using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using NtierProjectDataAccessLayer.EntityFramework;
using Solution1.EntityLayer.Concrete;
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
    public partial class FormCategory: Form
    {
        private readonly ICategoryService _categoryService;

        public FormCategory()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBox1.Text;
            category.CategoryStatus = true;
            _categoryService.BInsert(category);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var deletedValue = _categoryService.BGetById(int.Parse(textBox2.Text));
            _categoryService.BDelete(deletedValue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var value= _categoryService.BGetById(int.Parse(textBox2.Text));
            ///dataGridView1.DataSource = value;
            ///BGetById tek bir Category nesnesi dönüyor, yani bir obje.
            ///Yani tek nesne verince DataGridView “liste yok” gibi davranıyor ve ekrana bir şey göstermiyor. 
            dataGridView1.DataSource = new List<Category> { value };

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var updatedValue=_categoryService.BGetById(int.Parse(textBox2.Text));
            updatedValue.CategoryName = textBox1.Text;
            if(radioButton1.Checked)
                updatedValue.CategoryStatus = true;
            if (radioButton2.Checked)
                updatedValue.CategoryStatus = false;
            _categoryService.BUpdate(updatedValue);
        }
    }
}
