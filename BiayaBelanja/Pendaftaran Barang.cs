﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelanjaLibrary;

namespace BiayaBelanja
{
    public partial class FrmPerhitunganBiaya : Form
    {
        BarangDAO dao = new BarangDAO(Setting.GetConnectionString());
        public FrmPerhitunganBiaya()
        {
            InitializeComponent();
        }

        private void tbHargaBrgBaru_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBelanja_Click(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Barang barang = null;
            if (this.tbNamaBrgBaru.Text.Trim() == "")//jika isian nama kosong
            {
                MessageBox.Show("Sorry , nama barang wajib isi ...");
                this.tbNamaBrgBaru.Focus();
            }
            else if (this.tbHargaBrgBaru.Text.Trim() == "")
            {
                MessageBox.Show("Sorry , harga barang wajib isi ...");
                this.tbHargaBrgBaru.Focus();
            }
            else if (this.tbPajakBrg.Text.Trim() == "")
            {
                MessageBox.Show("Sorry , pajak barang wajib isi ...");
                this.tbPajakBrg.Focus();
            }
            else
            {
                barang = new Barang();
                barang.KodeBarang = dao.GetKodeBarangBerikutnya();
                barang.NamaBarang = this.tbNamaBrgBaru.Text;
                barang.HargaBarang = Convert.ToDouble(this.tbHargaBrgBaru.Text);
                barang.PajakBarang = Convert.ToDouble(this.tbPajakBrg.Text);
                dao.Insert(barang);
                this.Close();
                
            }
            
        }
    }
}
