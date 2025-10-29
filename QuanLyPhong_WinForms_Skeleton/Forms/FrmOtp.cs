using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyPhong_WinForms_Skeleton.Security;

namespace QuanLyPhong_WinForms_Skeleton.Forms
{
    public class FrmOtp : Form
    {
        private readonly string _username;
        TextBox txt = new(); Button btn = new();
        public FrmOtp(string username)
        {
            _username = username;
            Text="Xác thực OTP"; StartPosition=FormStartPosition.CenterParent; BackColor=Color.White; Width=360; Height=180;
            var title = new Label(){ Text="Nhập mã OTP (6 số)", AutoSize=true, ForeColor=Color.OrangeRed, Font=new Font("Segoe UI", 12, FontStyle.Bold), Top=20, Left=20 };
            txt.SetBounds(24, 60, 300, 23);
            btn.Text="Xác nhận"; btn.SetBounds(24, 95, 300, 30); btn.BackColor=Color.Orange; btn.FlatStyle=FlatStyle.Flat;
            btn.Click += (s,e)=>{
                if (OtpService.Verify(_username, txt.Text.Trim())) { DialogResult = DialogResult.OK; Close(); }
                else MessageBox.Show("Mã OTP không hợp lệ hoặc đã hết hạn!");
            };
            Controls.AddRange(new Control[]{ title, txt, btn });
        }
    }
}
