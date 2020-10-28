using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Manager.Models
{
    class StaffMod
    {
        public DataTable loadStaff()
        {
            string CTR = "select * from NHANVIEN";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadStaffwithID(string ID)
        {
            string CTR = "select * from NHANVIEN where MaNhanVien='" + ID + "'";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool addStaff(string fname, string lname, string birth, string sex, string ID, string phone, string mail, string addr)
        {
            string CTR = "insert into NHANVIEN values (dbo.idStaff(),N'" + fname + "',N'" + lname + "','" + birth + "',N'" + sex + "','" + ID + "','" + phone + "','" + mail + "',N'" + addr + "')";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool deStaff(string value)
        {
            string CTR = "delete from NHANVIEN where MaNhanVien='" + value + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool editStaff(string cusid, string fname, string lname, string birth, string sex, string ID, string phone, string mail, string addr)
        {
            string CTR = "update NHANVIEN set HoNhanVien=N'" + fname + "', TenNhanVien =N'" + lname + "',  NgaySinh='" + birth + "', GioiTinh=N'" + sex + "', CMND='" + ID + "',SoDienThoai='" + phone + "',ThuDienTu='" + mail + "',DiaChi=N'" + addr + "' where MaNhanVien='" + cusid + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
    }
}
