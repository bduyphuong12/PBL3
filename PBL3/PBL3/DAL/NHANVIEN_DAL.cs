using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAL
{
    class NHANVIEN_DAL
    {
        private static NHANVIEN_DAL _Instance;
        public static NHANVIEN_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NHANVIEN_DAL();
                }
                return _Instance;
            }
            set { }
        }
        private NHANVIEN_DAL() { }
        public void Xoa_DAL(string mskh)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();
            NHAN_VIEN KHdel = db.NHAN_VIEN.Find(mskh);
            db.NHAN_VIEN.Remove(KHdel);
            db.SaveChanges();
        }
        public void AddNV(NHAN_VIEN k)
        {
            using (PBL3_DATABASE db = new PBL3_DATABASE())
            {
                db.NHAN_VIEN.Add(k);
                db.SaveChanges();
            }

        }
        public bool setEditNV(NHAN_VIEN k)
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
        public List<NHAN_VIEN> getNVview(string name)
        {
            PBL3_DATABASE db = new PBL3_DATABASE();

            if (name == "")
            {
                return db.NHAN_VIEN.ToList();
            }
            else
            {
                return db.NHAN_VIEN.Where(p => p.TenNhanVien.StartsWith(name)).ToList();
            }

        }

    }
}
