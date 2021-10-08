using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    class THONGKECHITIET_BAL
    {
        private static THONGKECHITIET_BAL _Instance;
        public static THONGKECHITIET_BAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new THONGKECHITIET_BAL();
                }
                return _Instance;
            }
            set { }
        }
        private THONGKECHITIET_BAL() { }
        public void addCT(CHI_TIET_THONG_KE a)
        {
            THONGKECHITIET_DAL.Instance.addCT(a);
        }
        public List<CHI_TIET_THONG_KE> getCT(string mhd)
        {
            return THONGKECHITIET_DAL.Instance.getCT(mhd);
        }
    }
}
