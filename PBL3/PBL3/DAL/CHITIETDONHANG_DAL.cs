using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class CHITIETDONHANG_DAL
    {
        private static CHITIETDONHANG_DAL _Instance;
        public static CHITIETDONHANG_DAL Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new CHITIETDONHANG_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private CHITIETDONHANG_DAL() { }
        public List<CHI_TIET_DON_HANG> getHD(string mdh)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (mdh == "")
            {
                return db.CHI_TIET_DON_HANG.ToList();
            }
            else
            {
                return db.CHI_TIET_DON_HANG.Where(p => p.MaDonHang.StartsWith(mdh)).ToList();
            }
        }
        public void AddDH(CHI_TIET_DON_HANG a)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            db.CHI_TIET_DON_HANG.Add(a);
            db.SaveChanges();
        }
        public void DelDH(string msp)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            foreach(CHI_TIET_DON_HANG p in db.CHI_TIET_DON_HANG)
            {
                if(p.MaSanPham == msp)
                {
                    db.CHI_TIET_DON_HANG.Remove(p);
                }
            }
            db.SaveChanges();
        }
        public bool EditCT(CHI_TIET_DON_HANG a)
        {
            try
            {
                using (PBL3_DATABASE db = new PBL3_DATABASE())
                {
                    db.Entry(a).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
