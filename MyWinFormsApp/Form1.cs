using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormsApp
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

        private void btnChao_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ TextBox có tên là txtTen
            string tenNguoiDung = txtTen.Text;

            // Kiểm tra xem người dùng có nhập tên hay không
            if (string.IsNullOrWhiteSpace(tenNguoiDung))
            {
                // Nếu ô trống, hiển thị một thông báo lỗi
                MessageBox.Show("Bạn chưa nhập tên. Vui lòng nhập tên của bạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Nếu có tên, hiển thị một thông báo chào mừng
                MessageBox.Show($"Chào bạn, {tenNguoiDung}!", "Lời chào", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}