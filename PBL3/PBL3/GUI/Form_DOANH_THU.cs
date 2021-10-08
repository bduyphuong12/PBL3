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
    public partial class Form_DOANH_THU : Form
    {
        public Form_DOANH_THU()
        {
            InitializeComponent();
            dataTK.DataSource = THONGKE_BLL.Instance.getTK("");
            dataTK.Columns["CHI_TIET_THONG_KE"].Visible = false;
        }
        private void butEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCT_Click(object sender, EventArgs e)
        {
            if(dataTK.SelectedRows.Count == 1 )
            {
                int index = dataTK.CurrentCell.RowIndex;
                string mhd = dataTK.Rows[index].Cells["MaDonHang"].Value.ToString();
                PBL3_DATABASE db = new PBL3_DATABASE();
                var result = from c in db.CHI_TIET_THONG_KE where c.MaDonHang == mhd select c;
                dataCT.DataSource = result.ToList();
                dataCT.Columns["ID"].Visible = false;
                dataCT.Columns["THONG_KE"].Visible = false;
                dataCT.Columns["MaDonHang"].Visible = false;
            }
        }

        private void dataTK_DataSourceChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataTK.RowCount; i++)
            {
                int it = Convert.ToInt32(dataTK.Rows[i].Cells["TongTien"].Value.ToString());
                sum += it;
            }
            textTT.Text = sum.ToString();
        }

        private void timeT_ValueChanged(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            var result = from c in db.THONG_KE where c.NgayLapDon >= timeT.Value && c.NgayLapDon <= timeD.Value orderby c.NgayLapDon select c;
            if(result !=null)
            {
                dataTK.DataSource = result.ToList();
                dataTK.Columns["CHI_TIET_THONG_KE"].Visible = false;
                dataCT.DataSource = null;
            }
        }

        private void timeD_ValueChanged(object sender, EventArgs e)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            var result = from c in db.THONG_KE where c.NgayLapDon >= timeT.Value && c.NgayLapDon <= timeD.Value orderby c.NgayLapDon select c;
            if (result != null)
            {
                dataTK.DataSource = result.ToList();
                dataTK.Columns["CHI_TIET_THONG_KE"].Visible = false;
                dataCT.DataSource = null;
            }
        }
    }
}
