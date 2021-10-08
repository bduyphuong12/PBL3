using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class THONGKE_DAL
    {
        private static THONGKE_DAL _Instance;
        public static THONGKE_DAL Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new THONGKE_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private THONGKE_DAL() { }
        public void AddTK(THONG_KE a)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.THONG_KE.Add(a);
                db.SaveChanges();
            }
        }
        public List<THONG_KE> getTK(string mhd)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();

            if (mhd == "")
            {
                var results = from c in db.THONG_KE orderby c.NgayLapDon select c;
                return results.ToList();
            }
            else
            {
                var results = from c in db.THONG_KE where c.MaDonHang== mhd select c;
                return results.ToList();
            }
        }

    }
}
