/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
namespace restoran
{
    partial class frmKasaIslemleri
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.rpvAylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvGunluk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.gunlukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new restoran.DataSet1();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new restoran.DataSet1TableAdapters.DataTable1TableAdapter();
            this.gunlukTableAdapter = new restoran.DataSet1TableAdapters.gunlukTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAylikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnAylikRapor.BackgroundImage = global::restoran.Properties.Resources.aylikrapor;
            this.btnAylikRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAylikRapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAylikRapor.Location = new System.Drawing.Point(24, 384);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(220, 96);
            this.btnAylikRapor.TabIndex = 0;
            this.btnAylikRapor.UseVisualStyleBackColor = false;
            this.btnAylikRapor.Click += new System.EventHandler(this.btnAylikRapor_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZRaporu.BackColor = System.Drawing.Color.Transparent;
            this.btnZRaporu.BackgroundImage = global::restoran.Properties.Resources.zraporu;
            this.btnZRaporu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZRaporu.Location = new System.Drawing.Point(24, 509);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(167, 98);
            this.btnZRaporu.TabIndex = 0;
            this.btnZRaporu.UseVisualStyleBackColor = false;
            this.btnZRaporu.Click += new System.EventHandler(this.btnZRaporu_Click);
            // 
            // rpvAylik
            // 
            this.rpvAylik.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpvAylik.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAylik.LocalReport.ReportEmbeddedResource = "restoran.Report1.rdlc";
            this.rpvAylik.Location = new System.Drawing.Point(305, 165);
            this.rpvAylik.Name = "rpvAylik";
            this.rpvAylik.ServerReport.BearerToken = null;
            this.rpvAylik.Size = new System.Drawing.Size(1066, 497);
            this.rpvAylik.TabIndex = 1;
            this.rpvAylik.Load += new System.EventHandler(this.rpvAylik_Load);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(300, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "AYLIK RAPOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rpvGunluk
            // 
            this.rpvGunluk.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.gunlukBindingSource;
            this.rpvGunluk.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvGunluk.LocalReport.ReportEmbeddedResource = "restoran.Report2.rdlc";
            this.rpvGunluk.Location = new System.Drawing.Point(305, 165);
            this.rpvGunluk.Name = "rpvGunluk";
            this.rpvGunluk.ServerReport.BearerToken = null;
            this.rpvGunluk.Size = new System.Drawing.Size(1066, 497);
            this.rpvGunluk.TabIndex = 3;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::restoran.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(78, 700);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(48, 40);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.BackgroundImage = global::restoran.Properties.Resources.geri;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.Location = new System.Drawing.Point(24, 700);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(48, 40);
            this.btnGeriDon.TabIndex = 15;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // gunlukBindingSource
            // 
            this.gunlukBindingSource.DataMember = "gunluk";
            this.gunlukBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // gunlukTableAdapter
            // 
            this.gunlukTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1441, 25);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restoran.Properties.Resources.Arkaplan_güncel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 752);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.rpvGunluk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvAylik);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnAylikRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasaIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKasaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunlukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRaporu;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAylik;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvGunluk;
        private System.Windows.Forms.BindingSource gunlukBindingSource;
        private DataSet1TableAdapters.gunlukTableAdapter gunlukTableAdapter;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}