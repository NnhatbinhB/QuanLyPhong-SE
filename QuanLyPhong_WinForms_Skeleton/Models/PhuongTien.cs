namespace QuanLyPhong_WinForms_Skeleton.Models;

public class PhuongTien
{
    public int Id { get; set; }
    public int KhachThueId { get; set; }
    public KhachThue KhachThue { get; set; } = default!;
    public string Loai { get; set; } = "Xe máy";
    public string BienSo { get; set; } = string.Empty;
}
