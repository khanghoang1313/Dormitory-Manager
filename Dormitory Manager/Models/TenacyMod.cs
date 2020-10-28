using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Manager.Models
{
    class TenacyMod
    {
        public DataTable loadTenacy()
        {
            string CTR = "Select * from HOPDONG";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadTenacy3()
        {
            string CTR = "Select MaHopDong,MaPhong,MaNhanVien,MaKhachHang from HOPDONG";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadeditTenacy(string id)
        {
            string CTR = "select a.MaNhanVien, a.MaKhachHang, a.MaPhong, a.MaDichVu,b.* "
                +"from HOPDONG a, CHITIETHOPDONG b "
                +"where a.MaHopDong = b.MaHopDong and b.MaHopDong = '"+id+"'";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadTenacyinfo(string id)
        {
            string CTR = "Select * from CHITIETHOPDONG where MaHopDong='"+id+"'";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }

        public DataTable loadRTenacywithID(string id)
        {
            string CTR = "Select * from DICHVU where MaHopDong=" + id;
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool addTenacy(string RoomID, string StaffID, string SID, string CID)
        {
            string CTR = "insert into HOPDONG values (dbo.idTenancy(),'"+RoomID+"','"+StaffID+"','"+SID+"','"+CID+"')";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool addTenacyinfo(string date,string CusfName,string CuslName,string IDCus,string AddrCus,string StafName,string StalName,string IDSta,string AddrSta,string RoomName,string SerName,string Sercost,string Unit,string Deposit,string Start,string End)
        {
            //insert CHITIETHOPDONG values(dbo.getidTenancy(), '2020/10/20', N'Trần Trọng', N'Tín', '312409561', N'An Bình, Thành phố Biên Hòa, Đồng Nai', N'Nguyễn Huỳnh Trọng', N'Thoại', '312405689', N'22/7, Lê Văn Việt, Q9, Thành Phố Hồ Chí Minh ', N'Phòng 1', N'Tiền Phòng,Điện,Nước', '2200000,4000,16000', N'VNĐ/Tháng,VNĐ/kWh,VNĐ/m3', 500000, '2020/10/20', '2021/10/20')
            string CTR = "insert CHITIETHOPDONG values(dbo.getidTenancy(),'"+date+"',N'"+CusfName+"',N'"+CuslName+"','"+IDCus+"',N'"+AddrCus+"',N'"+StafName+"',N'"+StalName+"','"+IDSta+"',N'"+AddrSta+"',N'"+RoomName+"',N'"+SerName+"','"+Sercost+"',N'"+Unit+"',"+Deposit+",'"+Start+"','"+End+"')";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool delTenacy(string id)
        {
            string CTRTeninfo = "delete from CHITIETHOPDONG where MaHopDong='" + id + "'";
            string CTRTen = "delete from HOPDONG where MaHopDong='" + id + "'";
            bool result1 = DataProvider.ExecuteNonQuery(CTRTeninfo);
            bool result2 = false;
            if (result1 == true)
            {
                result2 = DataProvider.ExecuteNonQuery(CTRTen);
            }
            return result2;
        }
        public bool editTenacy(string tenID, string RoomID, string StaffID, string SID, string CID)
        {
            string CTR = "UPDATE[dbo].[HOPDONG] Set"
                    + "[MaPhong] = '"+RoomID+"'"
                    + ",[MaNhanVien] = '"+StaffID+"'"
                    + ",[MaDichVu] = '"+SID+"'"
                    + ",[MaKhachHang] = '"+CID+"'"
                    + "WHERE MaHopDong='"+tenID+"'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool editTenacyinfo(string tenID,string date, string CusfName, string CuslName, string IDCus, string AddrCus, string StafName, string StalName, string IDSta, string AddrSta, string RoomName, string SerName, string Sercost, string Unit, string Deposit, string Start, string End)
        {
            string CTR = "UPDATE [dbo].[CHITIETHOPDONG] SET"
                                  + "[NgayLapHopDong] = '"+date+"'"
                                  + ",[HoKhachHang] = N'"+CusfName+"'"
                                  + ",[TenKhachHang] = N'"+CuslName+"'"
                                  + ",[CMNDKH] = '"+IDCus+"'"
                                  + ",[DiaChiKH] = N'"+AddrCus+"'"
                                  + ",[HoNhanVien] = N'"+StafName+"'"
                                  + ",[TenNhanVien] = N'"+StalName+"'"
                                  + ",[CMNDNV] = '"+IDSta+"'"
                                  + ",[DiaChiPhongTro] = N'"+AddrSta+"'"
                                  + ",[TenPhong] = N'"+RoomName+"'"
                                  + ",[TenDichVu] = N'"+SerName+"'"
                                  + ",[GiaDichVu] = '"+Sercost+"'"
                                  + ",[DonViTinh] = N'"+Unit+"'"
                                  + ",[TienDatCoc] = '"+Deposit+"'"
                                  + ",[NgayBatDau] = '"+Start+"'"
                                  + ",[NgayKetThuc] = '"+End+"'"
                                  + " WHERE [MaHopDong] = '"+tenID+"'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }

    }
}
