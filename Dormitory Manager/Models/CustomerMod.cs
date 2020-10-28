using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Manager.Models
{
    class CustomerMod
    {
        public DataTable loadCustomer()
        {
            string CTR = "select * from KHACHHANG";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadCustomerwithID(string ID)
        {
            string CTR = "select * from KHACHHANG where MaKhachHang='"+ID+"'";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool addCustomer(string fname,string lname,string birth,string sex,string ID,string phone, string mail, string addr)
        {
            string CTR = "insert into KHACHHANG values (dbo.idCustomer(),N'"+fname+"',N'"+lname+"','"+birth+"',N'"+sex+"','"+ID+"','"+phone+"','"+mail+"',N'"+addr+"')";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool deCustomer(string value)
        {
            string CTR = "delete from KHACHHANG where MaKhachHang='" + value + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool editCustomer(string cusid,string fname, string lname, string birth, string sex, string ID, string phone, string mail, string addr)
        {
            string CTR = "update KHACHHANG set HoKhachHang=N'" + fname + "', TenKhachHang =N'" + lname + "',  NgaySinh='" + birth + "', GioiTinh=N'" + sex + "', CMND='" + ID + "',SoDienThoai='"+phone+"',ThuDienTu='"+mail+"',DiaChi=N'"+addr+"' where MaKhachHang='" + cusid + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
    }
}
