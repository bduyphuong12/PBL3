using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class GOIYSANPHAM_DAL
    {
        private static GOIYSANPHAM_DAL _Instance;
        public static GOIYSANPHAM_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new GOIYSANPHAM_DAL();
                }
                return _Instance;
            }
        }
        private GOIYSANPHAM_DAL() { }

        public List<CHI_TIET_SAN_PHAM> GetGYSP_DAL(string gioiTinh)
        {
            List<CHI_TIET_SAN_PHAM> dt = new List<CHI_TIET_SAN_PHAM>();

            PBL3_DATABASE db = new PBL3_DATABASE();

            dt = db.CHI_TIET_SAN_PHAM.Where(p => p.GioiTinh == gioiTinh).ToList();

            return dt;
        }
    }
}
