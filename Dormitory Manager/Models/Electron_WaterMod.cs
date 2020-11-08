using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Manager.Models
{
    class Electron_WaterMod
    {
        public DataTable loadElectron_Water()
        {
            string CTR = "select MaDienNuoc as N'Số Phiếu',PhanLoai as N'Loại Phiếu',MaPhong as N'Mã Phòng', cast(ThoiGian as date) as N'Ngày Lập', SoCu as N'Số Cũ', SoMoi as N'Số Mới'"
                + ", SoTieuThu as N'Số Tiêu Thụ', DonGia as N'Đơn Giá', ThanhTien as N'Thành Tiền' , TrangThai as N'Trạng Thái'"
                + "from DIENNUOC";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public DataTable loadElectron_WaterwithID(string ID)
        {
            string CTR = "select MaDienNuoc as N'Số Phiếu',PhanLoai as N'Loại Phiếu',MaPhong as N'Mã Phòng', ThoiGian as N'Ngày Lập', SoCu as N'Số Cũ', SoMoi as N'Số Mới'"
                + ", SoTieuThu as N'Số Tiêu Thụ', DonGia as N'Đơn Giá', ThanhTien as N'Thành Tiền' , TrangThai as N'Trạng Thái'"
                + "from DIENNUOC where MaDienNuoc='"+ID+"'";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }

        public int Get_SoCu(string _LoaiPhieu,string _MaPhong)
        {
            string CTR = "select [dbo].[Get_SoCu](N'" + _LoaiPhieu + "',N'"+_MaPhong+"')";
            int result = Int32.Parse(DataProvider._SQL_ExecuteScalar(CTR).ToString());
            return result;
        }
        public float Get_Dongia(string _LoaiPhieu)
        {
            string CTR = "select [dbo].[Get_DonGiaDienNuoc](N'" + _LoaiPhieu + "')";
            float result = float.Parse(DataProvider._SQL_ExecuteScalar(CTR).ToString());
            return result;
        }
        public DataTable loadComboRoomID()
        {
            string CTR = "select MaPhong from PhongTro";
            DataTable result = DataProvider.ExecuteQuery(CTR);
            return result;
        }
        public bool addElectron_Water(string cboType_Value,string maphong, DateTime ngay, int socu, int somoi, int sotieuthu, float dongia, float thanhtien, string trangthai)
        {
           string CTR = "insert into DienNuoc values (dbo.idElectron_Water(N'" + cboType_Value + "'),'" + ngay+"','"+socu+"','"+somoi+"','"+sotieuthu+"',N'"+ cboType_Value + "','"+maphong+"','"+dongia+"','"+thanhtien+ "',N'" + trangthai + "')";
           bool result = DataProvider.ExecuteNonQuery(CTR);
           return result;
        }
        public bool deElectron_Water(string value)
        {
            string CTR = "delete from DienNuoc where MaDienNuoc='" + value + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
        public bool editElectron_Water(DateTime ngay, int somoi, int sotieuthu, float dongia, float thanhtien, string trangthai,string sophieu)
        {
            string CTR = "update DienNuoc set Thoigian = '"+ngay+ "',SoMoi = '" + somoi + "',SoTieuThu = '" + sotieuthu + "',DonGia = '" + dongia + "',ThanhTien = '" + thanhtien + "',TrangThai = N'" + trangthai + "' where MaDienNuoc='" + sophieu + "'";
            bool result = DataProvider.ExecuteNonQuery(CTR);
            return result;
        }
    }
}
