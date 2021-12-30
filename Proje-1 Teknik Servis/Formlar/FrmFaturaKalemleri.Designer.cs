namespace Proje_1_Teknik_Servis.Formlar
{
    partial class FrmFaturaKalemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSıraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1182, 733);
            this.gridControl1.TabIndex = 14;
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(1270, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Seri No:";
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(1400, 80);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.BeepOnError = false;
            this.TxtSeriNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSeriNo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TxtSeriNo.Properties.MaskSettings.Set("mask", "A");
            this.TxtSeriNo.Size = new System.Drawing.Size(125, 22);
            this.TxtSeriNo.TabIndex = 16;
            // 
            // BtnAra
            // 
            this.BtnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.ImageOptions.Image")));
            this.BtnAra.Location = new System.Drawing.Point(1342, 190);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(107, 34);
            this.BtnAra.TabIndex = 17;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtSıraNo
            // 
            this.TxtSıraNo.Location = new System.Drawing.Point(1400, 123);
            this.TxtSıraNo.Name = "TxtSıraNo";
            this.TxtSıraNo.Properties.BeepOnError = false;
            this.TxtSıraNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSıraNo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TxtSıraNo.Properties.MaskSettings.Set("mask", "AAAAAA");
            this.TxtSıraNo.Size = new System.Drawing.Size(125, 22);
            this.TxtSıraNo.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(1270, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Sıra No:";
            // 
            // TxtFaturaId
            // 
            this.TxtFaturaId.Location = new System.Drawing.Point(1400, 38);
            this.TxtFaturaId.Name = "TxtFaturaId";
            this.TxtFaturaId.Size = new System.Drawing.Size(125, 22);
            this.TxtFaturaId.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(1260, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 16);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Fatura Id:";
            // 
            // FrmFaturaKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.TxtFaturaId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtSıraNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaKalemleri";
            this.Text = "Fatura Kalemleri";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.TextEdit TxtSıraNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtFaturaId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}