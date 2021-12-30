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
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities(); 

        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               AD_SOYAD = x.TBLCARI.AD+x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD,
                               PERSONELsoyad = x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();


        }
    }
}
