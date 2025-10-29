using System.Security.Cryptography;
using System.Text;

namespace QuanLyPhong_WinForms_Skeleton.Security;

public static class HashHelper
{
    public static string Sha256(string s)
    {
        using var sha = SHA256.Create();
        return Convert.ToHexString(sha.ComputeHash(Encoding.UTF8.GetBytes(s)));
    }
}
