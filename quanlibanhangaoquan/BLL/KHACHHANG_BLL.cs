using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class KHACHHANG_BLL
    {
        KHACHHANG_DAL khdal = new KHACHHANG_DAL();
        public DataTable Select_KHACHHANG()
        {
            return khdal.KH_select();
        }

        public int Insert_KHACHHANG(string TenKhachHang, string DiaChi, string SDT)
        {
            return khdal.KH_insert(TenKhachHang, DiaChi, SDT);
        }

        public int Update_KHACHHANG(string MaKhachHang, string TenKhachHang, string DiaChi, string SDT)
        {
            return khdal.KH_update(MaKhachHang, TenKhachHang, DiaChi, SDT);
        }
        public int Delete_KHACHHANG(string MaKhachHang)
        {
            return khdal.KH_delete(MaKhachHang);
        }
        public DataTable KhachHang_Timkiem(string Chuoitimkiem)
        {
            return khdal.KH_timkiem(Chuoitimkiem);
        }
    }
}
