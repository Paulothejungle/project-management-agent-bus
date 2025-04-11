using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UTS
{
    public partial class FormPembayaran: Form
    {

        public FormPembayaran(string nama, string nohp, string NomorIdn, string alamat, string jenisTiket, string HargaPertiket, string totalBayar, string asalKota, string kotaTujuan, string tanggalPesan, string jumlahPenumpang, string beratBagasi, string hargaBagasi ) 
        {
            InitializeComponent();
            textBoxNama.Text = nama;
            textBoxNoHp.Text = nohp;
            textBoxNoIdn.Text = NomorIdn;
            textBoxAlamat.Text = alamat;
            textBoxJenisTiket.Text = jenisTiket;
            textBoxHargaTiket.Text = HargaPertiket;
            textBoxTotalBayar.Text = totalBayar;
            textBoxAsalKota.Text = asalKota;
            textBoxTujuan.Text = kotaTujuan;
            textBoxTanggalPesan.Text = tanggalPesan;
            textBoxJumlahPenumpang.Text = jumlahPenumpang;
            textBoxBeratBagasi.Text = beratBagasi;
            textBoxHargaBagasi.Text = hargaBagasi;

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMethodBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMethodBayar.Text == "Cash")
            {
                textBoxNamarek.Enabled = false;
                textBoxNorek.Enabled = false;
                textBoxNominaltf.Enabled = false;
                textBoxNominal.Enabled = true;
                textBoxKembalian.Enabled = true;
                textBoxNominal.Clear();
                textBoxKembalian.Clear();
                textBoxNamarek.Clear();
                textBoxNorek.Clear();
                textBoxNominaltf.Clear();
            }
            else if (comboBoxMethodBayar.Text == "Transfer")
            {
                textBoxNamarek.Enabled = true;
                textBoxNorek.Enabled = true;
                textBoxNominaltf.Enabled = true;
                textBoxNominal.Enabled = false;
                textBoxKembalian.Enabled = false;
                textBoxNominaltf.Clear();
                textBoxNamarek.Clear();
                textBoxNorek.Clear();
                textBoxNominal.Clear();
                textBoxKembalian.Clear();
            }
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            if(comboBoxMethodBayar.Text == "")
            {
                MessageBox.Show("Pilih Metode Pembayaran!");
                return;
            }


            string totalText = textBoxTotalBayar.Text.Replace(".", "").Replace(",", "");
            if (!int.TryParse(totalText, out int totalBayar))
            {
                MessageBox.Show("Total Bayar harus berupa angka!");
                return;
            }

           
            if (comboBoxMethodBayar.Text == "Cash")
            {
                string nominalText = textBoxNominal.Text.Replace(".", "").Replace(",", "");
                if (!int.TryParse(nominalText, out int nominal))
                {
                    MessageBox.Show("Nominal harus berupa angka!");
                    return;
                }

                
                int kembalian = nominal - totalBayar;
                textBoxKembalian.Text = kembalian.ToString("N0");
                MessageBox.Show("Pembayaran berhasil!");
                this.Close();
            }
            else if (comboBoxMethodBayar.Text == "Transfer")
            {
                if (string.IsNullOrWhiteSpace(textBoxNamarek.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNorek.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNominaltf.Text))
                {
                    MessageBox.Show("Data tidak boleh kosong.");
                    return;
                }

                MessageBox.Show("Pembayaran Berhasil.");
                this.Close();
            }
        }

    }
}
