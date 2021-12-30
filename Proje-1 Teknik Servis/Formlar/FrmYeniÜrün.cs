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
    public partial class FrmYeniÜrün : Form
    {
        public FrmYeniÜrün()
        {
            InitializeComponent();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FrmYeniÜrün fr = new FrmYeniÜrün();
            fr.Hide();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlıs.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatıs.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(TxtKategori.Text);
            t.MARKA = TxtMarka.Text;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler Başarıyla Kaydedildi.");
        }

        private void pictureEdit8_EditValueChanged(object sender, EventArgs e)
        {
            //FrmYeniÜrün fr = new FrmYeniÜrün();
            //fr.Hide();
            //this.Close();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            FrmYeniÜrün fr = new FrmYeniÜrün();
            fr.Hide();
            this.Close();
        }
    }
}
