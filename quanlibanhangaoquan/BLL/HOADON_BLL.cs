using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public  class HOADON_BLL
    {
        HOADON_DAL hddal = new HOADON_DAL();
        //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
        public DataTable Select_CHITIETHOADON()
        {
            return hddal.CTHD_select();
        }

        //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
        public int Insert_HOADON(DateTime ThoiGianLapHoaDon, string MaKhachHang, String MaNhanVien)
        {
            return hddal.HD_insert(ThoiGianLapHoaDon, MaKhachHang, MaNhanVien);
        }
        public int Insert_CHITIETHOADON(string MaHoaDon, int SoLuongMua, float DonGia, string MaSanPham)
        {
            return hddal.CTHD_insert(MaHoaDon, SoLuongMua, DonGia,MaSanPham);
        }
        //phương thức này gọi phương thức sv_update() ở lớp SinhVien_DAL (tầng DAL)
        public int Update_HOADON(string MaHoaDon, DateTime ThoiGianLapHoaDon, string MaKhachHang, String MaNhanVien)
        {
            return hddal.HD_update(MaHoaDon, ThoiGianLapHoaDon, MaKhachHang, MaNhanVien);
        }
        public int ChiTietHoaDon_Update(string MaHoaDon, int SoLuongMua, float DonGia, string MaSanPham)
        {
            return hddal.CTHD_update(MaHoaDon, SoLuongMua, DonGia, MaSanPham);
        }
        //phương thức này gọi phương thức sv_delete() ở lớp SinhVien_DAL (tầng DAL)
        public int Delete_HOADON(string MaHoaDon)
        {
            return hddal.HD_delete(MaHoaDon);
        }
        public int Delete_CHITIETHOADON(string MaHoaDon, string MaSanPham)
        {
            return hddal.CTHD_delete(MaHoaDon, MaSanPham);

        }
    }
}
