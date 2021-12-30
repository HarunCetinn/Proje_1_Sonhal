using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1_Teknik_Servis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrünListesi fr = new Formlar.FrmUrünListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniÜrün fr = new Formlar.FrmYeniÜrün();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategori fr = new Formlar.FrmKategori();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            fr.Show();
        }

        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frmİstatistik fr = new Formlar.Frmİstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnMarkaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmMarkalar fr = new Formlar.FrmMarkalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman fr = new Formlar.FrmDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel fr = new Formlar.FrmPersonel();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void CariİlGrafik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariler fr = new Formlar.FrmCariler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            fr.Show();
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar fr = new Formlar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnWORD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube fr = new Formlar.FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmNotlar fr = new Formlar.FrmNotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnArızalıÜrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArızaListesi fr = new Formlar.FrmArızaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunSatıs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatıs fr = new Formlar.FrmUrunSatıs();
            fr.Show();
        }

        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatıslar fr = new Formlar.FrmSatıslar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniArızalı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArızalıUrunKayıt fr = new Formlar.FrmArızalıUrunKayıt();
            fr.Show();
        }

        private void BtnArızalıAçıklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetaylar fr = new Formlar.FrmArizaDetaylar();
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunDetay fr = new Formlar.FrmArizaliUrunDetay();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnQROlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQrKod fr = new Formlar.FrmQrKod();
            fr.Show();
        }

        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaListesi fr = new Formlar.FrmFaturaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalem fr = new Formlar.FrmFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalemleri fr = new Formlar.FrmFaturaKalemleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Formlar.FrmAnaSayfa fr = new Formlar.FrmAnaSayfa();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmAnaSayfa fr = new Formlar.FrmAnaSayfa();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
