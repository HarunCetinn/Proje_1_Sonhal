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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                           };
            gridControl1.DataSource = degerler.ToList();

            gridControl1.DataSource = db.TBLDEPARTMAN.ToList();
            labelControl1.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl3.Text = db.TBLPERSONEL.Count().ToString();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();

            if(TxtDepartmanad.Text.Length<=50 && TxtDepartmanad.Text!="" && RchAciklama.Text.Length>=1){


                t.AD = TxtDepartmanad.Text;
                t.ACIKLAMA = RchAciklama.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Silindi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = TxtDepartmanad.Text;
            deger.ACIKLAMA = RchAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtDepartmanad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            RchAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }
    }
}
