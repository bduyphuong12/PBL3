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
using PBL3.GUI;

namespace PBL3.GUI
{
    public partial class Form_NV : Form
    {
        public Form_NV()
        {
            InitializeComponent();
            setCBBsort();
            datagridNV.DataSource = NHANVIEN_BLL.Instance.GetNV_View("");
        }
        public void setCBBsort()
        {
            string[] st = { "Ma nhan vien", "Ten nhan vien", "Dia Chi", "So Dien Thoai", "Chuc vu" };
            foreach (string i in st)
            {
                cbbsort.Items.Add(i);
            }
        }
        public void loadform()
        {
            string name = txtsearch.Text;
            datagridNV.DataSource = NHANVIEN_BLL.Instance.GetNV_View(name);
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            loadform();
        }
        private void btshow_Click_1(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            var l1 = from p in db.NHAN_VIEN select new { p.MaNhanVien, p.TenNhanVien, p.NgaySinh, p.GioiTinh, p.DiaChi, p.SoDienThoai, p.SoCMND, p.ChucVu, p.Email, p.NgayVaoLam };
            loadform();
        }

        private void btadd_Click_1(object sender, EventArgs e)
        {
            Form_NV_Add f = new Form_NV_Add();
            string idNV = "";

            f.Sender(idNV);
            f.Show();
            this.Hide();
        }

        private void btsearch_Click_1(object sender, EventArgs e)
        {
            loadform();
        }

        private void btsort_Click_1(object sender, EventArgs e)
        {
            List<NHAN_VIEN> st = new List<NHAN_VIEN>();
            st = NHANVIEN_BLL.Instance.GetNV_View("");

            if (cbbsort.SelectedItem.ToString() == "Ma nhan vien")
            {
                NHANVIEN_BLL.Instance.sort_BLL(st, NHANVIEN_BLL.compare_MSNV);
            }
            else if (cbbsort.SelectedItem.ToString() == "Ten nhan vien")
            {
                NHANVIEN_BLL.Instance.sort_BLL(st, NHANVIEN_BLL.compare_Name);
            }
            else if (cbbsort.SelectedItem.ToString() == "Dia Chi")
            {
                NHANVIEN_BLL.Instance.sort_BLL(st, NHANVIEN_BLL.compare_DiaChi);
            }
            else if (cbbsort.SelectedItem.ToString() == "So dien thoai")
            {
                NHANVIEN_BLL.Instance.sort_BLL(st, NHANVIEN_BLL.compare_SDT);
            }
            else if (cbbsort.SelectedItem.ToString() == "Chuc vu")
            {
                NHANVIEN_BLL.Instance.sort_BLL(st, NHANVIEN_BLL.compare_ChucVu);
            }
            datagridNV.DataSource = st;
        }

        private void btedit_Click_1(object sender, EventArgs e)
        {
            if(datagridNV.SelectedRows.Count == 1)
            {
                Form_NV_Add f = new Form_NV_Add();
                string idNV = datagridNV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                f.Sender(idNV);
                f.Show();
                this.Hide();
            }
        }
        private void btxoa_Click_1(object sender, EventArgs e)
        {
            if (datagridNV.SelectedRows.Count == 1)
            {
                PBL3_DATABASE db = new PBL3_DATABASE();
                foreach (DataGridViewRow i in datagridNV.SelectedRows)
                {
                    string idNV = datagridNV.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                    if (idNV == "admin")
                    {
                        MessageBox.Show("Không thể xóa admin!");
                        break;
                    } 
                    NHANVIEN_BLL.Instance.delNV_BLL(idNV);
                }
            }
            datagridNV.DataSource = NHANVIEN_BLL.Instance.GetNV_View("");
        }
    }
}
