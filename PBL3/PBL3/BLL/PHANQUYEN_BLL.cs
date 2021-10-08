using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;
namespace PBL3.BLL
{
    class PHANQUYEN_BLL
    {
        private static PHANQUYEN_BLL _Instance;
        public static PHANQUYEN_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PHANQUYEN_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private PHANQUYEN_BLL()
        {

        }
        public void AddPQ_BLL(PHAN_QUYEN k)
        {
            PHANQUYEN_DAL.Instance.AddNV(k);
        }
        public bool EditPQ_BLL(PHAN_QUYEN k)
        {
            return PHANQUYEN_DAL.Instance.setEditNV(k);
        }
        public void delNV_BLL(string idnv)
        {
            PHANQUYEN_DAL.Instance.Xoa_DAL(idnv);
        }
        public PHAN_QUYEN Get_QUYEN_BLL(string ten, string pass)
        {
            return PHANQUYEN_DAL.Instance.Get_QUYEN_DAL(ten, pass);
        }
    }
}
