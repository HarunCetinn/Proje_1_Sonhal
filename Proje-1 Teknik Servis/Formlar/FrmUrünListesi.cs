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
    public partial class FrmUrünListesi : Form
    {
        public FrmUrünListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI= u.TBLKategori.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmUrünListesi_Load(object sender, EventArgs e)
        {
            //var degerler = db.TBLURUN.ToList();
            metot1();
            lookUpEdit1.Properties.DataSource = db.TBLKategori.ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunad.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlıs.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatıs.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI =byte.Parse(lookUpEdit1.EditValue.ToString());
            t.DURUM = false;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlıs.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TxtSatıs.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtUrunad.Text;
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TxtAlıs.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatıs.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi" , "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
