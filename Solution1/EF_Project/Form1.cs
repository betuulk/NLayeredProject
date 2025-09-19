using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Form1 : Form
    {
        EntityFrameworkTravelDbEntities dbEntities = new EntityFrameworkTravelDbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EntityFrameworkTravelDbEntities dbEntities = new EntityFrameworkTravelDbEntities();
            var values= dbEntities.Guide.ToList(); // noktadan itibaren gelen methodlar EF'ye aittir.
            dataGridView1.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //EntityFrameworkTravelDbEntities dbEntities = new EntityFrameworkTravelDbEntities();
            // Bunu her defasında çağırmak yerine form classına içerisine taşıdım.
            Guide guide = new Guide();
            guide.GuideName=txtName.Text;
            guide.GuideSurname=txtSurname.Text;
            dbEntities.Guide.Add(guide);
            dbEntities.SaveChanges();
            MessageBox.Show("guide is saved");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var removeValue = dbEntities.Guide.Find(id); //texte girilen id değerini guide tablosunda buluyor ve atıyor.
            dbEntities.Guide.Remove(removeValue);  //Db'deki tabloda işlem yapılıyor 
            dbEntities.SaveChanges() ;
            MessageBox.Show("deleted");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var updateValue = dbEntities.Guide.Find(id);//id'den elen değere göre bul
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            dbEntities.SaveChanges();
            MessageBox.Show("Succesully","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = dbEntities.Guide.Where(x => x.GuideId == id).ToList(); // Guide'daki X öyle ki id değerine eşit olsun 
            dataGridView1.DataSource= value;
            dbEntities.SaveChanges();
            MessageBox.Show("Successfully");
        }
    }
}
