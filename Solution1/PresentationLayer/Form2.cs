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
        public FormProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            //Burada Service yani Managerdaki metodlar çağırılarak işlem yapılacak, manager da DI kullanarak EfProductDal nesnesi ile erişecek DB'ye
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listedValues=_productService.BGetAll();
            dataGridView1.DataSource = listedValues;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addedValue = new Product();
            addedValue.ProductStock=int.Parse(textBoxStock.Text);
            addedValue.ProductName=textBoxName.Text;
            addedValue.ProductPrice = decimal.Parse(textBoxPri.Text);
            addedValue.ProductDescription=textBoxDesc.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ProductList = _productService.BGetProductsWithCategory();
            dataGridView1.DataSource= ProductList;
        }
    }
}
