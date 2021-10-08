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
    public partial class Form_NV_Add : Form
    {
        public delegate void mydel2(string msNV);
        public mydel2 Sender;

        string msNV = "";

        private void getData(string _msNV)
        {
            msNV = _msNV;

        }
        public Form_NV_Add()
        {
            InitializeComponent();
            Sender = new mydel2(getData);

        }
        private NHAN_VIEN getNVadd()
        {
            NHAN_VIEN s = new NHAN_VIEN();
            s.MaNhanVien = txtmaNV.Text;
            s.TenNhanVien = txtname.Text;
            s.DiaChi = txtdiachi.Text;
            s.SoDienThoai = txtsdt.Text;
            s.NgayVaoLam = Convert.ToDateTime(dateNVL.Value);
            s.SoCMND = txtcmnd.Text;
            s.Email = txtEmail.Text;
            s.ChucVu = txtchucvu.Text;
            if (rdbfmale.Checked)
            {
                s.GioiTinh = "nu";
            }
            else
            {
                s.GioiTinh = "nam";
            }
            s.NgaySinh = Convert.ToDateTime(dateNS.Value);
            return s;

        }
        private PHAN_QUYEN getTKadd()
        {
            PHAN_QUYEN s = new PHAN_QUYEN();
            s.TenDangNhap = textUN.Text;
            s.MatKhau = textMK.Text;
            s.MaNhanVien = txtmaNV.Text;
            s.Quyen = "user";
            return s;
        }
        private void setNV()
        {
            NHAN_VIEN st = new NHAN_VIEN();
            st = NHANVIEN_BLL.Instance.getNVbyMaNV(msNV);
            txtmaNV.Text = st.MaNhanVien;
            txtname.Text = st.TenNhanVien;
            txtdiachi.Text = st.DiaChi;
            txtsdt.Text = st.SoDienThoai;
            txtEmail.Text = st.Email;
            txtchucvu.Text = st.ChucVu;
            txtcmnd.Text = st.SoCMND;
            dateNVL.Value = (DateTime)st.NgayVaoLam;
            if (st.GioiTinh == "nam") rdbm.Checked = true;
            else rdbfmale.Checked = true;
            dateNS.Value = (DateTime)st.NgaySinh;
        }
        private void setPQ()
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            PHAN_QUYEN s = new PHAN_QUYEN();
            s = db.PHAN_QUYEN.Where(p => p.MaNhanVien == msNV).FirstOrDefault();
            textUN.Text = s.TenDangNhap;
            textMK.Text = s.MatKhau;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (msNV == "")
            {
                NHANVIEN_BLL.Instance.ADDNV_BLL(getNVadd());
                PHANQUYEN_BLL.Instance.AddPQ_BLL(getTKadd());
            }
            else
            {
                NHANVIEN_BLL.Instance.EditNV_BLL(getNVadd());
                PHANQUYEN_BLL.Instance.EditPQ_BLL(getTKadd());
            }
            Form_NV f1 = new Form_NV();
            f1.Show();
            Sender("");
            this.Dispose();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban co chac chan muon thoat khong?");
            Form_NV f1 = new Form_NV();
            f1.Show();
            Sender("");
            this.Dispose();
        }

        private void form_NV_ADD_Load(object sender, EventArgs e)
        {
            if (msNV != "")
            {
                setNV();
                setPQ();
                txtmaNV.Enabled = false;

            }
        }
    }
}
