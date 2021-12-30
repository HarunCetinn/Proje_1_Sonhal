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
    public partial class FrmArızalıUrunKayıt : Form
    {
        public FrmArızalıUrunKayıt()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(TxtMusteriId.Text);
            t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = short.Parse(TxtPersonel.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arıza Girişi Yapıldı");

        }
    }
}
