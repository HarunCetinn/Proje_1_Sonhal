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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARI.ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.TELEFON,
                               u.MAIL,
                               u.IL,
                               u.ILCE,
                               u.BANKA,
                               u.VERGIDAIRESI,
                               u.VERGINO,
                               u.STATU,
                               u.ADRES
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = Txtad.Text;
            t.SOYAD = TxtSoyad.Text;
            t.TELEFON = TxtTelefon.Text;
            t.MAIL = TxtMail.Text;
            t.BANKA = TxtBanka.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            t.VERGINO = TxtVergiNo.Text;
            t.STATU = TxtStatu.Text;
            t.ADRES = TxtAdres.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kişi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kişi Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            deger.AD = Txtad.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.TELEFON = TxtTelefon.Text;
            deger.MAIL = TxtMail.Text;
            deger.BANKA = TxtBanka.Text;
            deger.VERGIDAIRESI = TxtVergiDairesi.Text;
            deger.VERGINO = TxtVergiNo.Text;
            deger.STATU = TxtStatu.Text;
            deger.ADRES = TxtAdres.Text;
            db.SaveChanges();
            MessageBox.Show("Kişi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
