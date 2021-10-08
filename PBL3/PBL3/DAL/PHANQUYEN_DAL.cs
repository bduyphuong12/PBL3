using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class PHANQUYEN_DAL
    {
        private static PHANQUYEN_DAL _Instance;
        public static PHANQUYEN_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PHANQUYEN_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private PHANQUYEN_DAL() { }
        public void Xoa_DAL(string mskh)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            PHAN_QUYEN KHdel = db.PHAN_QUYEN.Find(mskh);
            db.PHAN_QUYEN.Remove(KHdel);
            db.SaveChanges();
        }
        public void AddNV(PHAN_QUYEN k)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.PHAN_QUYEN.Add(k);
                db.SaveChanges();
            }

        }
        public bool setEditNV(PHAN_QUYEN k)
        {
            try
            {
                using (PBL3_DATABASE db = new PBL3_DATABASE())
                {
                    db.Entry(k).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public PHAN_QUYEN Get_QUYEN_DAL(string ten, string pass)
        {
            PHAN_QUYEN q = null;
            PBL3_DATABASE db = new PBL3_DATABASE();
            q = db.PHAN_QUYEN.Where(p => p.TenDangNhap == ten && p.MatKhau == pass).FirstOrDefault();
            return q;
        }
    }
}
