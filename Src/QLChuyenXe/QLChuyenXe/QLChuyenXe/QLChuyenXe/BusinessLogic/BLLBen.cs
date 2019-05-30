using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;


namespace BusinessLogic
{
    public class BLLBen
    {
        DbQLBanVeXeKhachContext db = null;
        public BLLBen()
        {
            db = new DbQLBanVeXeKhachContext();
        }

        public List<BEN> GetBen()
        {
            var result = from b in db.BENs
                         select b;
            return result.ToList();
        }

        public void ThemBen(string maben, string tenben)
        {
            db.spInsertBen(maben, tenben);
        }

        public void ChinhSuaBen(string maben, string tenben)
        {
            db.spUpdateBen(maben, tenben);
        }

        public List<BEN> TimIDBen(string tenben)
        {
            var result = from b in db.BENs
                         where b.TenBen == tenben
                         select b;
            return result.ToList();
        }
    }
}
