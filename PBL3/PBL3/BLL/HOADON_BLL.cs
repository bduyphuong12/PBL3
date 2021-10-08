using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    class HOADON_BLL
    {
        private static HOADON_BLL _Instance;
        public static HOADON_BLL Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new HOADON_BLL();
                }
                return _Instance;
            }
            set { }
        }
        private HOADON_BLL() { }
        public List<HOA_DON> getHD_view(string mdh)
        {
            return HOADON_DAL.Instance.getHD(mdh);
        }
        public void Del_HD(string mhd)
        {
            HOADON_DAL.Instance.Del_HD(mhd);
        }
        public void AddHD(HOA_DON a)
        {
            HOADON_DAL.Instance.AddHD(a);
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
}
