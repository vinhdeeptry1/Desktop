namespace Lab03_demo
{
    partial class frmChinh
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 618;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChuyenNganh);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblHinh);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lbMSSV);
            this.groupBox1.Controls.Add(this.clbChuyenNganh);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.pbHinh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnMacDinh);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtHinh);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.mtxtMaSo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 681);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenNganh.Location = new System.Drawing.Point(12, 384);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(139, 24);
            this.lblChuyenNganh.TabIndex = 10;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 323);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 24);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblHinh
            // 
            this.lblHinh.AutoSize = true;
            this.lblHinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinh.Location = new System.Drawing.Point(12, 264);
            this.lblHinh.Name = "lblHinh";
            this.lblHinh.Size = new System.Drawing.Size(51, 24);
            this.lblHinh.TabIndex = 10;
            this.lblHinh.Text = "Hình";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(238, 215);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(43, 24);
            this.lblLop.TabIndex = 10;
            this.lblLop.Text = "Lớp";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(238, 164);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(73, 24);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(238, 117);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 24);
            this.lblNgaySinh.TabIndex = 10;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(238, 68);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(71, 24);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(238, 19);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(65, 24);
            this.lbMSSV.TabIndex = 10;
            this.lbMSSV.Text = "Mã Số";
            // 
            // clbChuyenNganh
            // 
            this.clbChuyenNganh.CheckOnClick = true;
            this.clbChuyenNganh.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbChuyenNganh.FormattingEnabled = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(175, 384);
            this.clbChuyenNganh.Name = "clbChuyenNganh";
            this.clbChuyenNganh.Size = new System.Drawing.Size(253, 166);
            this.clbChuyenNganh.TabIndex = 9;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(268, 319);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 28);
            this.rdNu.TabIndex = 8;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(146, 319);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(70, 28);
            this.rdNam.TabIndex = 8;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 19);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(215, 220);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 7;
            this.pbHinh.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(532, 605);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 70);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.Location = new System.Drawing.Point(399, 605);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(80, 70);
            this.btnMacDinh.TabIndex = 6;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(268, 605);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 70);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(136, 605);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 70);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 605);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 70);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(574, 260);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 28);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtHinh
            // 
            this.txtHinh.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinh.Location = new System.Drawing.Point(97, 256);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(471, 32);
            this.txtHinh.TabIndex = 5;
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
            this.cboLop.Location = new System.Drawing.Point(366, 207);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(246, 32);
            this.cboLop.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(366, 156);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 32);
            this.txtDiaChi.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(366, 109);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(246, 32);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(366, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(246, 32);
            this.txtHoTen.TabIndex = 1;
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtMaSo.Location = new System.Drawing.Point(366, 11);
            this.mtxtMaSo.Mask = "SV.00000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(246, 32);
            this.mtxtMaSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvSinhVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 681);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 16);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(636, 662);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Số";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phái";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chuyên Ngành";
            this.columnHeader7.Width = 500;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hình";
            this.columnHeader8.Width = 200;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmChinh";
            this.Text = "demo Sinh Viên";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckedListBox clbChuyenNganh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

