using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption;

namespace Encryption.Example
{
	public partial class Cryptography : Form
	{
		List<byte[]> KEYS = new Crypto().GenerateKeyAndIV();
		public Cryptography()
		{
			InitializeComponent();
		}

		private void Cryptography_Load(object sender, EventArgs e)
		{
			this.GenerateKeyAndIV();
		}

		private void GenerateKeyAndIV()
		{
			string[] str = new string[] { string.Empty, string.Empty };

			for (int i = 0; i < 2; i++)
			{
				foreach (byte b in this.KEYS[i])
				{
					str[i] += b.ToString() + ", ";
				}
			}
			this.txtKey.Text = str[0].Substring(0, str[0].Length - 2);
			this.txtIV.Text = str[1].Substring(0, str[1].Length - 2);
		}

		private void EncryptAndDecrypt()
		{
			Crypto crypto = new Crypto();

			if (this.txtFlat.Text.Length > 0)
			{
				this.lblTextEncryptedResult.Text = crypto.Encrypt(this.txtFlat.Text, this.KEYS[0], this.KEYS[1]);
				this.lblTextDecryptedResult.Text = crypto.Decrypt(this.lblTextEncryptedResult.Text, this.KEYS.ElementAt(0), this.KEYS.ElementAt(1));
			}
			else
			{
				MessageBox.Show("Enter any word in the flat text box");
				this.txtFlat.Focus();
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			this.GenerateKeyAndIV();
			this.txtFlat.Focus();
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			this.EncryptAndDecrypt();
		}

		private void txtFlat_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					this.EncryptAndDecrypt();
					break;
			}
		}

	}
}
