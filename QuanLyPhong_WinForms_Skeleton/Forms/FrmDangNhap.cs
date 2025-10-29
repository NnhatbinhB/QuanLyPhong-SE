using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyPhong_WinForms_Skeleton.Data;
using QuanLyPhong_WinForms_Skeleton.Security;
using QuanLyPhong_WinForms_Skeleton.Models;

namespace QuanLyPhong_WinForms_Skeleton.Forms
{
    public class FrmDangNhap : Form
    {
        TextBox txtUser = new(); TextBox txtPass = new(); Button btn = new();
        public FrmDangNhap()
        {
            Text = "Đăng nhập"; StartPosition = FormStartPosition.CenterScreen; BackColor=Color.White; Width=420; Height=240;
            var title = new Label(){ Text="Quản Lý Phòng – Đăng nhập", AutoSize=true, ForeColor=Color.OrangeRed, Font=new Font("Segoe UI", 14, FontStyle.Bold), Top=16, Left=20 };
            var lu = new Label(){ Text="Tên đăng nhập", Top=70, Left=20, AutoSize=true };
            var lp = new Label(){ Text="Mật khẩu", Top=100, Left=20, AutoSize=true };
            txtUser.SetBounds(140, 66, 240, 23);
            txtPass.SetBounds(140, 96, 240, 23); txtPass.PasswordChar='•';
            btn.Text = "Đăng nhập"; btn.SetBounds(140, 140, 240, 32); btn.BackColor=Color.Orange; btn.FlatStyle=FlatStyle.Flat;
            btn.Click += Btn_Click;
            Controls.AddRange(new Control[]{ title, lu, lp, txtUser, txtPass, btn });
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            using var db = new AppDbContext();
            SeedData.EnsureSeed(db);
            var ok = AuthManager.Login(txtUser.Text.Trim(), txtPass.Text.Trim());
            if (!ok){ MessageBox.Show("Sai tài khoản hoặc mật khẩu"); return; }

            var code = OtpService.Generate(txtUser.Text.Trim());
            MessageBox.Show($"Mã OTP demo: {code} (tạm thời hiển thị trực tiếp)", "OTP Demo");

            Hide();
            using (var f = new FrmOtp(txtUser.Text.Trim()))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    var user = db.NguoiDungs.First(x=>x.TenDangNhap==txtUser.Text.Trim());
                    using (var m = new FrmMain(user)) m.ShowDialog();
                    Close();
                }
                else
                {
                    Show();
                }
            }
        }
    }
}
