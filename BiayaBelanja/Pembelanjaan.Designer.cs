﻿namespace BiayaBelanja
{
    partial class FrmPembelanjaan
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.tbTotalHarga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvBarang = new System.Windows.Forms.ListView();
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pajak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNamaBrg = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "PEMBELANJAAN BARANG";
            // 
            // tbHarga
            // 
            this.tbHarga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(196, 208);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHarga.Size = new System.Drawing.Size(224, 34);
            this.tbHarga.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Harga";
            // 
            // tbQty
            // 
            this.tbQty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(196, 267);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(224, 34);
            this.tbQty.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBatal.Location = new System.Drawing.Point(795, 673);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(143, 47);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonfirmasi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKonfirmasi.Location = new System.Drawing.Point(576, 673);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(202, 47);
            this.btnKonfirmasi.TabIndex = 13;
            this.btnKonfirmasi.Text = "KONFIRMASI";
            this.btnKonfirmasi.UseVisualStyleBackColor = false;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHarga.Location = new System.Drawing.Point(714, 560);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.ReadOnly = true;
            this.tbTotalHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotalHarga.Size = new System.Drawing.Size(224, 34);
            this.tbTotalHarga.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Harga";
            // 
            // lvBarang
            // 
            this.lvBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.Harga,
            this.Pajak,
            this.Qty});
            this.lvBarang.Location = new System.Drawing.Point(474, 149);
            this.lvBarang.Name = "lvBarang";
            this.lvBarang.Size = new System.Drawing.Size(464, 273);
            this.lvBarang.TabIndex = 19;
            this.lvBarang.UseCompatibleStateImageBehavior = false;
            this.lvBarang.View = System.Windows.Forms.View.Details;
            // 
            // Nama
            // 
            this.Nama.Text = "Nama";
            this.Nama.Width = 125;
            // 
            // Harga
            // 
            this.Harga.Text = "Harga";
            this.Harga.Width = 75;
            // 
            // Pajak
            // 
            this.Pajak.Text = "Pajak";
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            // 
            // tbNamaBrg
            // 
            this.tbNamaBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBrg.Location = new System.Drawing.Point(25, 149);
            this.tbNamaBrg.Name = "tbNamaBrg";
            this.tbNamaBrg.Size = new System.Drawing.Size(395, 34);
            this.tbNamaBrg.TabIndex = 20;
            this.tbNamaBrg.Leave += new System.EventHandler(this.tbNamaBrg_Leave);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Window;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(231, 331);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(189, 47);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(25, 676);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 47);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.Yellow;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(196, 674);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(143, 47);
            this.btnDaftar.TabIndex = 22;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // FrmPembelanjaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 764);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNamaBrg);
            this.Controls.Add(this.lvBarang);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPembelanjaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEMBELANJAAN BARANG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.TextBox tbTotalHarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvBarang;
        private System.Windows.Forms.TextBox tbNamaBrg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.ColumnHeader Harga;
        private System.Windows.Forms.ColumnHeader Pajak;
        private System.Windows.Forms.ColumnHeader Qty;
    }
}