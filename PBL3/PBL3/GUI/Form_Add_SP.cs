using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.GUI
{
    public partial class Form_Add_SP : Form
    {
        public delegate void mydel(string msp);
        public mydel Sender;

        string msp = "";
        private void getData(string _msp)
        {
            msp = _msp;

        }
        public Form_Add_SP()
        {
            InitializeComponent();
            Sender = new mydel(getData);
        }
        private SAN_PHAM getSPadd()
        {
            SAN_PHAM s = new SAN_PHAM();
            s.MaSanPham = textMSP.Text;
            s.TenSanPham = textTSP.Text;
            s.LoaiSanPham = comboLSP.Text;
            s.GiaBan = Convert.ToInt32(textGB.Text);
            s.GiaNhap = Convert.ToInt32(textGN.Text);
            s.MaHangSanXuat = textMHSX.Text;
            s.SoLuongTonKho = Convert.ToInt32(textSLTK.Text);
            return s;
        }
        private CHI_TIET_SAN_PHAM getCTSPadd()
        {
            CHI_TIET_SAN_PHAM st = new CHI_TIET_SAN_PHAM();
            st.MaSanPham = textMSP.Text;
            st.XuatXu = textXX.Text;
            st.Mau = textM.Text;
            st.Size = Convert.ToInt32(textS.Text);
            st.MoTaSanPham = textMT.Text;
            st.GioiTinh = comboGT.Text;
            st.GiaBan = Convert.ToInt32(textGB.Text);
            return st;
        }


        private void butOK_Click(object sender, EventArgs e)
        {
            if (msp == "")
            {
                SANPHAM_BLL.Instance.Add_SP(getSPadd());
                CHITIETSANPHAM_BLL.Instance.addSP(getCTSPadd());
            }
            else
            {
                SANPHAM_BLL.Instance.Edit_SP(getSPadd());
                CHITIETSANPHAM_BLL.Instance.EditSP(getCTSPadd());
            }
            Sender("");
            this.Dispose();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?");
            Sender("");
            this.Dispose();
        }
        private void setSP()
        {
            SAN_PHAM st = new SAN_PHAM();
            st = SANPHAM_BLL.Instance.getSPbyMSP(msp);
            textMSP.Text = st.MaSanPham;
            textTSP.Text = st.TenSanPham;
            textGB.Text = Convert.ToString(st.GiaBan);
            textGN.Text = Convert.ToString(st.GiaNhap);
            textMHSX.Text = st.MaHangSanXuat;
            comboLSP.Text = st.LoaiSanPham;
            textSLTK.Text = Convert.ToString(st.SoLuongTonKho);
            textXX.Text = st.CHI_TIET_SAN_PHAM.XuatXu;
            textM.Text = st.CHI_TIET_SAN_PHAM.Mau;
            textMT.Text = st.CHI_TIET_SAN_PHAM.MoTaSanPham;
            textS.Text = Convert.ToString(st.CHI_TIET_SAN_PHAM.Size);
            comboGT.Text = st.CHI_TIET_SAN_PHAM.GioiTinh;
        }
        private void Form_Add_SP_Load(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            comboLSP.DataSource = db.SAN_PHAM.Select(p => p.LoaiSanPham).ToList();
            comboLSP.DisplayMember = "LoaiSanPham";
            if (msp != "")
            {
                setSP();
                textMSP.Enabled = false;
            }
        }

        private void textGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textMSP_TextChanged(object sender, EventArgs e)
        { 
            string temp = textMSP.Text;
            PBL3_DATABASE db = new PBL3_DATABASE();
            SAN_PHAM sp = db.SAN_PHAM.Find(temp);
            if (sp != null)
            {
                textMSP.Enabled = false;
                msp = temp;
                setSP();
            }
        }
    }
}
