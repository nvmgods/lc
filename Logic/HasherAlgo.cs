﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RavenDevLauncher.Logic
{
    class HasherAlgo
    {
        #region Encryption

        // string passPhrase = "Pasword";                  // can be any string
        // string saltValue = "sALtValue";                 // can be any string
        //string hashAlgorithm = "SHA1";                   // can be "MD5"
        //int passwordIterations = 7;                      // can be any number
        //string initVector = "~1B2c3D4e5F6g7H8";          // must be 16 bytes
        // int keySize = 256;                              // can be 192 or 128

        public static string Encrypt(string data, string passPhrase = "Paswwrd", string saltValue = "sALtVaLue", string hashAlgorithm = "SHA1",
            int passwordIterations = 7, string initVector = "~1B2c3D785F6g7H8", int keySize = 256)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(initVector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(saltValue);
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            byte[] rgbKey = new PasswordDeriveBytes(passPhrase, rgbSalt, hashAlgorithm, passwordIterations).GetBytes(keySize / 8);
            RijndaelManaged managed = new RijndaelManaged();
            managed.Mode = CipherMode.CBC;
            ICryptoTransform transform = managed.CreateEncryptor(rgbKey, bytes);
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte[] inArray = stream.ToArray();
            stream.Close();
            stream2.Close();
            return Convert.ToBase64String(inArray);
        }

        public static string Decrypt(string data, string passPhrase = "Paswwrd", string saltValue = "sALtVaLue", string hashAlgorithm = "SHA1",
            int passwordIterations = 7, string initVector = "~~1B2c3D785F6g7H8", int keySize = 256)

        {
            byte[] bytes = Encoding.ASCII.GetBytes(initVector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(saltValue);
            byte[] buffer = Convert.FromBase64String(data);
            byte[] rgbKey = new PasswordDeriveBytes(passPhrase, rgbSalt, hashAlgorithm, passwordIterations).GetBytes(keySize / 8);
            RijndaelManaged managed = new RijndaelManaged();
            managed.Mode = CipherMode.CBC;
            ICryptoTransform transform = managed.CreateDecryptor(rgbKey, bytes);
            MemoryStream stream = new MemoryStream(buffer);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            byte[] buffer5 = new byte[buffer.Length];
            int count = stream2.Read(buffer5, 0, buffer5.Length);
            stream.Close();
            stream2.Close();
            return Encoding.UTF8.GetString(buffer5, 0, count);
        }

        #endregion
    }
}
