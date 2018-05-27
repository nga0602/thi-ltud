using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class NHANVIEN_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable NV_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_NHAVIEN");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int NV_insert( string TenNhanVien, string DiaChi, string SDT, string Gioitinh)
        {
            //thaotac.KetnoiCSDL();
            name = new string[4];
            value = new object[4];
            name[0] = "@TenNhanVien"; value[0] = TenNhanVien;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@DiaChi"; value[1] = DiaChi;
            name[2] = "@SDT"; value[2] = SDT;
            name[3] = "@Gioitinh"; value[3] = Gioitinh;
            return thaotac.SQL_Thuchien("Insert_NHANVIEN", name, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int NV_update(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Gioitinh)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            name[1] = "@TenNhanVien"; value[1] = TenNhanVien;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[2] = "@DiaChi"; value[2] = DiaChi;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@gioitinh"; value[4] = Gioitinh;
            return thaotac.SQL_Thuchien("Update_NHANVIEN", name, value, 5);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int NV_delete(string MaNhanVien)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            return thaotac.SQL_Thuchien("Delete_NHANVIEN", name, value, 1);
        }
        public DataTable NV_timkiem(string Chuoitimkiem)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Chuoitimkiem"; value[0] = Chuoitimkiem;
            return thaotac.SQL_TimKiem("TimKiem_NHANVIEN", name, value, 1);
        }
    }
}
