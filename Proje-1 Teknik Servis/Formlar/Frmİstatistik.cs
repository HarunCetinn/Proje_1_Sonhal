using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1_Teknik_Servis.Formlar
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKategori.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl9.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT ascending
                                  select x.AD).FirstOrDefault();



        }
    }
}
