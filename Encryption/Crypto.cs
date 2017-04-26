using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
	/// <summary>
	/// reference: https://msdn.microsoft.com/en-gb/library/system.security.cryptography.tripledescryptoserviceprovider(v=vs.110).aspx
	/// </summary>
	public class Crypto
    {
		public List<byte[]> GenerateKeyAndIV()
		{
			TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();

			return new List<byte[]> { tDES.Key, tDES.IV };
		}

		public string Encrypt(string s, byte[] key, byte[] iv)
		{
			try
			{
				MemoryStream mStream = new MemoryStream();
				CryptoStream cStream = new CryptoStream(mStream, new TripleDESCryptoServiceProvider().CreateEncryptor(key, iv), CryptoStreamMode.Write);
				byte[] toEncrypt = new UTF8Encoding().GetBytes(s);

				cStream.Write(toEncrypt, 0, toEncrypt.Length);
				cStream.FlushFinalBlock();

				byte[] bytesEncrypted = mStream.ToArray();

				cStream.Close();
				mStream.Close();

				return Convert.ToBase64String(bytesEncrypted, 0, bytesEncrypted.Length);
			}
			catch (CryptographicException e)
			{
				Console.WriteLine("Error: {0}", e.Message);
				return null;
			}
		}

		public string Decrypt(string s, byte[] key, byte[] iv)
		{
			try
			{
				byte[] bytesEncrypted = Convert.FromBase64String(s);
				MemoryStream mStream = new MemoryStream(bytesEncrypted);
				CryptoStream cStream = new CryptoStream(mStream, new TripleDESCryptoServiceProvider().CreateDecryptor(key, iv), CryptoStreamMode.Read);
				byte[] fromEncrypt = new byte[s.Length];

				cStream.Read(fromEncrypt, 0, fromEncrypt.Length);

				return new UTF8Encoding().GetString(fromEncrypt);
			}
			catch (CryptographicException e)
			{
				Console.WriteLine("Error: {0}", e.Message);
				return null;
			}
		}

	}
}
