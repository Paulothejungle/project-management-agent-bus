namespace Project_UTS
{
    partial class FormPemesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDataPemesanan = new System.Windows.Forms.GroupBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNohp = new System.Windows.Forms.TextBox();
            this.textBoxNomorIdn = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTransportasi = new System.Windows.Forms.GroupBox();
            this.numericUpDownPenumpang = new System.Windows.Forms.NumericUpDown();
            this.textBoxHargaBagasi = new System.Windows.Forms.TextBox();
            this.textBoxHargaTiket = new System.Windows.Forms.TextBox();
            this.textBoxTotalHarga = new System.Windows.Forms.TextBox();
            this.textBoxTotalPenumpang = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxKotaTujuan = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxBagasi = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxJenisTiket = new System.Windows.Forms.ComboBox();
            this.comboBoxKotaAsal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonValidasiHitung = new System.Windows.Forms.Button();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.groupBoxDataPemesanan.SuspendLayout();
            this.groupBoxTransportasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenumpang)).BeginInit();
            this.groupBoxBagasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiket Bus PT. Gumarang Jaya";
            // 
            // groupBoxDataPemesanan
            // 
            this.groupBoxDataPemesanan.Controls.Add(this.textBoxAlamat);
            this.groupBoxDataPemesanan.Controls.Add(this.textBoxNohp);
            this.groupBoxDataPemesanan.Controls.Add(this.textBoxNomorIdn);
            this.groupBoxDataPemesanan.Controls.Add(this.textBoxNama);
            this.groupBoxDataPemesanan.Controls.Add(this.label5);
            this.groupBoxDataPemesanan.Controls.Add(this.label4);
            this.groupBoxDataPemesanan.Controls.Add(this.label3);
            this.groupBoxDataPemesanan.Controls.Add(this.label2);
            this.groupBoxDataPemesanan.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataPemesanan.Location = new System.Drawing.Point(18, 43);
            this.groupBoxDataPemesanan.Name = "groupBoxDataPemesanan";
            this.groupBoxDataPemesanan.Size = new System.Drawing.Size(539, 263);
            this.groupBoxDataPemesanan.TabIndex = 1;
            this.groupBoxDataPemesanan.TabStop = false;
            this.groupBoxDataPemesanan.Text = "Data Pemesanan";
            this.groupBoxDataPemesanan.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(162, 186);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(325, 65);
            this.textBoxAlamat.TabIndex = 8;
            // 
            // textBoxNohp
            // 
            this.textBoxNohp.Location = new System.Drawing.Point(162, 81);
            this.textBoxNohp.Name = "textBoxNohp";
            this.textBoxNohp.Size = new System.Drawing.Size(325, 27);
            this.textBoxNohp.TabIndex = 7;
            // 
            // textBoxNomorIdn
            // 
            this.textBoxNomorIdn.Location = new System.Drawing.Point(162, 130);
            this.textBoxNomorIdn.Name = "textBoxNomorIdn";
            this.textBoxNomorIdn.Size = new System.Drawing.Size(325, 27);
            this.textBoxNomorIdn.TabIndex = 5;
            this.textBoxNomorIdn.TextChanged += new System.EventHandler(this.textBoxNomorIdn_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(162, 26);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(325, 27);
            this.textBoxNama.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alamat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nomor Identitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "No. Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // groupBoxTransportasi
            // 
            this.groupBoxTransportasi.Controls.Add(this.numericUpDownPenumpang);
            this.groupBoxTransportasi.Controls.Add(this.textBoxHargaBagasi);
            this.groupBoxTransportasi.Controls.Add(this.textBoxHargaTiket);
            this.groupBoxTransportasi.Controls.Add(this.textBoxTotalHarga);
            this.groupBoxTransportasi.Controls.Add(this.textBoxTotalPenumpang);
            this.groupBoxTransportasi.Controls.Add(this.label16);
            this.groupBoxTransportasi.Controls.Add(this.label15);
            this.groupBoxTransportasi.Controls.Add(this.label14);
            this.groupBoxTransportasi.Controls.Add(this.label13);
            this.groupBoxTransportasi.Controls.Add(this.comboBoxKotaTujuan);
            this.groupBoxTransportasi.Controls.Add(this.label12);
            this.groupBoxTransportasi.Controls.Add(this.groupBoxBagasi);
            this.groupBoxTransportasi.Controls.Add(this.label11);
            this.groupBoxTransportasi.Controls.Add(this.textBoxHarga);
            this.groupBoxTransportasi.Controls.Add(this.label10);
            this.groupBoxTransportasi.Controls.Add(this.comboBoxJenisTiket);
            this.groupBoxTransportasi.Controls.Add(this.comboBoxKotaAsal);
            this.groupBoxTransportasi.Controls.Add(this.label9);
            this.groupBoxTransportasi.Controls.Add(this.label8);
            this.groupBoxTransportasi.Controls.Add(this.label7);
            this.groupBoxTransportasi.Controls.Add(this.label6);
            this.groupBoxTransportasi.Controls.Add(this.dateTimePicker1);
            this.groupBoxTransportasi.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransportasi.Location = new System.Drawing.Point(18, 312);
            this.groupBoxTransportasi.Name = "groupBoxTransportasi";
            this.groupBoxTransportasi.Size = new System.Drawing.Size(869, 331);
            this.groupBoxTransportasi.TabIndex = 2;
            this.groupBoxTransportasi.TabStop = false;
            this.groupBoxTransportasi.Text = "Transportasi";
            // 
            // numericUpDownPenumpang
            // 
            this.numericUpDownPenumpang.Location = new System.Drawing.Point(144, 239);
            this.numericUpDownPenumpang.Name = "numericUpDownPenumpang";
            this.numericUpDownPenumpang.Size = new System.Drawing.Size(179, 27);
            this.numericUpDownPenumpang.TabIndex = 28;
            // 
            // textBoxHargaBagasi
            // 
            this.textBoxHargaBagasi.Location = new System.Drawing.Point(542, 215);
            this.textBoxHargaBagasi.Name = "textBoxHargaBagasi";
            this.textBoxHargaBagasi.Size = new System.Drawing.Size(310, 27);
            this.textBoxHargaBagasi.TabIndex = 27;
            // 
            // textBoxHargaTiket
            // 
            this.textBoxHargaTiket.Location = new System.Drawing.Point(542, 180);
            this.textBoxHargaTiket.Name = "textBoxHargaTiket";
            this.textBoxHargaTiket.Size = new System.Drawing.Size(310, 27);
            this.textBoxHargaTiket.TabIndex = 26;
            // 
            // textBoxTotalHarga
            // 
            this.textBoxTotalHarga.Location = new System.Drawing.Point(542, 285);
            this.textBoxTotalHarga.Name = "textBoxTotalHarga";
            this.textBoxTotalHarga.Size = new System.Drawing.Size(310, 27);
            this.textBoxTotalHarga.TabIndex = 25;
            // 
            // textBoxTotalPenumpang
            // 
            this.textBoxTotalPenumpang.Location = new System.Drawing.Point(542, 252);
            this.textBoxTotalPenumpang.Name = "textBoxTotalPenumpang";
            this.textBoxTotalPenumpang.Size = new System.Drawing.Size(86, 27);
            this.textBoxTotalPenumpang.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(434, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Total Penumpang";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(434, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Harga Bagasi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(434, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Harga Tiket";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(434, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Total Harga";
            // 
            // comboBoxKotaTujuan
            // 
            this.comboBoxKotaTujuan.FormattingEnabled = true;
            this.comboBoxKotaTujuan.Items.AddRange(new object[] {
            "Tangerang",
            "Bandung",
            "Palembang",
            "Lampung",
            "Bengkulu",
            "Padang",
            "Pekanbaru",
            "Yogyakarta",
            "Semarang",
            "Surabaya",
            "Bali"});
            this.comboBoxKotaTujuan.Location = new System.Drawing.Point(453, 132);
            this.comboBoxKotaTujuan.Name = "comboBoxKotaTujuan";
            this.comboBoxKotaTujuan.Size = new System.Drawing.Size(399, 27);
            this.comboBoxKotaTujuan.TabIndex = 19;
            this.comboBoxKotaTujuan.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisTiket_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(450, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kota Tujuan";
            // 
            // groupBoxBagasi
            // 
            this.groupBoxBagasi.Controls.Add(this.radioButton2);
            this.groupBoxBagasi.Controls.Add(this.radioButton3);
            this.groupBoxBagasi.Controls.Add(this.radioButton1);
            this.groupBoxBagasi.Location = new System.Drawing.Point(453, 37);
            this.groupBoxBagasi.Name = "groupBoxBagasi";
            this.groupBoxBagasi.Size = new System.Drawing.Size(399, 61);
            this.groupBoxBagasi.TabIndex = 17;
            this.groupBoxBagasi.TabStop = false;
            this.groupBoxBagasi.Text = "Bagasi";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(264, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 23);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "31 - 50 Kg";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(142, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 23);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "16 - 30 Kg";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0 - 15 Kg";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Jumlah Penumpang";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(82, 199);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(241, 27);
            this.textBoxHarga.TabIndex = 14;
            this.textBoxHarga.TextChanged += new System.EventHandler(this.textBoxHarga_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Harga";
            // 
            // comboBoxJenisTiket
            // 
            this.comboBoxJenisTiket.FormattingEnabled = true;
            this.comboBoxJenisTiket.Items.AddRange(new object[] {
            "Sleeper",
            "Super Eksekutif",
            "Eksekutif",
            "VIP",
            "Bisnis",
            "AC Ekonomi",
            "Ekonomi"});
            this.comboBoxJenisTiket.Location = new System.Drawing.Point(82, 156);
            this.comboBoxJenisTiket.Name = "comboBoxJenisTiket";
            this.comboBoxJenisTiket.Size = new System.Drawing.Size(241, 27);
            this.comboBoxJenisTiket.TabIndex = 12;
            this.comboBoxJenisTiket.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisTiket_SelectedIndexChanged);
            // 
            // comboBoxKotaAsal
            // 
            this.comboBoxKotaAsal.FormattingEnabled = true;
            this.comboBoxKotaAsal.Items.AddRange(new object[] {
            "Jakarta"});
            this.comboBoxKotaAsal.Location = new System.Drawing.Point(15, 123);
            this.comboBoxKotaAsal.Name = "comboBoxKotaAsal";
            this.comboBoxKotaAsal.Size = new System.Drawing.Size(308, 27);
            this.comboBoxKotaAsal.TabIndex = 11;
            this.comboBoxKotaAsal.Text = "Jakarta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Jenis Tiket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kota Asal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tanggal Keberangkatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonValidasiHitung
            // 
            this.buttonValidasiHitung.Location = new System.Drawing.Point(476, 649);
            this.buttonValidasiHitung.Name = "buttonValidasiHitung";
            this.buttonValidasiHitung.Size = new System.Drawing.Size(113, 23);
            this.buttonValidasiHitung.TabIndex = 3;
            this.buttonValidasiHitung.Text = "Validasi Hitung";
            this.buttonValidasiHitung.UseVisualStyleBackColor = true;
            this.buttonValidasiHitung.Click += new System.EventHandler(this.buttonValidasiHitung_Click);
            // 
            // buttonBayar
            // 
            this.buttonBayar.Location = new System.Drawing.Point(640, 649);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(113, 23);
            this.buttonBayar.TabIndex = 4;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // FormPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 729);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.buttonValidasiHitung);
            this.Controls.Add(this.groupBoxTransportasi);
            this.Controls.Add(this.groupBoxDataPemesanan);
            this.Controls.Add(this.label1);
            this.Name = "FormPemesanan";
            this.Text = "Form Pesan Tiket";
            this.Load += new System.EventHandler(this.FormPemesanan_Load);
            this.groupBoxDataPemesanan.ResumeLayout(false);
            this.groupBoxDataPemesanan.PerformLayout();
            this.groupBoxTransportasi.ResumeLayout(false);
            this.groupBoxTransportasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenumpang)).EndInit();
            this.groupBoxBagasi.ResumeLayout(false);
            this.groupBoxBagasi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDataPemesanan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNohp;
        private System.Windows.Forms.TextBox textBoxNomorIdn;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.GroupBox groupBoxTransportasi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxJenisTiket;
        private System.Windows.Forms.ComboBox comboBoxKotaAsal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.GroupBox groupBoxBagasi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxHargaBagasi;
        private System.Windows.Forms.TextBox textBoxHargaTiket;
        private System.Windows.Forms.TextBox textBoxTotalHarga;
        private System.Windows.Forms.TextBox textBoxTotalPenumpang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxKotaTujuan;
        private System.Windows.Forms.Button buttonValidasiHitung;
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.NumericUpDown numericUpDownPenumpang;
    }
}