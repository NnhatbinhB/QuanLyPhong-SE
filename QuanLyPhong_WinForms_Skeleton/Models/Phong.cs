using System.Collections.Generic;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class Phong
{
    public int Id { get; set; }
    public string MaPhong { get; set; } = string.Empty;
    public string? TenPhong { get; set; }
    public int LoaiPhongId { get; set; }
    public LoaiPhong LoaiPhong { get; set; } = default!;
    public decimal DienTich { get; set; }
    public decimal GiaThue { get; set; }
    public string TrangThai { get; set; } = "Trống";
    public string? GhiChu { get; set; }

    public ICollection<PhongTienIch> TienIchPhong { get; set; } = new List<PhongTienIch>();
    public ICollection<HopDong> HopDongs { get; set; } = new List<HopDong>();
    public ICollection<LichSuNguoiThue> LichSuNguoiThue { get; set; } = new List<LichSuNguoiThue>();
    public ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
