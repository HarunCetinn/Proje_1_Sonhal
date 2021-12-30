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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.MAIL = TxtMail.Text;
            t.TELEFON = TxtTelefon.Text;
            t.IL = TxtIL.Text;
            t.ILCE = TxtIlce.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            t.VERGINO = TxtVergiNo.Text;
            t.STATU = TxtStatu.Text;
            t.ADRES = TxtAdres.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Eklendi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            FrmYeniÜrün fr = new FrmYeniÜrün();
            fr.Hide();
            this.Close();
        }
    }
}
