using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Manager.Models
{
    class ServiceMod
    {
        public DataTable loadService()
        {
            string CTR = "Select * from DICHVU";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadServiceinedit(string  id)
        {
            string CTR = "Select * from DICHVU where MaDichVu="+id;
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool addService(string name, string cost, string unit)
        {
            string CTR = "insert into DICHVU values (dbo.idService(),N'" + name+"',"+cost+",N'"+unit+"')";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool delService(string value)
        {
            string CTR = "delete from DICHVU where MaDichVu='" + value + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool editService(string id, string sName, string price, string unit)
        {
            string CTR = "update DICHVU set TenDichVu=N'" + sName+ "', DonGia =" + price + ",  DonViTinh=N'" + unit + "'where MaDichVu='" + id + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
    }
}
