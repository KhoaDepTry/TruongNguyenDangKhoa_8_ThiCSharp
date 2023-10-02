using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruongNguyenDangKhoa_8_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình Tiện Ích", "Thông Tin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("Họ Và tên: Trương Nguyễn Đăng Khoa" + "\nMSSV:1223360170" + "\nNgày" + DateTime.Now + "\nMôn Thi: Lập Trình Windows 2 - C#");
        }

        private void giảiPhươngTrìnhBật2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giải_Phương_Trình_Bật_2 giải_Phương_Trình_Bật_ = new Giải_Phương_Trình_Bật_2();
           giải_Phương_Trình_Bật_.Show();

        }
    }
}
