using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class SANPHAM_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable SP_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_SANPHAM");
        }
        public int SP_insert(string TenSanPham, string DonGia, int SoLuongCon)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            //@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[0] = "@TenSanPham"; value[0] = TenSanPham;
            name[1] = "@DonGia"; value[1] = DonGia;
            name[2] = "@SoLuongCon"; value[2] = SoLuongCon;
            return thaotac.SQL_Thuchien("Insert_SANPHAN", name, value, 3);
        }
        public int SP_update(string MaSanPham, string TenSanPham, string DonGia, int SoLuongCon)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaSanPham"; value[0] = MaSanPham;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenSanPham"; value[1] = TenSanPham;
            name[2] = "@DonGia"; value[2] = DonGia;
            name[3] = "@SoLuongCon"; value[3] = SoLuongCon;
            return thaotac.SQL_Thuchien("Update_SANPHAM", name, value, 4);
        }
        public int SP_delete(string MaSanPham)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaSanPham"; value[0] = MaSanPham;
            return thaotac.SQL_Thuchien("Delete_SANPHAM", name, value, 1);

        }
        public DataTable SP_timkiem(string Chuoitimkiem)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Chuoitimkiem"; value[0] = Chuoitimkiem;
            return thaotac.SQL_TimKiem("Timkiem_SANPHAM", name, value, 1);
        }

    }

}
