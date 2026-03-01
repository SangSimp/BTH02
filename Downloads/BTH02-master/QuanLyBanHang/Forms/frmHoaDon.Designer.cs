namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            panel2 = new Panel();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnInHoaDon = new Button();
            btnLapHoaDon = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1288, 239);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1288, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1282, 213);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "dd/MM/yyyy";
            NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.Format = "N0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXuat);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnLapHoaDon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(1288, 95);
            panel2.TabIndex = 1;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Segoe UI", 10.2F);
            btnXuat.Location = new Point(1041, 22);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(142, 29);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10.2F);
            btnTimKiem.Location = new Point(893, 22);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(142, 29);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(752, 22);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(135, 29);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(634, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Location = new Point(508, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Font = new Font("Segoe UI", 10.2F);
            btnInHoaDon.Location = new Point(326, 22);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(176, 29);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Font = new Font("Segoe UI", 10.2F);
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Location = new Point(127, 22);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(193, 29);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Text = "Lập hóa đơn mới...";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 334);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private Panel panel2;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnInHoaDon;
        private Button btnLapHoaDon;
    }
}