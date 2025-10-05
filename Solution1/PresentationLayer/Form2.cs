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
    public partial class FormProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FormProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            //Burada Service yani Managerdaki metodlar çağırılarak işlem yapılacak, manager da DI kullanarak EfProductDal nesnesi ile erişecek DB'ye
            _categoryService= new CategoryManager(new EfCategoryDal());        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listedValues=_productService.BGetAll();
            dataGridView1.DataSource = listedValues;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addedProduct = new Product();
            addedProduct.ProductStock=int.Parse(textBoxStock.Text);
            addedProduct.ProductName=textBoxName.Text;
            addedProduct.ProductPrice = decimal.Parse(textBoxPri.Text);
            addedProduct.ProductDescription=textBoxDesc.Text;
            addedProduct.CategoryId=comboBoxCategory.SelectedIndex;
            _productService.BInsert(addedProduct);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ProductList = _productService.BGetProductsWithCategory();
            dataGridView1.DataSource= ProductList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textBoxId.Text);
            var deletedEntity = _productService.BGetById(id);
            _productService.BDelete(deletedEntity);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var updatedValue= _productService.BGetById(int.Parse(textBoxId.Text));
            updatedValue.ProductDescription=textBoxDesc.Text;
            updatedValue.ProductPrice=decimal.Parse(textBoxPri.Text); //textbox boşken patlıyor bakılacak!
            updatedValue.ProductStock= int.Parse(textBoxStock.Text);
            updatedValue.ProductName=textBoxName.Text;
            _productService.BUpdate(updatedValue);
            MessageBox.Show("okey");
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            var categories = _categoryService.BGetAll();
            comboBoxCategory.DisplayMember= "CategoryName"; // Combobox içerisinde gözükecek değer CATEGORY TABLOSUNDAKİ ALAN İLE AYNI YAZILMALI
            comboBoxCategory.ValueMember= "CategoryId";      // Seçilen değer aslında Id olarak alınıyor
            comboBoxCategory.DataSource= categories;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var IdValue = int.Parse(textBoxId.Text);
            var entity=_productService.BGetById(IdValue);
            dataGridView1.DataSource = new List<Product> { entity };
        }
    }
}
