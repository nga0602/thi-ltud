using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class NHANVIEN_BLL
    {
        NHANVIEN_DAL nvdal = new NHANVIEN_DAL();
        public DataTable Select_NHAVIEN()
        {
            return nvdal.NV_select();
        }

        public int Insert_NHANVIEN(string TenNhanVien, string DiaChi, string SDT, string Gioitinh)
        {
            return nvdal.NV_insert(TenNhanVien, DiaChi, SDT, Gioitinh);
        }

        public int Update_NHANVIEN(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Gioitinh)
        {
            return nvdal.NV_update(MaNhanVien,TenNhanVien, DiaChi, SDT, Gioitinh);
        }
        public int Delete_NHANVIEN(string MaNhanVien)
        {
            return nvdal.NV_delete(MaNhanVien);
        }
    }
}
