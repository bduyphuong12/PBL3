using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class SANPHAM_DAL
    {
        private static SANPHAM_DAL _Instance;
        public static SANPHAM_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SANPHAM_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private SANPHAM_DAL()
        { 
        }
        public void Del_SP(string msp)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            SAN_PHAM delsp = db.SAN_PHAM.Find(msp);
            CHI_TIET_SAN_PHAM delctsp = db.CHI_TIET_SAN_PHAM.Find(msp);
            foreach(CHI_TIET_DON_HANG p in db.CHI_TIET_DON_HANG)
            {
                if (msp == p.MaSanPham)
                    db.CHI_TIET_DON_HANG.Remove(p);
            }
            db.CHI_TIET_SAN_PHAM.Remove(delctsp);
            db.SAN_PHAM.Remove(delsp);
            db.SaveChanges();
            
        }
        public void Add_SP(SAN_PHAM a)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.SAN_PHAM.Add(a);
                db.SaveChanges();
            }
        }
        public bool setEditSP(SAN_PHAM a)
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
            catch (Exception e )
            {
                throw e;
            }
        }
        public List<SAN_PHAM> getSPview (string msp)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();

            if (msp == "")
            {
                var results = from c in db.SAN_PHAM select c;
                return results.ToList();
            }
            else
            {
                var results = from c in db.SAN_PHAM where c.MaSanPham == msp select c;
                return results.ToList();
            }
        }
        
    }
}
