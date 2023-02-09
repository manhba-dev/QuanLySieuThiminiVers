namespace STOCK
{
    partial class frmCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongTy));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbDISABLED = new System.Windows.Forms.CheckBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnThem,
            this.toolStripSeparator3,
            this.btnSua,
            this.toolStripSeparator4,
            this.btnXoa,
            this.toolStripSeparator5,
            this.btnLuu,
            this.toolStripSeparator6,
            this.btnBoQua,
            this.toolStripSeparator7,
            this.btnThoat,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 24);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(57, 24);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(80, 24);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::STOCK.Properties.Resources._38999_exit_icon;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(71, 24);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 27);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(842, 240);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.MACTY,
            this.TENCTY,
            this.DIENTHOAI,
            this.FAX,
            this.EMAIL,
            this.DIACHI});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowAutoFilterRow = true;
            //this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "DEL";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 71;
            // 
            // MACTY
            // 
            this.MACTY.Caption = "MACTY";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.Name = "MACTY";
            this.MACTY.Visible = true;
            this.MACTY.VisibleIndex = 1;
            // 
            // TENCTY
            // 
            this.TENCTY.Caption = "Tên Công Ty";
            this.TENCTY.FieldName = "TENCTY";
            this.TENCTY.Name = "TENCTY";
            this.TENCTY.Visible = true;
            this.TENCTY.VisibleIndex = 2;
            this.TENCTY.Width = 148;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.Caption = "ĐIỆN THOẠI";
            this.DIENTHOAI.FieldName = "DIENTHOAI";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Visible = true;
            this.DIENTHOAI.VisibleIndex = 3;
            this.DIENTHOAI.Width = 148;
            // 
            // FAX
            // 
            this.FAX.Caption = "FAX";
            this.FAX.FieldName = "FAX";
            this.FAX.Name = "FAX";
            this.FAX.Visible = true;
            this.FAX.VisibleIndex = 4;
            this.FAX.Width = 148;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "EMAIL";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 5;
            this.EMAIL.Width = 148;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "ĐỊA CHỈ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 6;
            this.DIACHI.Width = 157;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbDISABLED);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // chbDISABLED
            // 
            this.chbDISABLED.AutoSize = true;
            this.chbDISABLED.Location = new System.Drawing.Point(705, 69);
            this.chbDISABLED.Name = "chbDISABLED";
            this.chbDISABLED.Size = new System.Drawing.Size(93, 21);
            this.chbDISABLED.TabIndex = 17;
            this.chbDISABLED.Text = "DISABLED";
            this.chbDISABLED.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(100, 155);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(693, 23);
            this.txtDiaChi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(604, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Location = new System.Drawing.Point(333, 110);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(160, 23);
            this.txtFax.TabIndex = 10;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienThoai.Location = new System.Drawing.Point(88, 110);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(172, 23);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Location = new System.Drawing.Point(266, 67);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(383, 23);
            this.txtTen.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMa.Location = new System.Drawing.Point(51, 64);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(167, 23);
            this.txtMa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã:";
            // 
            // frmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCongTy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Công Ty";
            this.Load += new System.EventHandler(this.frmCongTy_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private DevExpress.XtraGrid.Columns.GridColumn TENCTY;
        private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn FAX;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbDISABLED;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
    }
}