using EncryptDecryptApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecryptApp
{
    public partial class frmEncryptDecrypt : Form
    {
        public frmEncryptDecrypt()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtPrivateKey.Text))
            {
                MessageBox.Show("You must enter a private key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.txtInput.Text))
            {
                MessageBox.Show("You must text to encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.txtResult.Text = this.txtInput.Text.Encrypt(this.txtPrivateKey.Text);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtPrivateKey.Text))
            {
                MessageBox.Show("You must enter a private key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.txtResult.Text))
            {
                MessageBox.Show("You must text to decrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.txtInput.Text = this.txtResult.Text.Decrypt(this.txtPrivateKey.Text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = String.Empty;
            this.txtResult.Text = String.Empty;
            this.txtPrivateKey.Focus();
        }
    }
}
