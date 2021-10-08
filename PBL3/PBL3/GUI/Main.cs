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
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.GUI
{
    public partial class Main : Form
    {
        private string role;
        private string TenNhanVien;
        public Main(string quyen, string ten)
        {
            InitializeComponent();
            this.role = quyen;
            this.TenNhanVien = ten;
            setCBBSP();
            setCBBKH();
            DataSP.DataSource = SANPHAM_BLL.Instance.Get_SP_view("");
            DataSP.Columns["CHI_TIET_DON_HANG"].Visible = false;
            DataSP.Columns["CHI_TIET_SAN_PHAM"].Visible = false;
            Start();
            groupSP.Show();
            designmenu();
            panelhome.Visible = true;

        }
        public Main()
        {
            InitializeComponent();
            setCBBSP();
            setCBBKH();
            DataSP.DataSource = SANPHAM_BLL.Instance.Get_SP_view("");
            DataSP.Columns["CHI_TIET_DON_HANG"].Visible = false;
            DataSP.Columns["CHI_TIET_SAN_PHAM"].Visible = false;
            DataSP.Columns["GOI_Y_SAN_PHAM"].Visible = false;
            Start();
            groupSP.Show();
           
        }
        public void designmenu()
        {
            panelmenu.Visible = false;
        }
        public void hidemenu()
        {
            if (panelmenu.Visible == true)
                panelmenu.Visible = false;
        }
        public void showmenu(Panel pn)
        {
            if(panelmenu.Visible==false)
            {
                hidemenu();
                panelmenu.Visible = true;
            }    
            else
            {
                panelmenu.Visible = false;
            }    
        }
        private void btmenu_Click(object sender, EventArgs e)
        {
            showmenu(panelmenu);
        }
        private void btback_Click(object sender, EventArgs e)
        {
            panelhome.Visible = true;
        }
        private void Start()
        {
            groupSP.Hide();
            groupHD.Hide();
            groupKH.Hide();
            groupAddHD.Hide();
            panelhome.Hide();

        }
        #region KHACHHANG
        private void setCBBKH()
        {
            int count = 0;
            string[] st = { "Mã Khách Hàng", "Tên Khách Hàng", "Địa Chỉ", "Số Điện Thoại" ,"Ngày Sinh","Giới Tính"};
            foreach (string i in st)
            {
                comboKH.Items.Add(new CBBCS
                {   Text = i,
                    Value = count
                });
                count++;
            }
            comboKH.SelectedIndex = 0;
        }
        private void butKH_Click(object sender, EventArgs e)
        {
            dataKH.DataSource = KHACHHANG_BLL.Instance.getKH("");
            dataKH.Columns["HOA_DON"].Visible = false;
            dataKH.Columns["CHI_TIET_DON_HANG"].Visible = false;
            Start();
            groupKH.Show();
        }

        private void butAdd_KH_Click(object sender, EventArgs e)
        {
            Form_Add_KH f = new Form_Add_KH();
            string mkh = "";
            f.Sender(mkh);
            f.ShowDialog();
        }

        private void butEdit_KH_Click(object sender, EventArgs e)
        {
            if (dataKH.SelectedRows.Count ==1)
            {
                Form_Add_KH f = new Form_Add_KH();
                string mkh = dataKH.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
                f.Sender(mkh);
                f.ShowDialog();
            }
        }

        private void butDel_KH_Click(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (dataKH.SelectedRows.Count ==1)
            {
                foreach (DataGridViewRow i in dataKH.SelectedRows)
                {
                    string mkh = dataKH.CurrentRow.Cells["MaKhachHang"].Value.ToString();
                    KHACHHANG_BLL.Instance.DelKH(mkh);
                }
            }
            dataKH.DataSource = CHITIETDONHANG_BLL.Instance.getHD("");
            dataKH.DataSource = HOADON_BLL.Instance.getHD_view("");
            dataKH.DataSource = KHACHHANG_BLL.Instance.getKH("");
            dataKH.Columns["HOA_DON"].Visible = false;
            dataKH.Columns["CHI_TIET_DON_HANG"].Visible = false;
            comboMKH_DH.DataSource = db.KHACH_HANG.ToList();
            comboMKH_DH.DisplayMember = "TenKhachHang";
            comboMKH_DH.ValueMember = "MaKhachHang";
            if (comboMKH_DH.SelectedItem == null) comboMKH_DH.Text = null;
            comboMDH_DH.DataSource = db.HOA_DON.Where(p => p.KHACH_HANG.TenKhachHang == comboMKH_DH.Text).ToList();
            comboMDH_DH.DisplayMember = "MaDonHang";
            if (comboMKH_DH.SelectedItem == null) comboMDH_DH.Text = null;
            comboMSP_DH.DataSource = db.SAN_PHAM.ToList();
            comboMSP_DH.DisplayMember = "MaSanPham";
        }

        private void butSort_KH_Click(object sender, EventArgs e)
        {
            List<KHACH_HANG> db = new List<KHACH_HANG>();
            db = KHACHHANG_BLL.Instance.getKH("");
            switch (comboKH.SelectedIndex)
            {
                case 0:
                    {
                        KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.compare_MKH);
                        break;
                    }
                case 1:
                    {
                        KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.compare_TKH);
                        break;
                    }
                case 2:
                    {
                        KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.compare_DC);
                        break;
                    }

                case 3:
                    {
                        KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.compare_SDT);
                        break;
                    }
                case 4:
                    {
                        KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.comare_DT);
                        break;
                    }
                case 5:
                    {
                        KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.compare_GT);
                        break;
                    }
                default:
                    KHACHHANG_BLL.Instance.sort_BLL(db, KHACHHANG_BLL.compare_MKH);
                    break;
            }
            dataKH.DataSource = db;
            dataKH.Columns["HOA_DON"].Visible = false;
            dataKH.Columns["CHI_TIET_DON_HANG"].Visible = false;
        }

        private void butSearchKH_Click(object sender, EventArgs e)
        {
            string mkh = textSearchKH.Text;
            dataKH.DataSource = KHACHHANG_BLL.Instance.getKH(mkh);
            dataKH.Columns["HOA_DON"].Visible = false;
            dataKH.Columns["CHI_TIET_DON_HANG"].Visible = false;
        }
        #endregion
        #region SANPHAM
        private void setCBBSP()
        {
            int count = 0;
            string[] st = { "Mã Sản Phẩm", "Tên Sản Phẩm", "Loại Sản Phẩm", "Giá Bán", "Giá Nhập", "Mã Hàng Sản Xuất", "Số Lượng Tồn Kho" };
            foreach (string i in st)
            {
                comboxSP.Items.Add(new CBBCS
                {
                    Text = i,
                    Value = count,
                });
                count++;
            }
            comboxSP.SelectedIndex = 0;
        }
        private void butSP_Click(object sender, EventArgs e)
        {
            DataSP.DataSource = SANPHAM_BLL.Instance.Get_SP_view("");
            DataSP.Columns["CHI_TIET_DON_HANG"].Visible = false;
            DataSP.Columns["CHI_TIET_SAN_PHAM"].Visible = false;
            Start();
            groupSP.Show();
        }

        private void butAddSP_Click(object sender, EventArgs e)
        {
            Form_Add_SP f = new Form_Add_SP();
            f.Sender("");
            f.ShowDialog();
        }


        private void butSearch_Click(object sender, EventArgs e)
        {
            string msp = textSearch.Text;
            DataSP.DataSource = SANPHAM_BLL.Instance.Get_SP_view(msp);
            DataSP.Columns["CHI_TIET_DON_HANG"].Visible = false;
            DataSP.Columns["CHI_TIET_SAN_PHAM"].Visible = false;
        }

        private void butEdit_SP_Click(object sender, EventArgs e)
        {
            if (DataSP.SelectedRows.Count ==1)
            {
                Form_Add_SP f = new Form_Add_SP();
                string msp = DataSP.SelectedRows[0].Cells["MaSanPham"].Value.ToString();
                f.Sender(msp);
                f.ShowDialog();
            }
        }

        private void butDel_SP_Click(object sender, EventArgs e)
        {
            if (DataSP.SelectedRows.Count ==1)
            {
                foreach (DataGridViewRow i in DataSP.SelectedRows)
                {
                    string msp = DataSP.CurrentRow.Cells["MaSanPham"].Value.ToString();
                    SANPHAM_BLL.Instance.Del_SP(msp);
                }
            }
            DataSP.DataSource = CHITIETSANPHAM_BLL.Instance.getCTSP("");
            DataSP.DataSource = SANPHAM_BLL.Instance.Get_SP_view("");
            DataSP.Columns["CHI_TIET_DON_HANG"].Visible = false;
            DataSP.Columns["CHI_TIET_SAN_PHAM"].Visible = false;
        }

        private void butSortSP_Click(object sender, EventArgs e)
        {
            List<SAN_PHAM> db = new List<SAN_PHAM>();
            db = SANPHAM_BLL.Instance.Get_SP_view("");
            switch (comboxSP.SelectedIndex)
            {
                case 0:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_MSP);
                        break;
                    }
                case 1:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_TSP);
                        break;
                    }
                case 2:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_LSP);
                        break;
                    }

                case 3:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_GB);
                        break;
                    }
                case 4:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_GN);
                        break;
                    }
                case 5:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_MH);
                        break;
                    }
                case 6:
                    {
                        SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_SL);
                        break;
                    }
                default:
                    SANPHAM_BLL.Instance.sort_BLL(db, SANPHAM_BLL.compare_MSP);
                    break;
            }
            DataSP.DataSource = db;
            DataSP.Columns["CHI_TIET_DON_HANG"].Visible = false;
            DataSP.Columns["CHI_TIET_SAN_PHAM"].Visible = false;
        }
        private void DataSP_SelectionChanged(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (DataSP.SelectedRows.Count ==1)
            {
                SAN_PHAM a = db.SAN_PHAM.Find(DataSP.CurrentRow.Cells["MaSanPham"].Value.ToString());
                textXX.Text = a.CHI_TIET_SAN_PHAM.XuatXu;
                textM.Text = a.CHI_TIET_SAN_PHAM.Mau;
                textSize.Text = Convert.ToString(a.CHI_TIET_SAN_PHAM.Size);
                textMT.Text = a.CHI_TIET_SAN_PHAM.MoTaSanPham;
            }
        }
        #endregion
        #region HOADON
        private void butDel_HD_Click(object sender, EventArgs e)
        {
            if (dataHD.SelectedRows.Count ==1)
            {
                PBL3_DATABASE db = new PBL3_DATABASE();
                foreach (DataGridViewRow i in dataHD.SelectedRows)
                {
                    string mhd = dataHD.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    HOADON_BLL.Instance.Del_HD(mhd);
                }
            }
            for(int i = 0; i< DataCT.RowCount; i++)
            {
                PBL3_DATABASE db = new PBL3_DATABASE();
                string tsp = DataCT.Rows[i].Cells["TenSanPham"].Value.ToString();
                SAN_PHAM s = db.SAN_PHAM.Where(p => p.TenSanPham == tsp).FirstOrDefault();
                SAN_PHAM sp = new SAN_PHAM();
                sp.MaSanPham = s.MaSanPham;
                sp.TenSanPham = s.TenSanPham;
                sp.MaHangSanXuat = s.MaHangSanXuat;
                sp.LoaiSanPham = s.LoaiSanPham;
                sp.GiaBan = s.GiaBan;
                sp.GiaNhap = s.GiaNhap;
                sp.SoLuongTonKho = s.SoLuongTonKho + Convert.ToInt32(DataCT.Rows[i].Cells["SoLuong"].Value.ToString());
                SANPHAM_BLL.Instance.Edit_SP(sp);
            }
            DataCT.DataSource = null;
            dataHD.DataSource = HOADON_BLL.Instance.getHD_view("");
            dataHD.Columns["KHACH_HANG"].Visible = false;
            dataHD.Columns["CHI_TIET_DON_HANG"].Visible = false;
        }

        private void butHD_Click(object sender, EventArgs e)
        {
            dataHD.DataSource = HOADON_BLL.Instance.getHD_view("");
            dataHD.Columns["KHACH_HANG"].Visible = false;
            dataHD.Columns["CHI_TIET_DON_HANG"].Visible = false;
            Start();
            groupHD.Show();
        }

        private void butShowHD_Click(object sender, EventArgs e)
        {
            if (dataHD.SelectedRows.Count ==1)
            {
                PBL3_DATABASE db = new PBL3_DATABASE();
                foreach (DataGridViewRow i in dataHD.SelectedRows)
                {
                    string mhd = dataHD.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    var result = from c in db.CHI_TIET_DON_HANG
                                 where c.MaDonHang == mhd
                                 select new {TenSanPham = c.SAN_PHAM.TenSanPham, SoLuong = c.SoLuong, TongTien = c.SoLuong * c.SAN_PHAM.GiaBan };
                    DataCT.DataSource = result.ToList();
                }
            }
        }

        private void butSearch_HD_Click(object sender, EventArgs e)
        {
            string mdh = textMKH_HD.Text;
            dataHD.DataSource = HOADON_BLL.Instance.getHD_view(mdh);
            dataHD.Columns["KHACH_HANG"].Visible = false;
            dataHD.Columns["CHI_TIET_DON_HANG"].Visible = false;
        }

        private void dataHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dataHD.SelectedRows.Count ==1)
            {
                PBL3_DATABASE db = new PBL3_DATABASE();
                foreach (DataGridViewRow i in dataHD.SelectedRows)
                {
                    string mhd = dataHD.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    var result = from c in db.CHI_TIET_DON_HANG
                                 where c.MaDonHang == mhd
                                 select new { TenSanPham = c.SAN_PHAM.TenSanPham, SoLuong = c.SoLuong, TongTien = c.SoLuong * c.SAN_PHAM.GiaBan };
                    DataCT.DataSource = result.ToList();
                }
                foreach (DataGridViewRow i in dataHD.SelectedRows)
                {
                    int sum = 0;
                    string mhd = dataHD.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    foreach (CHI_TIET_DON_HANG p in db.CHI_TIET_DON_HANG)
                    {
                        if (p.MaDonHang == mhd)
                        {
                            sum += Convert.ToInt32(p.TongTien);
                        }
                        textSell.Text = sum.ToString();
                    }
                }
            }
        }
        #endregion
        #region DONHANG
        private void butDH_Click(object sender, EventArgs e)
        {
            Start();
            groupAddHD.Show();
            PBL3_DATABASE db = new PBL3_DATABASE();
            comboMKH_DH.DataSource = db.KHACH_HANG.ToList();
            comboMKH_DH.DisplayMember = "TenKhachHang";
            comboMKH_DH.ValueMember = "MaKhachHang";
            comboMDH_DH.DataSource = db.HOA_DON.Where(p => p.KHACH_HANG.TenKhachHang == comboMKH_DH.Text).ToList();
            comboMDH_DH.DisplayMember = "MaDonHang";
            comboMSP_DH.DataSource = db.SAN_PHAM.ToList();
            comboMSP_DH.DisplayMember = "MaSanPham";
            var result = from c in db.CHI_TIET_DON_HANG
                         where c.MaDonHang == comboMDH_DH.Text
                         select new { MaSanPham = c.MaSanPham,TenSanPham = c.SAN_PHAM.TenSanPham, SoLuong = c.SoLuong, TongTien = c.SoLuong * c.SAN_PHAM.GiaBan };
            dataDH.DataSource = result.ToList();
        }
        private CHI_TIET_DON_HANG getCT(string msp)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            SAN_PHAM s = SANPHAM_BLL.Instance.getSPbyMSP(msp);
            CHI_TIET_DON_HANG dh = db.CHI_TIET_DON_HANG.Where(p => p.MaSanPham == msp && p.MaKhachHang == comboMKH_DH.SelectedValue.ToString()).FirstOrDefault();
            CHI_TIET_DON_HANG a = new CHI_TIET_DON_HANG();
            a.MaDonHang = dh.MaDonHang;
            a.MaSanPham = dh.MaSanPham;
            a.MaKhachHang = dh.MaKhachHang;
            a.SoLuong = dh.SoLuong + Convert.ToInt32(textSL.Value);
            a.TongTien = s.GiaBan * a.SoLuong;
            a.ID = dh.ID;
            return a;
        }
        private CHI_TIET_DON_HANG getDH(string msp)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            CHI_TIET_DON_HANG a = new CHI_TIET_DON_HANG();
            SAN_PHAM s = SANPHAM_BLL.Instance.getSPbyMSP(msp);
            a.MaDonHang = comboMDH_DH.Text;
            a.MaSanPham = s.MaSanPham;
            a.MaKhachHang = comboMKH_DH.SelectedValue.ToString();
            a.SoLuong = Convert.ToInt32(textSL.Value);
            a.TongTien = s.GiaBan * a.SoLuong;
            return a;
        }
        private SAN_PHAM getSP(string msp)
        {
            SAN_PHAM sp = new SAN_PHAM();
            SAN_PHAM s = SANPHAM_BLL.Instance.getSPbyMSP(msp);
            sp.MaSanPham = s.MaSanPham;
            sp.TenSanPham = s.TenSanPham;
            sp.MaHangSanXuat = s.MaHangSanXuat;
            sp.LoaiSanPham = s.LoaiSanPham;
            sp.GiaBan = s.GiaBan;
            sp.GiaNhap = s.GiaNhap;
            sp.SoLuongTonKho = s.SoLuongTonKho - Convert.ToInt32(textSL.Value);
            return sp;
        }
        private void butAddSP_DH_Click(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            HOA_DON s = new HOA_DON();
            string mhd = comboMDH_DH.Text;
            CHI_TIET_DON_HANG dh = db.CHI_TIET_DON_HANG.Where(p => p.MaSanPham == comboMSP_DH.Text && p.MaKhachHang == comboMKH_DH.SelectedValue.ToString()).FirstOrDefault();
            if (dh == null)
            {
                CHITIETDONHANG_BLL.Instance.AddDH(getDH(comboMSP_DH.Text));
            }
            else
            {
                CHITIETDONHANG_BLL.Instance.EditCT(getCT(comboMSP_DH.Text));
            }
            SAN_PHAM sp = getSP(comboMSP_DH.Text);
            SANPHAM_BLL.Instance.Edit_SP(sp);
            var result = from c in db.CHI_TIET_DON_HANG
                         where c.MaDonHang == comboMDH_DH.Text
                         select new { MaSanPham = c.MaSanPham,TenSanPham = c.SAN_PHAM.TenSanPham, SoLuong = c.SoLuong, TongTien = c.SoLuong * c.SAN_PHAM.GiaBan };
            dataDH.DataSource = result.ToList();
        }

        private void butDel_DH_Click(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (dataDH.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow i in dataDH.SelectedRows)
                {
                    string msp = dataDH.CurrentRow.Cells["MaSanPham"].Value.ToString();
                    int sl = Convert.ToInt32(dataDH.CurrentRow.Cells["SoLuong"].Value.ToString());
                    SAN_PHAM sp = getSP(msp);
                    sp.SoLuongTonKho = sp.SoLuongTonKho +Convert.ToInt32(textSL.Value)+sl;
                    SANPHAM_BLL.Instance.Edit_SP(sp);
                    CHITIETDONHANG_BLL.Instance.DelDH(msp);
                }
            }
            var result = from c in db.CHI_TIET_DON_HANG
                         where c.MaDonHang == comboMDH_DH.Text
                         select new { MaSanPham = c.MaSanPham,TenSanPham = c.SAN_PHAM.TenSanPham, SoLuong = c.SoLuong, TongTien = c.SoLuong * c.SAN_PHAM.GiaBan };
            dataDH.DataSource = result.ToList();
        }

        private void comboMSP_DH_SelectedValueChanged(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (db.SAN_PHAM.Find(comboMSP_DH.Text)!=null)
            {
                SAN_PHAM a = db.SAN_PHAM.Find(comboMSP_DH.Text);
                textM_DH.Text = a.CHI_TIET_SAN_PHAM.Mau.ToString();
                textGB_DH.Text = a.GiaBan.ToString();
                textS_DH.Text = a.CHI_TIET_SAN_PHAM.Size.ToString();
                textTSP_DH.Text = a.TenSanPham.ToString();
            }
        }

        private void comboMKH_DH_SelectedValueChanged(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (comboMKH_DH.SelectedItem == null) return;
            string tkh = ((PBL3.DTO.KHACH_HANG)comboMKH_DH.SelectedItem).TenKhachHang;
            string mkh = null;
            foreach (HOA_DON p in db.HOA_DON)
            {
                if (p.KHACH_HANG.TenKhachHang == tkh)
                    mkh = p.MaKhachHang;
            }
            HOA_DON a = db.HOA_DON.Where(p => p.MaKhachHang == mkh).SingleOrDefault();
            if (a == null)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(HOADON_BLL.Instance.RandomString(4, true));
                builder.Append(HOADON_BLL.Instance.RandomNumber(1000, 9999));
                builder.Append(HOADON_BLL.Instance.RandomString(2, false));
                HOA_DON b = new HOA_DON();
                if (db.HOA_DON.Find(builder.ToString()) == null)
                {
                    b.MaDonHang = builder.ToString();
                    KHACH_HANG c = db.KHACH_HANG.Where(p => p.TenKhachHang == tkh).SingleOrDefault();
                    b.MaKhachHang = c.MaKhachHang;
                    HOADON_BLL.Instance.AddHD(b);
                }
                comboMDH_DH.DataSource = HOADON_BLL.Instance.getHD_view("");
            }
            comboMDH_DH.DataSource = db.HOA_DON.Where(p => p.KHACH_HANG.TenKhachHang == comboMKH_DH.Text).ToList();
            comboMDH_DH.DisplayMember = "MaDonHang";
        }

        private void comboMDH_DH_SelectedValueChanged(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            var result = from c in db.CHI_TIET_DON_HANG
                         where c.MaDonHang == comboMDH_DH.Text
                         select new { MaSanPham = c.MaSanPham, TenSanPham = c.SAN_PHAM.TenSanPham, SoLuong = c.SoLuong, TongTien = c.SoLuong * c.SAN_PHAM.GiaBan };
            dataDH.DataSource = result.ToList();
        }

        private void textSL_ValueChanged(object sender, EventArgs e)
        {
            string msp = comboMSP_DH.Text;
            PBL3_DATABASE db = new PBL3_DATABASE();
            SAN_PHAM a = db.SAN_PHAM.Find(msp);
            if (a != null)
            {
                if (Convert.ToInt32(textSL.Value) > a.SoLuongTonKho)
                {
                    textSL.Value = Convert.ToDecimal(a.SoLuongTonKho);
                }
            }
        }

        #endregion
        #region button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN f = new LOGIN();
            f.ShowDialog();
            this.Close();
        }
        private void butNV_Click(object sender, EventArgs e)
        {
            Form_NV f = new Form_NV();
            f.Show();
        }
        #endregion
        #region eventfix
        private void butAdd_KH_MouseUp(object sender, MouseEventArgs e)
        {
            butKH_Click(sender, e);
        }

        private void butEdit_KH_MouseUp(object sender, MouseEventArgs e)
        {
            butKH_Click(sender, e);
        }

        private void butAddSP_MouseUp(object sender, MouseEventArgs e)
        {
            butSP_Click(sender, e);
        }

        private void butEdit_SP_MouseUp(object sender, MouseEventArgs e)
        {
            butSP_Click(sender, e);
        }
        #endregion
        private void Main_Load(object sender, EventArgs e)
        {
            if (role.Trim() == "user")
            {
                butDT.Visible = false;
                butNV.Visible = false;
                txtNhanVien.Text = TenNhanVien;
            }
            else
            {
                txtNhanVien.Text = "Admin";
            }
        }
        private CHI_TIET_THONG_KE getCTTK(CHI_TIET_DON_HANG dh,int sl)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            CHI_TIET_THONG_KE ct = new CHI_TIET_THONG_KE();
            SAN_PHAM sp = db.SAN_PHAM.Find(dh.MaSanPham);
            ct.MaDonHang = dh.MaDonHang;
            ct.MaSanPham = dh.MaSanPham;
            ct.GiaBan = sp.GiaBan;
            ct.SoLuong = sl;
            ct.GiaNhap = sp.GiaNhap;
            return ct;
            
        }

        private void butTT_HD_Click(object sender, EventArgs e)
        {
            if(dataHD.SelectedRows.Count == 1)
            {
                PBL3_DATABASE db = new PBL3_DATABASE();
                THONG_KE hd = new THONG_KE();
                int index = dataHD.CurrentCell.RowIndex;
                hd.MaDonHang = dataHD.Rows[index].Cells["MaDonHang"].Value.ToString();
                hd.TenKhachHang = dataHD.Rows[index].Cells["MaKhachHang"].Value.ToString();
                hd.TenNhanVien = txtNhanVien.Text;
                hd.NgayLapDon = DateTime.Now;
                hd.TongTien = Convert.ToInt32(textSell.Text);
                THONGKE_BLL.Instance.addTK(hd);
                DataSP.DataSource = THONGKE_BLL.Instance.getTK("");
                string mhd = hd.MaDonHang;
                List<CHI_TIET_DON_HANG> dh = db.CHI_TIET_DON_HANG.ToList();
                for(int i = 0;i < dh.Count;i++)
                {
                    if(mhd==dh[i].MaDonHang)
                    {
                        THONGKECHITIET_BAL.Instance.addCT(getCTTK(dh[i],Convert.ToInt32(dh[i].SoLuong)));
                        DataSP.DataSource = THONGKECHITIET_BAL.Instance.getCT("");
                    }
                }
                string done = dataHD.CurrentRow.Cells["MaDonHang"].Value.ToString();
                HOADON_BLL.Instance.Del_HD(done);
                DataCT.DataSource = null;
                dataHD.DataSource = HOADON_BLL.Instance.getHD_view("");
                dataHD.Columns["KHACH_HANG"].Visible = false;
                dataHD.Columns["CHI_TIET_DON_HANG"].Visible = false;
                MessageBox.Show("Thanh Toán Thành Công !!!");
            }

        }

        private void butDT_Click(object sender, EventArgs e)
        {
            Form_DOANH_THU f = new Form_DOANH_THU();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGender.Text == "" || txtCost.Text == ""  || txtSize.Text == "")
            {
                MessageBox.Show("Đang thiếu giá trị!!!");
            }
            else {
                string gioiTinh = txtGender.Text;
                int gia = int.Parse(txtCost.Text) / 1000;
                int size = int.Parse(txtSize.Text);
                DataSP.DataSource = GOIYSANPHAM_BLL.Instance.GetGYSP_BLL(gioiTinh, gia, size);
                DataSP.Columns["SAN_PHAM"].Visible = false;
            }
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
