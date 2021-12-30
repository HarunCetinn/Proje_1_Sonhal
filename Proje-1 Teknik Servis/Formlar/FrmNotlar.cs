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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == true).ToList();
            gridControl1.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == false).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.BASLIK = TxtBaslık.Text;
            t.ICERIK = TxtIcerik.Text;
            t.DURUM = false;
            t.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == true).ToList();
            gridControl1.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == false).ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLNOTLAR.Find(id);
            deger.DURUM = true;
            db.SaveChanges();
            MessageBox.Show("Not Durumu Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    TxtId.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
        //}

        //private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        //}
    }
}
