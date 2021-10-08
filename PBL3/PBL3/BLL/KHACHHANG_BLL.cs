using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    class KHACHHANG_BLL
    {
        private static KHACHHANG_BLL _Instance;
        public static KHACHHANG_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KHACHHANG_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private KHACHHANG_BLL()
        { }
        public List<KHACH_HANG> getKH(string mskh)
        {
            return KHACHHANG_DAL.Instance.getKH(mskh);
        }
        public void AddKH(KHACH_HANG a)
        {
            KHACHHANG_DAL.Instance.AddKH(a);
        }
        public bool EditKH(KHACH_HANG a)
        {
            return KHACHHANG_DAL.Instance.EditKH(a);
        }
        public void DelKH(string a)
        {
            KHACHHANG_DAL.Instance.DelKH(a);
        }
        public delegate bool Compare(object s1, object s2);
        public void sort_BLL(List<KHACH_HANG> sp, Compare cmp)
        {
            KHACH_HANG temp = new KHACH_HANG();
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
        public static bool compare_MKH(object s1, object s2)
        {
            return (string.Compare(((KHACH_HANG)s1).MaKhachHang, ((KHACH_HANG)s2).MaKhachHang) < 0) ? true : false;
        }
        public static bool compare_TKH(object s1, object s2)
        {
            return (string.Compare(((KHACH_HANG)s1).TenKhachHang, ((KHACH_HANG)s2).TenKhachHang) < 0) ? true : false;
        }
        public static bool comare_DT(object a, object b)
        {
            return DateTime.Compare(((KHACH_HANG)a).NgaySinh.Value, ((KHACH_HANG)b).NgaySinh.Value) < 0 ? true : false;
        }
        public static bool compare_GT(object s1, object s2)
        {
            return (string.Compare(((KHACH_HANG)s1).GioiTinh, ((KHACH_HANG)s2).GioiTinh) < 0) ? true : false;
        }
        public static bool compare_DC(object s1, object s2)
        {
            return (string.Compare(((KHACH_HANG)s1).DiaChi, ((KHACH_HANG)s2).DiaChi) < 0) ? true : false;
        }
        public static bool compare_SDT(object s1, object s2)
        {
            return (string.Compare(((KHACH_HANG)s1).SoDienThoai, ((KHACH_HANG)s2).SoDienThoai) < 0) ? true : false;
        }
        public KHACH_HANG getKHbyMKH(string mkh)
        {
            KHACH_HANG s = new KHACH_HANG();
            s = null;
            foreach(KHACH_HANG i in KHACHHANG_DAL.Instance.getKH(""))
            {
                if(i.MaKhachHang == mkh)
                {
                    s = i;
                }
            }
            return s;
        }
    }
}
