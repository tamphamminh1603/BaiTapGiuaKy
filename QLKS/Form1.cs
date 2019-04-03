using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            txtMatKhau.Focus();
        }
      
        private void dangnhap()
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
                MessageBox.Show("Moi nhap");
            else
                if (this.txtTaiKhoan.Text.Length == 0)
                MessageBox.Show("Ban chua nhap tai khoan");
            else
                if (this.txtMatKhau.Text.Length == 0)
                MessageBox.Show("Ban chua nhap mat khau");
            else

                if (this.txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123456");
            else
                MessageBox.Show("Nhập sai!");
       
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            fQuanLyPhong fm = new fQuanLyPhong();
            if (this.txtTaiKhoan.Text == "admin" && this.txtMatKhau.Text == "123456")
            {
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            dangnhap();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
