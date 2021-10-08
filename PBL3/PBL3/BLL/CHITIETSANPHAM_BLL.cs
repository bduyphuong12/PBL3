using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    class CHITIETSANPHAM_BLL
    {
        private static CHITIETSANPHAM_BLL _Instance;
        public static CHITIETSANPHAM_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CHITIETSANPHAM_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private CHITIETSANPHAM_BLL() { }
        public CHI_TIET_SAN_PHAM getCTSP(string msp)
        {
            return CHITIETSANPHAM_DAL.Instance.getCTSP(msp);
        }
        public void addSP(CHI_TIET_SAN_PHAM a)
        {
            CHITIETSANPHAM_DAL.Instance.addSP(a);
        }
        public bool EditSP(CHI_TIET_SAN_PHAM a)
        {
            return CHITIETSANPHAM_DAL.Instance.EditSP(a);
        }
    }
}
