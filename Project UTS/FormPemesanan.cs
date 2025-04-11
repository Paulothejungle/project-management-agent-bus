using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UTS
{
    public partial class FormPemesanan: Form
    {
        public FormPemesanan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            buttonBayar.Enabled = false;
        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private int GethargaTiket(string tujuan, string jenis)
        {
            if (tujuan == "Tangerang" && jenis == "Bisnis") return 30000;
            else if (tujuan == "Bandung" && jenis == "Sleeper") return 150000;
            else if (tujuan == "Bandung" && jenis == "Super Eksekutif") return 120000;
            else if (tujuan == "Bandung" && jenis == "Eksekutif") return 100000;
            else if (tujuan == "Bandung" && jenis == "VIP") return 80000;
            else if (tujuan == "Bandung" && jenis == "AC Ekonomi") return 50000;
            else if (tujuan == "Bandung" && jenis == "Ekonomi") return 30000;
            else if (tujuan == "Bandung" && jenis == "Bisnis") return 70000;
            else if (tujuan == "Palembang" && jenis == "Sleeper") return 600000;
            else if (tujuan == "Palembang" && jenis == "Super Eksekutif") return 550000;
            else if (tujuan == "Palembang" && jenis == "Eksekutif") return 500000;
            else if (tujuan == "Palembang" && jenis == "VIP") return 470000;
            else if (tujuan == "Palembang" && jenis == "Bisnis") return 450000;
            else if (tujuan == "Palembang" && jenis == "AC Ekonomi") return 430000;
            else if (tujuan == "Palembang" && jenis == "Ekonomi") return 400000;
            else if (tujuan == "Lampung" && jenis == "Sleeper") return 470000;
            else if (tujuan == "Lampung" && jenis == "Super Eksekutif") return 440000;
            else if (tujuan == "Lampung" && jenis == "Eksekutif") return 400000;
            else if (tujuan == "Lampung" && jenis == "VIP") return 380000;
            else if (tujuan == "Lampung" && jenis == "Bisnis") return 350000;
            else if (tujuan == "Lampung" && jenis == "AC Ekonomi") return 320000;
            else if (tujuan == "Lampung" && jenis == "Ekonomi") return 300000;
            else if (tujuan == "Bengkulu" && jenis == "Sleeper") return 610000;
            else if (tujuan == "Bengkulu" && jenis == "Super Eksekutif") return 580000;
            else if (tujuan == "Bengkulu" && jenis == "Eksekutif") return 550000;
            else if (tujuan == "Bengkulu" && jenis == "VIP") return 520000;
            else if (tujuan == "Bengkulu" && jenis == "Bisnis") return 490000;
            else if (tujuan == "Bengkulu" && jenis == "AC Ekonomi") return 470000;
            else if (tujuan == "Bengkulu" && jenis == "Ekonomi") return 450000;
            else if (tujuan == "Padang" && jenis == "Sleeper") return 700000;
            else if (tujuan == "Padang" && jenis == "Super Eksekutif") return 650000;
            else if (tujuan == "Padang" && jenis == "Eksekutif") return 620000;
            else if (tujuan == "Padang" && jenis == "VIP") return 590000;
            else if (tujuan == "Padang" && jenis == "Bisnis") return 550000;
            else if (tujuan == "Padang" && jenis == "AC Ekonomi") return 530000;
            else if (tujuan == "Padang" && jenis == "Ekonomi") return 550000;
            else if (tujuan == "Pekanbaru" && jenis == "Sleeper") return 770000;
            else if (tujuan == "Pekanbaru" && jenis == "Super Eksekutif") return 720000;
            else if (tujuan == "Pekanbaru" && jenis == "Eksekutif") return 690000;
            else if (tujuan == "Pekanbaru" && jenis == "VIP") return 650000;
            else if (tujuan == "Pekanbaru" && jenis == "Bisnis") return 630000;
            else if (tujuan == "Pekanbaru" && jenis == "AC Ekonomi") return 620000;
            else if (tujuan == "Pekanbaru" && jenis == "Ekonomi") return 600000;
            else if (tujuan == "Yogyakarta" && jenis == "Sleeper") return 400000;
            else if (tujuan == "Yogyakarta" && jenis == "Super Eksekutif") return 350000;
            else if (tujuan == "Yogyakarta" && jenis == "Eksekutif") return 330000;
            else if (tujuan == "Yogyakarta" && jenis == "VIP") return 310000;
            else if (tujuan == "Yogyakarta" && jenis == "Bisnis") return 300000;
            else if (tujuan == "Yogyakarta" && jenis == "AC Ekonomi") return 280000;
            else if (tujuan == "Yogyakarta" && jenis == "Ekonomi") return 250000;
            else if (tujuan == "Semarang" && jenis == "Sleeper") return 370000;
            else if (tujuan == "Semarang" && jenis == "Super Eksekutif") return 330000;
            else if (tujuan == "Semarang" && jenis == "Eksekutif") return 300000;
            else if (tujuan == "Semarang" && jenis == "VIP") return 290000;
            else if (tujuan == "Semarang" && jenis == "Bisnis") return 250000;
            else if (tujuan == "Semarang" && jenis == "AC Ekonomi") return 230000;
            else if (tujuan == "Semarang" && jenis == "Ekonomi") return 200000;
            else if (tujuan == "Surabaya" && jenis == "Sleeper") return 450000;
            else if (tujuan == "Surabaya" && jenis == "Super Eksekutif") return 400000;
            else if (tujuan == "Surabaya" && jenis == "Eksekutif") return 380000;
            else if (tujuan == "Surabaya" && jenis == "VIP") return 370000;
            else if (tujuan == "Surabaya" && jenis == "Bisnis") return 350000;
            else if (tujuan == "Surabaya" && jenis == "AC Ekonomi") return 330000;
            else if (tujuan == "Surabaya" && jenis == "Ekonomi") return 300000;
            else if (tujuan == "Bali" && jenis == "Sleeper") return 1100000;
            else if (tujuan == "Bali" && jenis == "Super Eksekutif") return 800000;
            else if (tujuan == "Bali" && jenis == "Eksekutif") return 750000;
            else if (tujuan == "Bali" && jenis == "VIP") return 700000;
            else if (tujuan == "Bali" && jenis == "Bisnis") return 670000;
            else if (tujuan == "Bali" && jenis == "AC Ekonomi") return 640000;
            else if (tujuan == "Bali" && jenis == "Ekonomi") return 600000;


            return 0;
        }

        private void buttonValidasiHitung_Click(object sender, EventArgs e)
        {
            buttonBayar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                textBoxNama.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBoxNohp.Text) || !textBoxNohp.Text.All(char.IsDigit))
            {
                MessageBox.Show("No Telepon harus berupa angka");
                textBoxNohp.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBoxNomorIdn.Text) || !textBoxNomorIdn.Text.All(char.IsDigit))
            {
                MessageBox.Show("Nomor Identitas harus berupa angka");
                textBoxNomorIdn.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBoxAlamat.Text))
            {
                MessageBox.Show("Alamat tidak boleh kosong");
                textBoxAlamat.Focus();
                return;
            }
            else if (comboBoxKotaTujuan.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan pilih kota tujuan");
                comboBoxKotaTujuan.Focus();
                return;
            }
            else if (numericUpDownPenumpang.Value == 0)
            {
                MessageBox.Show("Silahkan pilih jumlah penumpang");
                numericUpDownPenumpang.Focus();
                return;
            }
            else if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Silahkan pilih berat bagasi");
                radioButton1.Focus();
                radioButton2.Focus();
                radioButton3.Focus();
                return;
            }

            string kotaTujuan = comboBoxKotaTujuan.SelectedItem.ToString();
            string jenisTiket = comboBoxJenisTiket.SelectedItem.ToString();

            int jumlahPenumpang = (int)numericUpDownPenumpang.Value;
           
            int hargaTiket = GethargaTiket(kotaTujuan, jenisTiket);

            int hargaBagasi = 0;
            if (radioButton1.Checked) hargaBagasi = 0;
            else if (radioButton2.Checked) hargaBagasi = 35000;
            else if (radioButton3.Checked) hargaBagasi = 50000;

            int totalHarga = (hargaTiket * jumlahPenumpang) + hargaBagasi;

            //textBoxHarga.Text = hargaTiket.ToString();
            textBoxHargaTiket.Text = hargaTiket.ToString("N0");
            textBoxTotalPenumpang.Text = jumlahPenumpang.ToString("N0");
            textBoxTotalHarga.Text = totalHarga.ToString("N0");
            textBoxHargaBagasi.Text = hargaBagasi.ToString("N0");

            buttonBayar.Enabled = true;
        }

        private void comboBoxJenisTiket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKotaTujuan.SelectedItem != null && comboBoxJenisTiket.SelectedItem != null)
            {
                string tujuan = comboBoxKotaTujuan.SelectedItem.ToString();
                string tiket = comboBoxJenisTiket.SelectedItem.ToString();

                int harga = GethargaTiket(tujuan, tiket);
                textBoxHarga.Text = harga.ToString("N0");
            }
        }

        private void textBoxNomorIdn_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNomorIdn.Text.Length > 10)
            {
                MessageBox.Show("Nomor Identitas tidak boleh lebih dari 10 digit");
                textBoxNomorIdn.Text = textBoxNomorIdn.Text.Substring(0, 10);
                textBoxNomorIdn.SelectionStart = textBoxNomorIdn.Text.Length;
            }
        }

        private string GetSelectedBeratBagasi()
        {
            if (radioButton1.Checked)
                return "0";
            else if (radioButton2.Checked)
                return "35000";
            else if (radioButton3.Checked)
                return "50000";
            else
                return "0"; // jika tidak ada yang dipilih
        }


        private void buttonBayar_Click(object sender, EventArgs e)
        {

            string selectedBeratBagasi = GetSelectedBeratBagasi();

            FormPembayaran formPembayaran = new FormPembayaran(
                textBoxNama.Text,
                textBoxNohp.Text,
                textBoxNomorIdn.Text,
                textBoxAlamat.Text,
                comboBoxJenisTiket.Text,
                textBoxHargaTiket.Text,
                textBoxTotalHarga.Text,
                comboBoxKotaAsal.Text,
                comboBoxKotaTujuan.Text,
                dateTimePicker1.Value.ToString("dd/MM/yyyy"),
                textBoxTotalPenumpang.Text,
                selectedBeratBagasi,
                textBoxHargaBagasi.Text
            );
            formPembayaran.Show();
            this.Hide();
        }
    }
}
