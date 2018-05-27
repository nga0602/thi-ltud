using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace quanlibanhangaoquan
{
    public partial class Form2 : Form
    {
        SANPHAM_BLL spbll = new SANPHAM_BLL();
        NHANVIEN_BLL nvbll = new NHANVIEN_BLL();
        KHACHHANG_BLL khbll = new KHACHHANG_BLL();
        HOADON_BLL hdbll = new HOADON_BLL();
        TAIKHOAN_BLL tkbll = new TAIKHOAN_BLL();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadtk();
            GetCommodity();
            loadNV();
            loadKH();
            dataGridView1.DataSource = hdbll.Select_CHITIETHOADON();

        }

        void GetCommodity()
        {
            gridSP.DataSource = spbll.Select_SANPHAM();
        }
        void loadNV()
        {
            gridNV.DataSource = nvbll.Select_NHAVIEN();
        }
        void loadKH()
        {
            gridKH.DataSource = khbll.Select_KHACHHANG();
        }
        void loadtk()
        {
            gridTK.DataSource = tkbll.Select_TAIKHOAN();
        }
        private void gridSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasanphamSP.Text = gridSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttensanphamSP.Text = gridSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdongiaSP.Text = gridSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsoluongconSP.Text = gridSP.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnluuSP_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn lưu" + txttensanphamSP.Text.ToString() + "vào Cơ Sở Dữ Liệu", "",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txttensanphamSP.Text == "" || txtdongiaSP.Text == "" || txtsoluongconSP.Text == "")
                MessageBox.Show("Dữ liệu chưa nhập đủ!", "Thông báo!", MessageBoxButtons.OK);
            else
            {
                gridSP.DataSource = spbll.Insert_SANPHAN(txttensanphamSP.Text, txtdongiaSP.Text, int.Parse(txtsoluongconSP.Text));
                GetCommodity();
            }

        }

        private void btnsuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                gridSP.DataSource = spbll.Update_SANPHAM(txtmasanphamSP.Text, txttensanphamSP.Text, txtdongiaSP.Text, int.Parse(txtsoluongconSP.Text));
                MessageBox.Show("Cập Nhật Thành công!");
                GetCommodity();
            }
            catch (Exception LOI)
            {
                MessageBox.Show(LOI.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnxoaSP_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    spbll.Delete_SANPHAM(txtmasanphamSP.Text);
                    txtmasanphamSP.Clear();
                    txttensanphamSP.Clear();
                    txtdongiaSP.Clear();
                    txtsoluongconSP.Clear();
                    gridSP.ClearSelection();
                    GetCommodity();
                }
                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btntaomoiSP_Click(object sender, EventArgs e)
        {
            txtmasanphamSP.Clear();
            txttensanphamSP.Clear();
            txtdongiaSP.Clear();
            txtsoluongconSP.Clear();
            txttensanphamSP.Focus();
        }

        private void btntaomoiNV_Click(object sender, EventArgs e)
        {
            txtmanhanvienNV.Clear();
            txttennhanvienNV.Clear();
            txtdiachiNV.Clear();
            radionamNV.Checked = false;
            radionuNV.Checked = false;
            txtsdtNV.Clear();
            txttennhanvienNV.Focus();
        }

        private void btnsuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string GioiTinh;
                if (radionamNV.Checked == true)
                    GioiTinh = "1";
                else
                    GioiTinh = "0";
                gridNV.DataSource = nvbll.Update_NHANVIEN(txtmanhanvienNV.Text, txttennhanvienNV.Text, txtdiachiNV.Text, txtsdtNV.Text, GioiTinh);
                MessageBox.Show("Cập Nhập Thành công!");
                loadNV();
            }
            catch (Exception LOI)
            {
                MessageBox.Show(LOI.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluuNV_Click(object sender, EventArgs e)
        {
            string GioiTinh;
            if (radionamNV.Checked == true)
                GioiTinh = "1";
            else
                GioiTinh = "0";
            DialogResult key = MessageBox.Show("Bạn có muốn lưu" + txttennhanvienNV.Text.ToString() + "vào cơ sở dữ liệu", "",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txttennhanvienNV.Text == "" || txtdiachiNV.Text == "" || txtsdtNV.Text == "")
                MessageBox.Show("Dữ liệu chưa nhập đầy đủ!", "Thông báo!", MessageBoxButtons.OK);
            else
            {
                gridNV.DataSource = nvbll.Insert_NHANVIEN(txttennhanvienNV.Text, txtdiachiNV.Text, txtsdtNV.Text, GioiTinh);
                loadNV();
            }

        }

        private void btnxoaNV_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    nvbll.Delete_NHANVIEN(txtmanhanvienNV.Text);
                    txtmanhanvienNV.Clear();
                    txttennhanvienNV.Clear();
                    txtdiachiNV.Clear();
                    txtsdtNV.Clear();
                    gridNV.ClearSelection();
                    loadNV();
                }
                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnthoatNV_Click(object sender, EventArgs e)
        {
            Form1 fp = new Form1();
            fp.Show();
            this.Close();
        }

        private void gridNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanhanvienNV.Text = gridNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennhanvienNV.Text = gridNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdiachiNV.Text = gridNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsdtNV.Text = gridNV.Rows[e.RowIndex].Cells[3].Value.ToString();

            if ((bool)gridNV.Rows[e.RowIndex].Cells[4].Value == true)
                radionamNV.Checked = true;
            else
                radionuNV.Checked = true;
        }

        private void btntaomoiKH_Click(object sender, EventArgs e)
        {
            txtmakhachhangKH.Clear();
            txttenkhachhangKH.Clear();
            txtsdtKH.Clear();
            txtdiachiKH.Clear();
            txttenkhachhangKH.Focus();
        }

        private void btnsuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                gridKH.DataSource = khbll.Update_KHACHHANG(txtmakhachhangKH.Text, txttenkhachhangKH.Text, txtdiachiKH.Text, txtsdtKH.Text);
                MessageBox.Show("Cập nhập Thành công!");
                loadKH();
            }
            catch (Exception LOI)
            {
                MessageBox.Show(LOI.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluuKH_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn lưu" + txttenkhachhangKH.Text.ToString() + "vào Cơ sở dữ liệu", "",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txttenkhachhangKH.Text == "" || txtdiachiKH.Text == "" || txtsdtKH.Text == "")
                MessageBox.Show("Dữ liệu chưa nhập đầy đủ!", "Thông báo!", MessageBoxButtons.OK);
            else
            {
                gridKH.DataSource = khbll.Insert_KHACHHANG(txttenkhachhangKH.Text, txtdiachiKH.Text, txtsdtKH.Text);
                loadKH();
            }
        }

        private void btnxoaKH_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    khbll.Delete_KHACHHANG(txtmakhachhangKH.Text);
                    txtmakhachhangKH.Clear();
                    txttenkhachhangKH.Clear();
                    txtsdtKH.Clear();
                    txtdiachiKH.Clear();
                    gridKH.ClearSelection();
                    loadKH();
                }
                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnthoatKH_Click(object sender, EventArgs e)
        {
            Form1 fp = new Form1();
            fp.Show();
            this.Close();
        }

        private void gridKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhachhangKH.Text = gridKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenkhachhangKH.Text = gridKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsdtKH.Text = gridKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdiachiKH.Text = gridKH.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btntaomoiTK_Click(object sender, EventArgs e)
        {
            txttentaikhoanTK.Clear();
            txtmatkhauTK.Clear();
            txtquyenhanTK.Clear();
            txttentaikhoanTK.Focus();
        }

        private void btnsuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                gridTK.DataSource = tkbll.Update_TAIKHOAN(txttentaikhoanTK.Text, txtmatkhauTK.Text, txtquyenhanTK.Text);
                MessageBox.Show("Cập nhập Thành công!");
                loadtk();
            }
            catch (Exception LOI)
            {
                MessageBox.Show(LOI.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluuTK_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn lưu" + txttentaikhoanTK.Text.ToString() + "vào Cơ sở dữ liệu", "",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (txtmatkhauTK.Text == "" || txtquyenhanTK.Text == "")
                MessageBox.Show("Dữ liệu chưa nhập đầy đủ!", "Thông báo!", MessageBoxButtons.OK);
            else
            {
                gridTK.DataSource = tkbll.Insert_TAIKHOAN(txttentaikhoanTK.Text, txtmatkhauTK.Text, txtquyenhanTK.Text);
                loadtk();
            }
        }

        private void btnxoaTK_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    tkbll.Delete_TAIKHOAN(txttentaikhoanTK.Text);
                    txttentaikhoanTK.Clear();
                    txtmatkhauTK.Clear();
                    txtquyenhanTK.Clear();

                    gridTK.ClearSelection();
                    loadtk();
                }
                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoatTK_Click(object sender, EventArgs e)
        {
            Form1 fp = new Form1();
            fp.Show();
            this.Close();
        }

        private void gridTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttentaikhoanTK.Text = gridTK.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtmatkhauTK.Text = gridTK.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtquyenhanTK.Text = gridTK.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnthoatSP_Click(object sender, EventArgs e)
        {
            Form1 fp = new Form1();
            fp.Show();
            this.Close();
        }

        

        private void btntimkiemNV_Click(object sender, EventArgs e)
        {
            gridNV.DataSource = nvbll.NhanVien_Timkiem(txttimkiemNV.Text);
        }

        private void btntimkiemSP_Click(object sender, EventArgs e)
        {
            gridSP.DataSource = spbll.SanPham_Timkiem(txttimkiemSP.Text);
        }

        private void btntimkiemKH_Click(object sender, EventArgs e)
        {
            gridKH.DataSource = khbll.KhachHang_Timkiem(txttimkiemKH.Text);
        }
    }
}
