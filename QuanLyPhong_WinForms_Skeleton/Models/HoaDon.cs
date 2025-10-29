using System;
using System.Collections.Generic;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class HoaDon
{
    public int Id { get; set; }
    public int PhongId { get; set; }
    public Phong Phong { get; set; } = default!;
    public string Thang { get; set; } = string.Empty;
    public DateTime NgayLap { get; set; }
    public DateTime HanThanhToan { get; set; }
    public decimal TongTien { get; set; }
    public string TrangThai { get; set; } = "Chưa thanh toán";

    public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}

public class ChiTietHoaDon
{
    public int Id { get; set; }
    public int HoaDonId { get; set; }
    public HoaDon HoaDon { get; set; } = default!;
    public string MoTa { get; set; } = string.Empty;
    public decimal SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien { get; set; }
}
