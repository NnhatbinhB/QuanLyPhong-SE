using System;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class NguoiDung
{
    public int Id { get; set; }
    public string TenDangNhap { get; set; } = string.Empty;
    public string MatKhauHash { get; set; } = string.Empty;
    public string? HoTen { get; set; }
    public string? Email { get; set; }
    public DateTime NgayTao { get; set; } = DateTime.UtcNow;
}
