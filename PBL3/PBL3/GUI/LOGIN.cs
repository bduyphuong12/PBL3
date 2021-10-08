using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;

namespace PBL3.GUI
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LogInBut_Click(object sender, EventArgs e)
        {
            string TenDangNhap = TenDangNhapText.Text;
            string MatKhau = MatKhauText.Text;

            PHANQUYEN_BLL.Instance.Get_QUYEN_BLL(TenDangNhap, MatKhau);

            if (PHANQUYEN_BLL.Instance.Get_QUYEN_BLL(TenDangNhap, MatKhau) == null)
            {
                MessageBox.Show("Login Fail, Check Your's Account");
            }
            else
            {
                string role = PHANQUYEN_BLL.Instance.Get_QUYEN_BLL(TenDangNhap, MatKhau).Quyen;
                string ten = PHANQUYEN_BLL.Instance.Get_QUYEN_BLL(TenDangNhap, MatKhau).MaNhanVien;
                this.Hide();
                Main form2 = new Main(role, ten);
                form2.ShowDialog();
                this.Close();
            }
        }

        private void TenDangNhapText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                LogInBut_Click(sender, e);
            }
        }

        private void MatKhauText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LogInBut_Click(sender, e);
            }
        }
    }
}
