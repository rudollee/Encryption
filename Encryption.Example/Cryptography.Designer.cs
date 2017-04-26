namespace Encryption.Example
{
	partial class Cryptography
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
			this.lblKey = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblIV = new System.Windows.Forms.Label();
			this.txtIV = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFlat = new System.Windows.Forms.TextBox();
			this.lblTextDecryptedResult = new System.Windows.Forms.Label();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.lblTextDecrypted = new System.Windows.Forms.Label();
			this.lblTextEncryptedResult = new System.Windows.Forms.Label();
			this.lblTextEncrypted = new System.Windows.Forms.Label();
			this.lblTextFlat = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblKey
			// 
			this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblKey.Location = new System.Drawing.Point(6, 16);
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new System.Drawing.Size(50, 23);
			this.lblKey.TabIndex = 0;
			this.lblKey.Text = "Key";
			// 
			// txtKey
			// 
			this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtKey.Location = new System.Drawing.Point(62, 19);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(398, 23);
			this.txtKey.TabIndex = 1;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(336, 71);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(124, 23);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate Key and IV";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblIV);
			this.groupBox1.Controls.Add(this.lblKey);
			this.groupBox1.Controls.Add(this.btnGenerate);
			this.groupBox1.Controls.Add(this.txtIV);
			this.groupBox1.Controls.Add(this.txtKey);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 97);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Key and IV";
			// 
			// lblIV
			// 
			this.lblIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblIV.Location = new System.Drawing.Point(6, 42);
			this.lblIV.Name = "lblIV";
			this.lblIV.Size = new System.Drawing.Size(50, 23);
			this.lblIV.TabIndex = 0;
			this.lblIV.Text = "IV";
			// 
			// txtIV
			// 
			this.txtIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtIV.Location = new System.Drawing.Point(62, 45);
			this.txtIV.Name = "txtIV";
			this.txtIV.Size = new System.Drawing.Size(398, 23);
			this.txtIV.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtFlat);
			this.groupBox2.Controls.Add(this.lblTextDecryptedResult);
			this.groupBox2.Controls.Add(this.btnEncrypt);
			this.groupBox2.Controls.Add(this.lblTextDecrypted);
			this.groupBox2.Controls.Add(this.lblTextEncryptedResult);
			this.groupBox2.Controls.Add(this.lblTextEncrypted);
			this.groupBox2.Controls.Add(this.lblTextFlat);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 97);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(472, 123);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Encryption and Decryption";
			// 
			// txtFlat
			// 
			this.txtFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtFlat.Location = new System.Drawing.Point(106, 19);
			this.txtFlat.Name = "txtFlat";
			this.txtFlat.Size = new System.Drawing.Size(354, 23);
			this.txtFlat.TabIndex = 4;
			this.txtFlat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFlat_KeyDown);
			// 
			// lblTextDecryptedResult
			// 
			this.lblTextDecryptedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTextDecryptedResult.Location = new System.Drawing.Point(106, 70);
			this.lblTextDecryptedResult.Name = "lblTextDecryptedResult";
			this.lblTextDecryptedResult.Size = new System.Drawing.Size(354, 23);
			this.lblTextDecryptedResult.TabIndex = 0;
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(336, 96);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(124, 23);
			this.btnEncrypt.TabIndex = 5;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// lblTextDecrypted
			// 
			this.lblTextDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTextDecrypted.Location = new System.Drawing.Point(6, 70);
			this.lblTextDecrypted.Name = "lblTextDecrypted";
			this.lblTextDecrypted.Size = new System.Drawing.Size(94, 23);
			this.lblTextDecrypted.TabIndex = 0;
			this.lblTextDecrypted.Text = "Decrypted";
			// 
			// lblTextEncryptedResult
			// 
			this.lblTextEncryptedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTextEncryptedResult.Location = new System.Drawing.Point(106, 45);
			this.lblTextEncryptedResult.Name = "lblTextEncryptedResult";
			this.lblTextEncryptedResult.Size = new System.Drawing.Size(354, 23);
			this.lblTextEncryptedResult.TabIndex = 0;
			// 
			// lblTextEncrypted
			// 
			this.lblTextEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTextEncrypted.Location = new System.Drawing.Point(6, 45);
			this.lblTextEncrypted.Name = "lblTextEncrypted";
			this.lblTextEncrypted.Size = new System.Drawing.Size(94, 23);
			this.lblTextEncrypted.TabIndex = 0;
			this.lblTextEncrypted.Text = "Encrypted";
			// 
			// lblTextFlat
			// 
			this.lblTextFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTextFlat.Location = new System.Drawing.Point(6, 20);
			this.lblTextFlat.Name = "lblTextFlat";
			this.lblTextFlat.Size = new System.Drawing.Size(94, 23);
			this.lblTextFlat.TabIndex = 0;
			this.lblTextFlat.Text = "Flat Text";
			// 
			// Cryptography
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 220);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Cryptography";
			this.Text = "Crypto";
			this.Load += new System.EventHandler(this.Cryptography_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblIV;
		private System.Windows.Forms.TextBox txtIV;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtFlat;
		private System.Windows.Forms.Label lblTextDecryptedResult;
		private System.Windows.Forms.Label lblTextDecrypted;
		private System.Windows.Forms.Label lblTextEncryptedResult;
		private System.Windows.Forms.Label lblTextEncrypted;
		private System.Windows.Forms.Label lblTextFlat;
		private System.Windows.Forms.Button btnEncrypt;
	}
}

