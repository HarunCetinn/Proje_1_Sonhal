namespace Proje_1_Teknik_Servis.Formlar
{
    partial class FrmFaturaKalem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtÜrün = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtÜrün.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1182, 733);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtFaturaId);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtTutar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtAdet);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtFiyat);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtÜrün);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Location = new System.Drawing.Point(1200, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(570, 733);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Fatura İşlemleri";
            // 
            // TxtFaturaId
            // 
            this.TxtFaturaId.Location = new System.Drawing.Point(201, 283);
            this.TxtFaturaId.Name = "TxtFaturaId";
            this.TxtFaturaId.Properties.BeepOnError = false;
            this.TxtFaturaId.Size = new System.Drawing.Size(198, 22);
            this.TxtFaturaId.TabIndex = 45;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(82, 289);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 16);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "Fatura Id:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(201, 245);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Properties.BeepOnError = false;
            this.TxtTutar.Size = new System.Drawing.Size(198, 22);
            this.TxtTutar.TabIndex = 43;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(103, 251);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "Tutar:";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(201, 167);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Properties.BeepOnError = false;
            this.TxtAdet.Size = new System.Drawing.Size(198, 22);
            this.TxtAdet.TabIndex = 41;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(108, 173);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 16);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Adet:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(201, 207);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Properties.BeepOnError = false;
            this.TxtFiyat.Size = new System.Drawing.Size(198, 22);
            this.TxtFiyat.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(107, 213);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Fiyat:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(201, 86);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(198, 22);
            this.TxtId.TabIndex = 37;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(87, 92);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 16);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Detay Id:";
            // 
            // TxtÜrün
            // 
            this.TxtÜrün.Location = new System.Drawing.Point(201, 126);
            this.TxtÜrün.Name = "TxtÜrün";
            this.TxtÜrün.Properties.BeepOnError = false;
            this.TxtÜrün.Size = new System.Drawing.Size(198, 22);
            this.TxtÜrün.TabIndex = 35;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(107, 129);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(32, 16);
            this.labelControl13.TabIndex = 34;
            this.labelControl13.Text = "Ürün:";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(221, 346);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(148, 35);
            this.BtnListele.TabIndex = 18;
            this.BtnListele.Text = "Listele";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(221, 386);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(148, 35);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmFaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaKalem";
            this.Text = "Fatura Kalem";
            this.Load += new System.EventHandler(this.FrmFaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtÜrün.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtFaturaId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtÜrün;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}