using System.Collections.Generic;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class TienIch
{
    public int Id { get; set; }
    public string TenTienIch { get; set; } = string.Empty;
    public string? MoTa { get; set; }
    public ICollection<PhongTienIch> PhongTienIches { get; set; } = new List<PhongTienIch>();
}

public class PhongTienIch
{
    public int PhongId { get; set; }
    public Phong Phong { get; set; } = default!;
    public int TienIchId { get; set; }
    public TienIch TienIch { get; set; } = default!;
}
