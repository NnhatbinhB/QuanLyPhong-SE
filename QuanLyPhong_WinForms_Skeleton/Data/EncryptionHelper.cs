using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyPhong_WinForms_Skeleton.Data;

public static class EncryptionHelper
{
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("0123456789ABCDEF0123456789ABCDEF");
    private static readonly byte[] Iv  = Encoding.UTF8.GetBytes("0123456789ABCDEF");

    public static string Encrypt(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return plainText;
        using var aes = Aes.Create();
        aes.Key = Key; aes.IV = Iv;
        using var ms = new MemoryStream();
        using var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
        using var sw = new StreamWriter(cs);
        sw.Write(plainText);
        sw.Close();
        return Convert.ToBase64String(ms.ToArray());
    }

    public static string Decrypt(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText)) return cipherText;
        using var aes = Aes.Create();
        aes.Key = Key; aes.IV = Iv;
        using var ms = new MemoryStream(Convert.FromBase64String(cipherText));
        using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
        using var sr = new StreamReader(cs);
        return sr.ReadToEnd();
    }
}
