using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class THONGKECHITIET_DAL
    {
        private static THONGKECHITIET_DAL _Instance;
        public static THONGKECHITIET_DAL Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new THONGKECHITIET_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private THONGKECHITIET_DAL() { }
        public void addCT(CHI_TIET_THONG_KE a)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.CHI_TIET_THONG_KE.Add(a);
                db.SaveChanges();
            }
        }
        public List<CHI_TIET_THONG_KE> getCT(string mhd)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();

            if (mhd == "")
            {
                var results = from c in db.CHI_TIET_THONG_KE select c;
                return results.ToList();
            }
            else
            {
                var results = from c in db.CHI_TIET_THONG_KE where c.MaDonHang == mhd select c;
                return results.ToList();
            }
        }
    }
}
