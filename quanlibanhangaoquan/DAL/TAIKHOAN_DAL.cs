using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class TAIKHOAN_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable TK_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_TAIKHOAN");
        }
        public int TK_insert(string TenTaiKhoan, string MatKhau, String QuyenHan)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            //@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[0] = "@TenTaiKhoan"; value[0] = TenTaiKhoan;
            name[1] = "@MatKhau"; value[1] = MatKhau;
            name[2] = "@QuyenHan"; value[2] = QuyenHan;
            return thaotac.SQL_Thuchien("Insert_TAIKHOAN", name, value, 3);
        }
        public int TK_update(string TenTaiKhoan, string MatKhau, String QuyenHan)
        {
            name = new string[3];
            value = new object[3];
            //@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[0] = "@TenTaiKhoan"; value[0] = TenTaiKhoan;
            name[1] = "@MatKhau"; value[1] = MatKhau;
            name[2] = "@QuyenHan"; value[2] = QuyenHan;
            return thaotac.SQL_Thuchien("Update_TAIKHOAN", name, value, 4);
        }
        public int TK_delete(string TenTaiKhoan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenTaiKhoan"; value[0] = TenTaiKhoan;
            return thaotac.SQL_Thuchien("Delete_TAIKHOAN", name, value, 1);

        }

    } 
}


