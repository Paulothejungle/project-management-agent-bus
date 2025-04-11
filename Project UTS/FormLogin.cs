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
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (username == "user123" && password == "user321")
            {
                MessageBox.Show("Anda berhasil login", "Login sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPemesanan formPemesanan = new FormPemesanan();
                formPemesanan.Show();
                this.Hide();
            }
            else if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                textBoxPassword.Focus();
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password tidak boleh kosong", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
