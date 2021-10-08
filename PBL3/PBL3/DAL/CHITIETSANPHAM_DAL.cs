using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class CHITIETSANPHAM_DAL
    {
        private static CHITIETSANPHAM_DAL _Instance;
        public static CHITIETSANPHAM_DAL Instance
        {
            get
            {
                 if (_Instance == null)
                {
                    _Instance = new CHITIETSANPHAM_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private CHITIETSANPHAM_DAL()
        {

        }
        public CHI_TIET_SAN_PHAM getCTSP(string msp)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            CHI_TIET_SAN_PHAM sp = db.CHI_TIET_SAN_PHAM.Where(p => p.MaSanPham.StartsWith(msp)).FirstOrDefault();
            return sp;
        }
        public void addSP(CHI_TIET_SAN_PHAM a)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.CHI_TIET_SAN_PHAM.Add(a);
                db.SaveChanges();
            }
        }
        public bool EditSP(CHI_TIET_SAN_PHAM a)
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
