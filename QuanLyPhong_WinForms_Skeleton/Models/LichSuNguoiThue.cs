using System;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class LichSuNguoiThue
{
    public int Id { get; set; }
    public int PhongId { get; set; }
    public Phong Phong { get; set; } = default!;
    public int KhachThueId { get; set; }
    public KhachThue KhachThue { get; set; } = default!;
    public DateTime TuNgay { get; set; }
    public DateTime? DenNgay { get; set; }
}
