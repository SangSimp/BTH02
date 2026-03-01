namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon_ChiTiet
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
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            cboSanPham = new ComboBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGhiChuHoaDon = new TextBox();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 294);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1033, 142);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 40);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 3;
            label6.Text = "Số lượng bán (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 40);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 3;
            label5.Text = "Đơn giá bán (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 40);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 3;
            label4.Text = "Sản phẩm (*):";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(898, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(729, 80);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(152, 29);
            btnXacNhanBan.TabIndex = 2;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(369, 78);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(150, 30);
            numDonGiaBan.TabIndex = 1;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(553, 78);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(150, 30);
            numSoLuongBan.TabIndex = 1;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(41, 78);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(294, 31);
            cboSanPham.TabIndex = 0;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1033, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(575, 45);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 2;
            label3.Text = "Khách hàng (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 104);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 2;
            label2.Text = "Ghi chú hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 2;
            label1.Text = "Nhân viên lập (*):";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(209, 104);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(773, 30);
            txtGhiChuHoaDon.TabIndex = 1;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(718, 44);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(264, 31);
            cboKhachHang.TabIndex = 0;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(209, 44);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(277, 31);
            cboNhanVien.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 305);
            panel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1033, 305);
            dataGridView.TabIndex = 0;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnInHoaDon);
            panel3.Controls.Add(btnLuuHoaDon);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 516);
            panel3.Name = "panel3";
            panel3.Size = new Size(1033, 83);
            panel3.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(602, 27);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 29);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(419, 27);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(160, 29);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(225, 27);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(160, 29);
            btnLuuHoaDon.TabIndex = 0;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 599);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmHoaDon_ChiTiet";
            Text = "frmHoaDon_ChiTiet";
            Load += frmHoaDon_ChiTiet_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGhiChuHoaDon;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private DataGridView dataGridView;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private ComboBox cboSanPham;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}