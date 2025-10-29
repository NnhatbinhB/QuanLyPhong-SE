using System.Linq;
using QuanLyPhong_WinForms_Skeleton.Data;

namespace QuanLyPhong_WinForms_Skeleton.Security;

public static class AuthManager
{
    public static bool Login(string username, string password)
    {
        using var db = new AppDbContext();
        var user = db.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == username);
        if (user == null) return false;
        var hash = Data.SeedData.Sha256(password);
        return string.Equals(user.MatKhauHash, hash, System.StringComparison.OrdinalIgnoreCase);
    }
}
