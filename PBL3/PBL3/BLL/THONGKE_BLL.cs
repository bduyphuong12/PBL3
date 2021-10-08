using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    class THONGKE_BLL
    {
        private static THONGKE_BLL _Instance;
        public static THONGKE_BLL Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new THONGKE_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private THONGKE_BLL() { }
        public void addTK(THONG_KE a)
        {
            THONGKE_DAL.Instance.AddTK(a);
        }
        public List<THONG_KE> getTK(string mhd)
        {
            return THONGKE_DAL.Instance.getTK(mhd);
        }
    }
}
