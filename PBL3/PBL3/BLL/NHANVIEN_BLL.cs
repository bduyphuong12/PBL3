using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    class NHANVIEN_BLL
    {
        private static NHANVIEN_BLL _Instance;
        public static NHANVIEN_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NHANVIEN_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private NHANVIEN_BLL()
        {

        }
        public NHAN_VIEN getNVbyMaNV(string maNV)
        {
            NHAN_VIEN kh = new NHAN_VIEN();
            kh = null;
            foreach (NHAN_VIEN i in NHANVIEN_DAL.Instance.getNVview(""))
            {
                if (i.MaNhanVien == maNV)
                {
                    kh = i;
                }
            }
            return kh;
        }
        public void ADDNV_BLL(NHAN_VIEN k)
        {
            NHANVIEN_DAL.Instance.AddNV(k);
        }
        public bool EditNV_BLL(NHAN_VIEN k)
        {
            return NHANVIEN_DAL.Instance.setEditNV(k);
        }
        public List<NHAN_VIEN> GetNV_View(string maNV)
        {
            return NHANVIEN_DAL.Instance.getNVview(maNV);
        }
        public void delNV_BLL(string idnv)
        {
            NHANVIEN_DAL.Instance.Xoa_DAL(idnv);
        }
        public delegate bool Compare(object s1, object s2);
        public void sort_BLL(List<NHAN_VIEN> sv, Compare cmp)
        {
            NHAN_VIEN temp = new NHAN_VIEN();
            int d;
            for (int i = 0; i < sv.Count; i++)
            {
                temp = sv[i];
                d = i;
                while (d > 0 && cmp(temp, sv[d - 1]))
                {
                    sv[d] = sv[d - 1];
                    d--;
                }
                sv[d] = temp;
            }
        }
        public static bool compare_MSNV(object s1, object s2)
        {
            if (string.Compare(((NHAN_VIEN)s1).MaNhanVien, ((NHAN_VIEN)s2).MaNhanVien) < 0)
                return true;
            else return false;
        }
        public static bool compare_Name(object s1, object s2)
        {
            if (string.Compare(((NHAN_VIEN)s1).TenNhanVien, ((NHAN_VIEN)s2).TenNhanVien) < 0)
                return true;
            else return false;
        }
        public static bool compare_DiaChi(object s1, object s2)
        {
            if (string.Compare(((NHAN_VIEN)s1).DiaChi, ((NHAN_VIEN)s2).DiaChi) < 0)
                return true;
            else return false;
        }
        public static bool compare_SDT(object s1, object s2)
        {
            if (string.Compare(((NHAN_VIEN)s1).SoDienThoai, ((NHAN_VIEN)s2).SoDienThoai) < 0)
                return true;
            else return false;
        }
        public static bool compare_ChucVu(object s1, object s2)
        {
            if (string.Compare(((NHAN_VIEN)s1).ChucVu, ((NHAN_VIEN)s2).ChucVu) < 0)
                return true;
            else return false;
        }
    }
}
