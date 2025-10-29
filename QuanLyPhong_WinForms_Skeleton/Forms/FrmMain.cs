using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyPhong_WinForms_Skeleton.Models;

namespace QuanLyPhong_WinForms_Skeleton.Forms
{
    public class FrmMain : Form
    {
        private MenuStrip menu;
        private ToolStripMenuItem mPhong, mLoaiPhong, mTienIch, mKhach, mHopDong, mHoaDon, mDienNuoc, mBaoTri, mBaoCao, mBackup, mVanTay, mThanhToan, mThoat;
        private Label lbl;

        public FrmMain(NguoiDung user)
        {
            Text = "Quản Lý Phòng - Skeleton"; StartPosition = FormStartPosition.CenterScreen; BackColor = Color.White;
            Width=1000; Height=640;
            menu = new MenuStrip();
            mPhong = new ToolStripMenuItem("Phòng"); mLoaiPhong = new ToolStripMenuItem("Loại phòng"); mTienIch = new ToolStripMenuItem("Tiện ích");
            mKhach = new ToolStripMenuItem("Khách thuê"); mHopDong = new ToolStripMenuItem("Hợp đồng"); mHoaDon = new ToolStripMenuItem("Hóa đơn");
            mDienNuoc = new ToolStripMenuItem("Điện/Nước"); mBaoTri = new ToolStripMenuItem("Bảo trì"); mBaoCao = new ToolStripMenuItem("Báo cáo");
            mBackup = new ToolStripMenuItem("Backup"); mVanTay = new ToolStripMenuItem("Vân tay"); mThanhToan = new ToolStripMenuItem("Cài đặt thanh toán");
            mThoat = new ToolStripMenuItem("Thoát");
            menu.Items.AddRange(new ToolStripItem[]{ mPhong, mLoaiPhong, mTienIch, mKhach, mHopDong, mHoaDon, mDienNuoc, mBaoTri, mBaoCao, mBackup, mVanTay, mThanhToan, mThoat });
            Controls.Add(menu);

            lbl = new Label(){ Text=$"Xin chào, {user.HoTen ?? user.TenDangNhap}", AutoSize=true, ForeColor=Color.OrangeRed, Font=new Font("Segoe UI", 14, FontStyle.Bold), Top=60, Left=20 };
            Controls.Add(lbl);

            mPhong.Click += (_,__) => new FrmPhong().ShowDialog();
            mLoaiPhong.Click += (_,__) => new FrmLoaiPhong().ShowDialog();
            mTienIch.Click += (_,__) => new FrmTienIch().ShowDialog();
            mKhach.Click += (_,__) => new FrmKhachThue().ShowDialog();
            mHopDong.Click += (_,__) => new FrmHopDong().ShowDialog();
            mHoaDon.Click += (_,__) => new FrmHoaDon().ShowDialog();
            mDienNuoc.Click += (_,__) => new FrmDienNuoc().ShowDialog();
            mBaoTri.Click += (_,__) => new FrmBaoTri().ShowDialog();
            mBaoCao.Click += (_,__) => new FrmBaoCao().ShowDialog();
            mBackup.Click += (_,__) => new FrmBackup().ShowDialog();
            mVanTay.Click += (_,__) => new FrmVanTay().ShowDialog();
            mThanhToan.Click += (_,__) => new FrmCaiDatThanhToan().ShowDialog();
            mThoat.Click += (_,__) => Application.Exit();
        }
    }
}
