using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TAIKHOAN_BLL
    {
        TAIKHOAN_DAL tkdal = new TAIKHOAN_DAL();
        public DataTable Select_TAIKHOAN()
        {
            return tkdal.TK_select();
        }
        public int Insert_TAIKHOAN (string TenTaiKhoan, string MatKhau, String QuyenHan)
        {
            return tkdal.TK_insert (TenTaiKhoan,MatKhau,QuyenHan);
        }
        public int Update_TAIKHOAN(string TenTaiKhoan, string MatKhau, String QuyenHan)
        {
            return tkdal.TK_update(TenTaiKhoan, MatKhau, QuyenHan);

        }
        public int Delete_TAIKHOAN(string TenTaiKhoan)
        {
            return tkdal.TK_delete(TenTaiKhoan);
        }

    }
}
