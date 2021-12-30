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
    public partial class FrmSatıslar : Form
    {
        public FrmSatıslar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmSatıslar_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNHAREKET
                           select new
                           {
                               x.HAREKETID,
                               x.TBLURUN.AD,
                               musteri = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                               personel = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
