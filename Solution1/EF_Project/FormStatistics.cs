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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        EntityFrameworkTravelDbEntities dbEntities = new EntityFrameworkTravelDbEntities();
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            labelLocationCount.Text = dbEntities.Location.Count().ToString();
            #endregion
            labelTotalCapacity.Text = dbEntities.Location.Sum(x => x.LocationCapacity).ToString();
            labelGuideCount.Text = dbEntities.Guide.Count().ToString();
            labelAverageCapacity.Text = ((int?)dbEntities.Location.Average(x => x.LocationCapacity)).ToString();
            var lastId = dbEntities.Location.Max(x => x.LocationId);
            labelLastAddedTour.Text = dbEntities.Location.Where(x => x.LocationId == lastId).Select(y => y.LocationCountry).FirstOrDefault();
            // select bir koleksiyon dönüyor 
            labelCapadociaCapacity.Text=dbEntities.Location.Where(x=>x.LocationCity=="Paris").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            labelAverageTurkıshCapacity.Text=dbEntities.Location.Where(x=>x.LocationCountry=="Türkiye").Average(y=> y.LocationCapacity).ToString();
            var highCapacity = dbEntities.Location.Max(x => x.LocationCapacity);
            labelHighCapacity.Text=dbEntities.Location.Where(x=>x.LocationCapacity==highCapacity).Select(y=>y.LocationCountry).FirstOrDefault().ToString();
            // 1 numaralı ad soyadlı rehberin tur sayısı 
            var guideIdByBetülKurt=dbEntities.Guide.Where(x=>x.GuideName=="Betüş" && x.GuideSurname=="Kurt").Select(y=>y.GuideId).FirstOrDefault();
            label23.Text=dbEntities.Location.Where(x=>x.GuideId==guideIdByBetülKurt).Count().ToString();
 
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
