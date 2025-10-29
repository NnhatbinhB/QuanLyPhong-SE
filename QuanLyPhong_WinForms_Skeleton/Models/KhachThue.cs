using System;
using System.Collections.Generic;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class KhachThue
{
    public int Id { get; set; }
    public string HoTen { get; set; } = string.Empty;
    public string? DienThoai { get; set; }
    public string? CCCD_MaHoa { get; set; }
    public string? GhiChu { get; set; }
    public bool? CoThuCung { get; set; }

    public ICollection<HopDong> HopDongs { get; set; } = new List<HopDong>();
    public ICollection<LichSuNguoiThue> LichSuNguoiThue { get; set; } = new List<LichSuNguoiThue>();
    public ICollection<PhuongTien> PhuongTiens { get; set; } = new List<PhuongTien>();
    public ICollection<VanTay> VanTays { get; set; } = new List<VanTay>();
}
