using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class KHACHHANG_DAL
    {
        private static KHACHHANG_DAL _Instance;
        public static KHACHHANG_DAL Instance
        {
            get
            {
                if (_Instance == null )
                {
                    _Instance = new KHACHHANG_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private KHACHHANG_DAL() { }
        public List<KHACH_HANG> getKH(string mskh)
        {
            
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (mskh == "")
            {
                return db.KHACH_HANG.ToList();
            }
            else
            {
                    return db.KHACH_HANG.Where(p => p.MaKhachHang.StartsWith(mskh)).ToList();
            }
        }
        public void AddKH(KHACH_HANG a)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.KHACH_HANG.Add(a);
                db.SaveChanges();
            }
        }
        public bool EditKH(KHACH_HANG a)
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
        public void DelKH(string mkh)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            KHACH_HANG kh = db.KHACH_HANG.Find(mkh);
            foreach(HOA_DON p in db.HOA_DON)
            {
                if (mkh == p.MaKhachHang)
                    db.HOA_DON.Remove(p);
            }
            foreach(CHI_TIET_DON_HANG p in db.CHI_TIET_DON_HANG)
            {
                if (mkh == p.MaKhachHang)
                    db.CHI_TIET_DON_HANG.Remove(p);
            }
            db.KHACH_HANG.Remove(kh);
            db.SaveChanges();
        }
    }
}
