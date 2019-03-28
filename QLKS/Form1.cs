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
    public partial class Form1 : Form
    {
        public Form1()
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
                if (this.txtTaiKhoan.Text == "PhamMinhTam" && this.txtMatKhau.Text == "123456")
                MessageBox.Show("Dang nhap thanh cong !");
            else
                MessageBox.Show("Mat khau khong dung");

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            if (this.txtTaiKhoan.Text == "PhamMinhTam" && this.txtMatKhau.Text == "123456")
            {
                fm.Show();
            }
            dangnhap();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
