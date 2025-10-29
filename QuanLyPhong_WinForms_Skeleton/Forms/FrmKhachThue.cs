using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhong_WinForms_Skeleton.Forms
{
    public class FrmKhachThue : Form
    {
        public FrmKhachThue()
        {
            Text = "Quản Lý Khách Thuê";
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.White; Width=900; Height=560;
            var lbl = new Label(){ Text="Quản Lý Khách Thuê  Mở rộng thông tin: thú cưng/xe/ghi chú", AutoSize=true, ForeColor=Color.OrangeRed, Font=new Font("Segoe UI", 12, FontStyle.Bold), Top=20, Left=20 };
            var grid = new DataGridView(){ Top=60, Left=20, Width=840, Height=420, ReadOnly=true, BackgroundColor=Color.White };
            var panel = new FlowLayoutPanel(){ Top=490, Left=20, Width=840, Height=40 };
            panel.Controls.Add(new Button(){ Text="Thêm" });
            panel.Controls.Add(new Button(){ Text="Sửa" });
            panel.Controls.Add(new Button(){ Text="Xóa" });
            Controls.Add(lbl); Controls.Add(grid); Controls.Add(panel);
        }
    }
}
