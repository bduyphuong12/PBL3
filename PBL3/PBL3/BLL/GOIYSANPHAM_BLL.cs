using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.BLL
{
    class GOIYSANPHAM_BLL
    {
        private static GOIYSANPHAM_BLL _Instance;
        public static GOIYSANPHAM_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new GOIYSANPHAM_BLL();
                }
                return _Instance;
            }
        }
        private GOIYSANPHAM_BLL() { }

        public List<CHI_TIET_SAN_PHAM> GetGYSP_BLL(string gioiTinh, int gia, int size)
        {
            List<CHI_TIET_SAN_PHAM> l = GOIYSANPHAM_DAL.Instance.GetGYSP_DAL(gioiTinh);

            int n = l.Count();


            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Sqrt((double)((l[i].GiaBan/1000 - gia) * (l[i].GiaBan/1000 - gia) + (l[i].Size - size) * (l[i].Size - size)));
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        CHI_TIET_SAN_PHAM temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                        double temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;
                    }
                }
            }
            return l;
        }
    }
}
