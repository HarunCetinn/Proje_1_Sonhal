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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKategori t = new TBLKategori();
            t.AD = TxtUrunAd.Text;
            db.TBLKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi");
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
