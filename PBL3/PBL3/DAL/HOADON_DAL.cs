using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class HOADON_DAL
    {
        private static HOADON_DAL _Instance; 
        public static HOADON_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HOADON_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private HOADON_DAL() { }
        public List<HOA_DON> getHD(string mdh)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            if (mdh == "")
            {
                return db.HOA_DON.ToList();
            }
            else
            {
                return db.HOA_DON.Where(p => p.MaDonHang.StartsWith(mdh)).ToList();
            }
        }
        public void Del_HD(string mhd)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            HOA_DON delsp = db.HOA_DON.Find(mhd);
            foreach (CHI_TIET_DON_HANG p in db.CHI_TIET_DON_HANG)
            {
                if (mhd == p.MaDonHang)
                    db.CHI_TIET_DON_HANG.Remove(p);
            }
            db.HOA_DON.Remove(delsp);
            db.SaveChanges();
        }
        public void AddHD(HOA_DON a)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            db.HOA_DON.Add(a);
            db.SaveChanges();
        }

    }
}
