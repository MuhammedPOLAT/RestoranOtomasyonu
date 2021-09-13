/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace restoran
{
    public partial class frmKasaIslemleri : Form
    {
        public frmKasaIslemleri()
        {
            InitializeComponent();
        }

        private void frmKasaIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.gunluk' table. You can move, or remove it, as needed.
            this.gunlukTableAdapter.Fill(this.DataSet1.gunluk);
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.rpvAylik.RefreshReport();
            this.rpvGunluk.RefreshReport();
            rpvGunluk.Visible = false;
            label1.Text = "AYLIK RAPOR";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rpvAylik_Load(object sender, EventArgs e)
        {

        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            label1.Text = "GÜNLÜK RAPOR";
            rpvAylik.Visible = false;
            rpvGunluk.Visible = true;
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            label1.Text = "AYLIK RAPOR";
            rpvAylik.Visible = true;
            rpvGunluk.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Çıkış butonuna basıldığında ekrana uyarı verecek ve eğer evet derse kullanıcı uygulama kapanacak.
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Dikkat !  //Coder: Muhammed POLAT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Uyarı veriyoruz eğer Evet'e basarsa kullanıcı uygulamadan çıkacak.
            }
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gunlukTableAdapter.FillBy(this.DataSet1.gunluk);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
