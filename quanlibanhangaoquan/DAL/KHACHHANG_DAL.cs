using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class KHACHHANG_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable KH_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_KHACHHANG");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int KH_insert( string TenKhachHang, string DiaChi, string SDT)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@TenKhachHang"; value[0] = TenKhachHang;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@DiaChi"; value[1] = DiaChi;
            name[2] = "@SDT"; value[2] = SDT;
            return thaotac.SQL_Thuchien("Insert_KHACHHANG", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int KH_update(string MaKhachHang, string TenKhachHang, string DiaChi, string SDT)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaKhachHang"; value[0] = MaKhachHang;
            name[1] = "@TenKhachHang"; value[1] = TenKhachHang;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[2] = "@DiaChi"; value[2] = DiaChi;
            name[3] = "@SDT"; value[3] = SDT;
            return thaotac.SQL_Thuchien("Update_KHACHHANG", name, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int KH_delete(string MaKhachHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaKhachHang"; value[0] = MaKhachHang;
            return thaotac.SQL_Thuchien("Delete_KHACHHANG", name, value, 1);
        }
        public DataTable KH_timkiem(string Chuoitimkiem)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Chuoitimkiem"; value[0] = Chuoitimkiem;
            return thaotac.SQL_TimKiem("TimKiem_KHACHHANG", name, value, 1);
        }
    }
}
