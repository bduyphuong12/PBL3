using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    class SANPHAM_BLL
    {
        private static SANPHAM_BLL _Instance;
        public static SANPHAM_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SANPHAM_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private SANPHAM_BLL()
        { }
        public SAN_PHAM getSPbyMSP(string msp)
        {
            SAN_PHAM kb = new SAN_PHAM();
            kb = null;
            foreach(SAN_PHAM i in SANPHAM_DAL.Instance.getSPview(""))
            {
                if (i.MaSanPham == msp)
                {
                    kb = i;
                }
            }
            return kb;
        }
        public void Add_SP(SAN_PHAM kb)
        {
            SANPHAM_DAL.Instance.Add_SP(kb);
        }
        public bool Edit_SP(SAN_PHAM kb)
        {
            return SANPHAM_DAL.Instance.setEditSP(kb);
        }
        public List<SAN_PHAM> Get_SP_view(string msp)
        {
            return SANPHAM_DAL.Instance.getSPview(msp);
        }
        public void Del_SP(string kb)
        {
            SANPHAM_DAL.Instance.Del_SP(kb);
        }
        public delegate bool Compare(object a, object b);
        public void sort_BLL(List<SAN_PHAM> sp,Compare cmp)
        {
            SAN_PHAM temp = new SAN_PHAM();
            int pos;
            for (int i = 0; i < sp.Count; i++)
            {
                temp = sp[i];
                pos = i;
                while (pos > 0 && cmp(temp, sp[pos - 1]))
                {
                    sp[pos] = sp[pos - 1];
                    pos--;
                }
                sp[pos] = temp;
            }
        }
        public static bool compare_MSP(object s1, object s2)
        {
            return (string.Compare(((SAN_PHAM)s1).MaSanPham, ((SAN_PHAM)s2).MaSanPham) < 0)? true : false;
        }
        public static bool compare_TSP(object s1, object s2)
        {
            return (string.Compare(((SAN_PHAM)s1).TenSanPham, ((SAN_PHAM)s2).TenSanPham) < 0) ? true : false;
        }
        public static bool compare_LSP(object s1,object s2)
        {
            return (string.Compare(((SAN_PHAM)s1).LoaiSanPham, ((SAN_PHAM)s2).TenSanPham) < 0) ? true : false;
        }
        public static bool compare_GB(object s1, object s2)
        {
            return ((SAN_PHAM)s1).GiaBan  < ((SAN_PHAM )s2).GiaBan  ? true : false;
        }
        public static bool compare_GN(object s1, object s2)
        {
            return ((SAN_PHAM)s1).GiaNhap  < ((SAN_PHAM)s2).GiaNhap  ? true : false;
        }
        public static bool compare_MH(object s1, object s2)
        {
            return (string.Compare(((SAN_PHAM)s1).MaHangSanXuat, ((SAN_PHAM)s2).MaHangSanXuat) < 0) ? true : false;
        }
        public static bool compare_SL(object s1, object s2)
        {
            return ((SAN_PHAM)s2).SoLuongTonKho < ((SAN_PHAM)s2).SoLuongTonKho ? true : false;
        }

    }
}
