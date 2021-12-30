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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARİ =u.TBLCARI.AD +u.TBLCARI.SOYAD,
                               PERSONEL= u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD


                           };
            gridControl1.DataSource = degerler.ToList();

            LkpCari.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

            LkpPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                             select new
                                             {
                                                 x.ID,
                                                 x.AD
                                             }).ToList();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARİ = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD


                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSıraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAIRE = TxtVergiDairesi.Text;
            t.CARI = int.Parse(LkpCari.EditValue.ToString());
            t.PERSONEL = short.Parse(LkpPersonel.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedildi...");

        }
    }
}
