namespace Proje_1_Teknik_Servis.Formlar
{
    partial class FrmFaturaListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LkpPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LkpCari = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSıraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LkpPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(227, 394);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(148, 34);
            this.BtnListele.TabIndex = 18;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(227, 434);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(148, 34);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LkpPersonel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.LkpCari);
            this.groupControl1.Controls.Add(this.TxtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtSaat);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.TxtSıraNo);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.TxtSeri);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Location = new System.Drawing.Point(1200, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(570, 733);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Fatura İşlemleri";
            // 
            // LkpPersonel
            // 
            this.LkpPersonel.Location = new System.Drawing.Point(198, 337);
            this.LkpPersonel.Name = "LkpPersonel";
            this.LkpPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkpPersonel.Properties.DisplayMember = "AD";
            this.LkpPersonel.Properties.ValueMember = "ID";
            this.LkpPersonel.Size = new System.Drawing.Size(198, 22);
            this.LkpPersonel.TabIndex = 52;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(70, 340);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 16);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Personel:";
            // 
            // LkpCari
            // 
            this.LkpCari.Location = new System.Drawing.Point(198, 295);
            this.LkpCari.Name = "LkpCari";
            this.LkpCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkpCari.Properties.DisplayMember = "AD";
            this.LkpCari.Properties.ValueMember = "ID";
            this.LkpCari.Size = new System.Drawing.Size(198, 22);
            this.LkpCari.TabIndex = 50;
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(198, 254);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Properties.BeepOnError = false;
            this.TxtVergiDairesi.Size = new System.Drawing.Size(198, 22);
            this.TxtVergiDairesi.TabIndex = 49;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(46, 260);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 16);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "Vergi Dairesi:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(96, 303);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 16);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Cari:";
            // 
            // TxtSaat
            // 
            this.TxtSaat.Location = new System.Drawing.Point(198, 216);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.BeepOnError = false;
            this.TxtSaat.Size = new System.Drawing.Size(198, 22);
            this.TxtSaat.TabIndex = 46;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(93, 222);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 16);
            this.labelControl9.TabIndex = 45;
            this.labelControl9.Text = "Saat:";
            // 
            // TxtSıraNo
            // 
            this.TxtSıraNo.Location = new System.Drawing.Point(198, 138);
            this.TxtSıraNo.Name = "TxtSıraNo";
            this.TxtSıraNo.Properties.BeepOnError = false;
            this.TxtSıraNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSıraNo.Properties.MaskSettings.Set("mask", "AAAAAA");
            this.TxtSıraNo.Size = new System.Drawing.Size(198, 22);
            this.TxtSıraNo.TabIndex = 44;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(77, 144);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 16);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Sıra No:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(198, 178);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.BeepOnError = false;
            this.TxtTarih.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.TxtTarih.Properties.MaskSettings.Set("mask", "D");
            this.TxtTarih.Size = new System.Drawing.Size(198, 22);
            this.TxtTarih.TabIndex = 42;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(89, 184);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(35, 16);
            this.labelControl11.TabIndex = 41;
            this.labelControl11.Text = "Tarih:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(198, 57);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(198, 22);
            this.TxtId.TabIndex = 40;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(72, 63);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(52, 16);
            this.labelControl12.TabIndex = 39;
            this.labelControl12.Text = "Detay Id:";
            // 
            // TxtSeri
            // 
            this.TxtSeri.Location = new System.Drawing.Point(198, 97);
            this.TxtSeri.Name = "TxtSeri";
            this.TxtSeri.Properties.BeepOnError = false;
            this.TxtSeri.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSeri.Properties.MaskSettings.Set("mask", "A");
            this.TxtSeri.Size = new System.Drawing.Size(198, 22);
            this.TxtSeri.TabIndex = 38;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(81, 100);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(43, 16);
            this.labelControl14.TabIndex = 37;
            this.labelControl14.Text = "SeriNo:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Turquoise;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1182, 733);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaListesi";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LkpPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LookUpEdit LkpPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit LkpCari;
        private DevExpress.XtraEditors.TextEdit TxtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TxtSıraNo;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtSeri;
        private DevExpress.XtraEditors.LabelControl labelControl14;
    }
}