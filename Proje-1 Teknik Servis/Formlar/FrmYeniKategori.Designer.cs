namespace Proje_1_Teknik_Servis.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.BtnVazgeç = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVazgeç
            // 
            this.BtnVazgeç.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgeç.ImageOptions.Image")));
            this.BtnVazgeç.Location = new System.Drawing.Point(254, 167);
            this.BtnVazgeç.Name = "BtnVazgeç";
            this.BtnVazgeç.Size = new System.Drawing.Size(139, 34);
            this.BtnVazgeç.TabIndex = 33;
            this.BtnVazgeç.Text = "Vazgeç";
            this.BtnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(113, 167);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(133, 34);
            this.BtnKaydet.TabIndex = 32;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "YENİ KATEGORİ EKLEME";
            this.textEdit6.Location = new System.Drawing.Point(226, 24);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit6.Size = new System.Drawing.Size(203, 28);
            this.textEdit6.TabIndex = 27;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(113, 17);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(95, 45);
            this.pictureEdit6.TabIndex = 26;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.EditValue = "Kategori Adı";
            this.TxtUrunAd.Location = new System.Drawing.Point(226, 108);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUrunAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtUrunAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUrunAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtUrunAd.Size = new System.Drawing.Size(167, 22);
            this.TxtUrunAd.TabIndex = 21;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(113, 100);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(70, 41);
            this.pictureEdit1.TabIndex = 20;
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(506, 379);
            this.Controls.Add(this.BtnVazgeç);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "FrmYeniKategori";
            this.Text = "Yeni Kategori Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnVazgeç;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.TextEdit TxtUrunAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}