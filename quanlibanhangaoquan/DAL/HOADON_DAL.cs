using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HOADON_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable CTHD_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_CHITIETHOADON");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int HD_insert(DateTime ThoiGianLapHoaDon, string MaKhachHang, String MaNhanVien)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@ThoiGianLapHoaDon"; value[1] = ThoiGianLapHoaDon;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@MaKhachHang"; value[2] = MaKhachHang;
            name[2] = "@MaNhanVien"; value[3] = MaNhanVien;
            return thaotac.SQL_Thuchien("Insert_HOADON", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int HD_update(string MaHoaDon, DateTime ThoiGianLapHoaDon, string MaKhachHang, String MaNhanVien)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            name[1] = "@ThoiGianLapHoaDon"; value[1] = ThoiGianLapHoaDon;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[2] = "@MaKhachHang"; value[2] = MaKhachHang;
            name[3] = "@MaNhanVien"; value[3] = MaNhanVien;

            return thaotac.SQL_Thuchien("Update_HOADON", name, value, 4);
        }
        public int CTHD_insert(string MaHoaDon, int SoLuongMua, float DonGia, string MaSanPham)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            name[1] = "@SoLuongMua"; value[1] = SoLuongMua;
            name[2] = "@DonGia"; value[2] = DonGia;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[3] = "@MaSanPham"; value[3] = MaSanPham;
            return thaotac.SQL_Thuchien("Insert_CHITIETHOADON", name, value, 4);
        }
        public int CTHD_update(string MaHoaDon, int SoLuongMua, float DonGia, string MaSanPham)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            name[1] = "@SoLuongMua"; value[1] = SoLuongMua;
            name[2] = "@DonGia"; value[2] = DonGia;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[3] = "@MaSanPham"; value[3] = MaSanPham;
            return thaotac.SQL_Thuchien("Update_CHITIETHOADON", name, value, 4);
        }

        public int HD_delete(string MaHoaDon)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            return thaotac.SQL_Thuchien("Delete_HOADON", name, value, 1);
        }
        public int CTHD_delete(string MaHoaDon, string MaSanPham)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            name[1] = "@MaSanPham"; value[1] = MaSanPham;
            return thaotac.SQL_Thuchien("Delete_CHITIETHOADON", name, value, 2);
        }
    }
}
