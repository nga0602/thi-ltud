using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class SANPHAM_BLL
    {
        SANPHAM_DAL spdal = new SANPHAM_DAL();
        public DataTable Select_SANPHAM()
        {
            return spdal.SP_select();
        }
        public int Insert_SANPHAN(string TenSanPham, string DonGia, int SoLuongCon)
        {
            return spdal.SP_insert(TenSanPham, DonGia, SoLuongCon);
        }
        public int Update_SANPHAM(string MaSanPham, string TenSanPham, string DonGia, int SoLuongCon)
        {
            return spdal.SP_update(MaSanPham, TenSanPham, DonGia, SoLuongCon);
        }
        public int Delete_SANPHAM(string MaSanPham)
        {
            return spdal.SP_delete(MaSanPham);
        }
        public DataTable SanPham_Timkiem(string Chuoitimkiem)
        {
            return spdal.SP_timkiem(Chuoitimkiem);
        }
    }
}