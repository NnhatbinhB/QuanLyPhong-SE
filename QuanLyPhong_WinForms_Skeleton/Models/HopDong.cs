using System;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class HopDong
{
    public int Id { get; set; }
    public int PhongId { get; set; }
    public Phong Phong { get; set; } = default!;
    public int KhachThueId { get; set; }
    public KhachThue KhachThue { get; set; } = default!;
    public DateTime NgayBatDau { get; set; }
    public DateTime NgayKetThuc { get; set; }
    public string TrangThai { get; set; } = "Đang hiệu lực";
    public string? FileHopDongPath { get; set; }
}
