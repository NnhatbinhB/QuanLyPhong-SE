using System;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class VanTay
{
    public int Id { get; set; }
    public int KhachThueId { get; set; }
    public KhachThue KhachThue { get; set; } = default!;
    public string TrangThai { get; set; } = "Kích hoạt";
    public DateTime NgayTao { get; set; } = DateTime.UtcNow;
}
