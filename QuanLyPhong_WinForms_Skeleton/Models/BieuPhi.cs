using System;

namespace QuanLyPhong_WinForms_Skeleton.Models;

public class BieuPhi
{
    public int Id { get; set; }
    public string TenPhi { get; set; } = string.Empty;
    public decimal DonGia { get; set; }
    public string DonVi { get; set; } = string.Empty;
    public bool DangApDung { get; set; } = true;
}

public class LichSuBieuPhi
{
    public int Id { get; set; }
    public int BieuPhiId { get; set; }
    public BieuPhi BieuPhi { get; set; } = default!;
    public DateTime TuNgay { get; set; }
    public DateTime? DenNgay { get; set; }
    public decimal DonGia { get; set; }
}
