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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();

            string ad1, soyad1;
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl3.Text = ad1 + " " + soyad1;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl1.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;

            string ad2, soyad2;
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl20.Text = ad2 + " " + soyad2;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;

            string ad3, soyad3;
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl14.Text = ad3 + " " + soyad3;
            labelControl5.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            labelControl11.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;




        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtPersonelad.Text;
            t.SOYAD = TxtPersonelSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel sisteme kaydedildi");
            listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
