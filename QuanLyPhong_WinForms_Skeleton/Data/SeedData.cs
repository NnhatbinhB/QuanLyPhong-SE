using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using QuanLyPhong_WinForms_Skeleton.Models;

namespace QuanLyPhong_WinForms_Skeleton.Data;

public static class SeedData
{
    public static void EnsureSeed(AppDbContext db)
    {
        db.Database.EnsureCreated();

        if (!db.NguoiDungs.Any())
        {
            db.NguoiDungs.Add(new NguoiDung{ TenDangNhap="admin", MatKhauHash=Sha256("123456"), HoTen="Quản trị"});
            db.SaveChanges();
        }

        if (!db.LoaiPhongs.Any())
        {
            db.LoaiPhongs.AddRange(new []{
                new LoaiPhong{ TenLoai="Phòng thường"},
                new LoaiPhong{ TenLoai="Phòng nội thất"}
            });
            db.SaveChanges();
        }

        if (!db.Phongs.Any())
        {
            var lp = db.LoaiPhongs.First();
            db.Phongs.AddRange(new []{
                new Phong{ MaPhong="101", TenPhong="Phòng 101", LoaiPhongId=lp.Id, TrangThai="Đang thuê", DienTich=20, GiaThue=3000000 },
                new Phong{ MaPhong="102", TenPhong="Phòng 102", LoaiPhongId=lp.Id, TrangThai="Trống", DienTich=18, GiaThue=2800000 },
                new Phong{ MaPhong="103", TenPhong="Phòng 103", LoaiPhongId=lp.Id, TrangThai="Trống", DienTich=22, GiaThue=3200000 },
                new Phong{ MaPhong="104", TenPhong="Phòng 104", LoaiPhongId=lp.Id, TrangThai="Bảo trì", DienTich=25, GiaThue=3500000 },
                new Phong{ MaPhong="105", TenPhong="Phòng 105", LoaiPhongId=lp.Id, TrangThai="Trống", DienTich=19, GiaThue=2900000 }
            });
            db.SaveChanges();
        }
    }

    public static string Sha256(string s)
    {
        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(s));
        return Convert.ToHexString(bytes);
    }
}
