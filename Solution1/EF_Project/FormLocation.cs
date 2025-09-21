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
            var guides = dbEntities.Guide.ToList();
            comboBox1.DataSource = guides; // Db'den dönen koleksiyonu combobox'a bağladı
        }
    }
}
