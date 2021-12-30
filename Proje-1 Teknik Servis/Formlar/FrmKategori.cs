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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKategori t = new TBLKategori();
            t.AD = TxtAd.Text;
            db.TBLKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi.");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLKategori.Find(id);
                db.TBLKategori.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLKategori.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
