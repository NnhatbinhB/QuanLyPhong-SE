using System.Collections.Generic;
using System.Linq;
using QuanLyPhong_WinForms_Skeleton.Data;
using QuanLyPhong_WinForms_Skeleton.Models;

namespace QuanLyPhong_WinForms_Skeleton.Services;

public class ApiPhongService
{
    public IEnumerable<Phong> GetAll()
    {
        using var db = new AppDbContext();
        return db.Phongs.ToList();
    }
    public Phong? Get(int id){ using var db=new AppDbContext(); return db.Phongs.FirstOrDefault(x=>x.Id==id); }
    public void Create(Phong p){ using var db=new AppDbContext(); db.Phongs.Add(p); db.SaveChanges(); }
    public void Update(Phong p){ using var db=new AppDbContext(); db.Phongs.Update(p); db.SaveChanges(); }
    public void Delete(int id){ using var db=new AppDbContext(); var p=db.Phongs.FirstOrDefault(x=>x.Id==id); if(p!=null){ db.Phongs.Remove(p); db.SaveChanges(); } }
}
