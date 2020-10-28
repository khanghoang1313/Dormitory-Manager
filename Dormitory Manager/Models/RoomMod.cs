using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Manager.Models
{
    class RoomMod
    {
        public DataTable loadRoom()
        {
            string CTR = "select * from PHONGTRO a, TRANGTHAIPHONG b where a.MaTrangThai=b.MaTrangThai";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadRoominEditTenacy()
        {
            string CTR = "select MaPhong,TenPhong from PHONGTRO where MaTrangThai BETWEEN 1  and 3 ";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadRoominAddTenacy()
        {
            string CTR = "select MaPhong,TenPhong from PHONGTRO where MaTrangThai=1";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool addRoom(string value)
        {
            string CTR = "insert into PHONGTRO values ("+ value+")";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public DataTable loadStatus()
        {
            string CTR = "select * from TRANGTHAIPHONG";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool setStatus(string idRoom)
        {
            string CTR = "update PHONGTRO set MaTrangThai= '2'  where MaPhong='" + idRoom + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool delRoom(string value)
        {
            string CTR = "delete from PHONGTRO where MaPhong='"+value+"'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool editRoom(string id,string status,string RoomName,string desc, string area, string max)
        {
            string CTR = "update PHONGTRO set MaTrangThai="+ status + ", TenPhong =N'"+ RoomName + "',  MoTa=N'"+ desc + "', DienTich="+ area + ", SoNguoiO="+max+" where MaPhong='"+id+"'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool updatestatusRoom()
        {
            string CTR = "exec updateStatus";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
    }
}
