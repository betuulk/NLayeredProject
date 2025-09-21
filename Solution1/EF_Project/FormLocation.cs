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
    public partial class FormLocation : Form
    {
        EntityFrameworkTravelDbEntities dbEntities = new EntityFrameworkTravelDbEntities(); // veritabanına ulaşmak için nesne oluşturuldu
        public FormLocation()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = dbEntities.Location.ToList(); // herhangi bir kısıtlama olmadan getir
            dataGridView1.DataSource = values;
        }

        private void FormLocation_Load(object sender, EventArgs e)
        {
            var guides=dbEntities.Guide.Select(x=> new
            {
                Fullname=x.GuideName +" "+ x.GuideSurname, x.GuideId //gösterim için 
            }).ToList();
            ///var guides = dbEntities.Guide.ToList();
            
            //Alttaki iki özellik string değerindedir.
            //Verilen stringe göre class içerisinde o property'i (sütunu) buluyor
            comboBoxGuide.DataSource = guides;
            comboBoxGuide.DisplayMember = "Fullname";
            comboBoxGuide.ValueMember = "GuideId"; 
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity =byte.Parse(nmrcCapacity.Value.ToString()); 
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationPrice=decimal.Parse(txtPrice.Text);
            location.DayNight= txtDayNight.Text;
            location.GuideId = comboBoxGuide.SelectedIndex;
            dbEntities.Location.Add(location);
            dbEntities.SaveChanges();
            
        }
    }
}
