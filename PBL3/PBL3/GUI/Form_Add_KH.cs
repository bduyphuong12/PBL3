using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.DAL;
using PBL3.BLL;

namespace PBL3.GUI
{
    public partial class Form_Add_KH : Form
    {
        public delegate void mydel(string mkh);
        public mydel Sender;
        string mKH = "";
        private void getData(string _mkh)
        {
            mKH = _mkh;
        }
        public Form_Add_KH()
        {
            InitializeComponent();
            Sender = new mydel(getData);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if(mKH == "")
            {
                KHACHHANG_BLL.Instance.AddKH(addKH());
            }
            else
            {
                KHACHHANG_BLL.Instance.EditKH(addKH());
            }
            Sender("");
            this.Dispose();
        }
        private KHACH_HANG addKH()
        {
            KHACH_HANG s = new KHACH_HANG();
            s.MaKhachHang = textMKH.Text;
            s.TenKhachHang = textTKH.Text;
            s.DiaChi = textDC.Text;
            s.SoDienThoai = textSDT.Text;
            if(Boy.Checked)
            {
                s.GioiTinh = "Nam";
            }
            else
            {
                s.GioiTinh = "Nu";
            }
            s.NgaySinh = Convert.ToDateTime(textDT.Value);
            return s;
        }
        private void setKH()
        {
            KHACH_HANG s = new KHACH_HANG();
            s = KHACHHANG_BLL.Instance.getKHbyMKH(mKH);
            textMKH.Text = s.MaKhachHang;
            textTKH.Text = s.TenKhachHang;
            textDC.Text = s.DiaChi;
            textSDT.Text = s.SoDienThoai;
            if (s.GioiTinh == "Nam") Boy.Checked = true;
            else Girl.Checked = true;
            textDT.Value = (DateTime)s.NgaySinh;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát?");
            Sender("");
            this.Dispose();
        }

        private void Form_Add_KH_Load(object sender, EventArgs e)
        {
            if(mKH != "")
            {
                setKH();
                textMKH.Enabled = false;
            }
        }

        private void textMKH_TextChanged(object sender, EventArgs e)
        {
            string temp = textMKH.Text;
            PBL3_DATABASE db = new PBL3_DATABASE();
            KHACH_HANG sp = db.KHACH_HANG.Find(temp);
            if (sp != null)
            {
                textMKH.Enabled = false;
                mKH = temp;
                setKH();
            }
        }

        private void textSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
