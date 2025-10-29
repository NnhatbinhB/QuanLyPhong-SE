using System;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class GhiDienNuoc
{
    public int Id { get; set; }
    public int PhongId { get; set; }
    public Phong Phong { get; set; } = default!;
    public DateTime NgayGhi { get; set; }
    public string Loai { get; set; } = "Điện";
    public int ChiSoCu { get; set; }
    public int ChiSoMoi { get; set; }
    public string? HinhAnhDongHo { get; set; }
}
