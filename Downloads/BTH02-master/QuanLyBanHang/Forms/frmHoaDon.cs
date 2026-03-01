using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            var hd = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDon_ChiTiet)
                .AsEnumerable() // Kéo toàn bộ dữ liệu thô về RAM
                .Select(r => new DanhSachHoaDon
                {
                    // Dùng Convert.ToInt32() thay vì (int) để an toàn tuyệt đối
                    ID = Convert.ToInt32(r.ID),
                    NhanVienID = Convert.ToInt32(r.NhanVienID),
                    HoVaTenNhanVien = r.NhanVien?.HoVaTen,
                    KhachHangID = Convert.ToInt32(r.KhachHangID),
                    HoVaTenKhachHang = r.KhachHang?.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    // Áp dụng Convert.ToInt32 cho các phép tính Sum
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => Convert.ToInt32(ct.SoLuongBan) * Convert.ToInt32(ct.DonGiaBan)),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();

            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                var hd = context.HoaDon.Find(id);
                context.HoaDon.Remove(hd);
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }
    }
}
