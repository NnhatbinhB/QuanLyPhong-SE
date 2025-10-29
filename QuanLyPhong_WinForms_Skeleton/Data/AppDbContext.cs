using Microsoft.EntityFrameworkCore;
using QuanLyPhong_WinForms_Skeleton.Models;
using System.IO;

namespace QuanLyPhong_WinForms_Skeleton.Data;

public class AppDbContext : DbContext
{
    public DbSet<NguoiDung> NguoiDungs => Set<NguoiDung>();
    public DbSet<Phong> Phongs => Set<Phong>();
    public DbSet<LoaiPhong> LoaiPhongs => Set<LoaiPhong>();
    public DbSet<TienIch> TienIches => Set<TienIch>();
    public DbSet<PhongTienIch> PhongTienIches => Set<PhongTienIch>();
    public DbSet<KhachThue> KhachThues => Set<KhachThue>();
    public DbSet<HopDong> HopDongs => Set<HopDong>();
    public DbSet<LichSuNguoiThue> LichSuNguoiThues => Set<LichSuNguoiThue>();
    public DbSet<HoaDon> HoaDons => Set<HoaDon>();
    public DbSet<ChiTietHoaDon> ChiTietHoaDons => Set<ChiTietHoaDon>();
    public DbSet<GhiDienNuoc> GhiDienNuocs => Set<GhiDienNuoc>();
    public DbSet<BieuPhi> BieuPhis => Set<BieuPhi>();
    public DbSet<LichSuBieuPhi> LichSuBieuPhis => Set<LichSuBieuPhi>();
    public DbSet<PhuongTien> PhuongTiens => Set<PhuongTien>();
    public DbSet<VanTay> VanTays => Set<VanTay>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "qlphong.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<NguoiDung>().HasIndex(x => x.TenDangNhap).IsUnique();

        b.Entity<PhongTienIch>().HasKey(x => new { x.PhongId, x.TienIchId });
        b.Entity<PhongTienIch>().HasOne(x => x.Phong).WithMany(x => x.TienIchPhong).HasForeignKey(x => x.PhongId);
        b.Entity<PhongTienIch>().HasOne(x => x.TienIch).WithMany(x => x.PhongTienIches).HasForeignKey(x => x.TienIchId);

        b.Entity<LichSuNguoiThue>().HasOne(x => x.Phong).WithMany(x => x.LichSuNguoiThue).HasForeignKey(x => x.PhongId);
        b.Entity<LichSuNguoiThue>().HasOne(x => x.KhachThue).WithMany(x => x.LichSuNguoiThue).HasForeignKey(x => x.KhachThueId);

        b.Entity<HopDong>().HasOne(x=>x.Phong).WithMany(x=>x.HopDongs).HasForeignKey(x=>x.PhongId);
        b.Entity<HopDong>().HasOne(x=>x.KhachThue).WithMany(x=>x.HopDongs).HasForeignKey(x=>x.KhachThueId);

        b.Entity<ChiTietHoaDon>().HasOne(x=>x.HoaDon).WithMany(x=>x.ChiTietHoaDons).HasForeignKey(x=>x.HoaDonId);
    }
}
