using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    class CHITIETDONHANG_BLL
    {
        DataTable THD { get; set; } 
        private static CHITIETDONHANG_BLL _Instance;
        public static CHITIETDONHANG_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CHITIETDONHANG_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private CHITIETDONHANG_BLL() 
        {
        }
        public List<CHI_TIET_DON_HANG> getHD(string mdh)
        {
            return CHITIETDONHANG_DAL.Instance.getHD(mdh);
        }
        public void AddDH(CHI_TIET_DON_HANG a)
        {
            CHITIETDONHANG_DAL.Instance.AddDH(a);
        }
        public void DelDH(string msp)
        {
            CHITIETDONHANG_DAL.Instance.DelDH(msp);
        }
        public bool EditCT(CHI_TIET_DON_HANG a)
        {
            return CHITIETDONHANG_DAL.Instance.EditCT(a);
        }
    }
}
