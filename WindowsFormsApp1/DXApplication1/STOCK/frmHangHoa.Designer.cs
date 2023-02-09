namespace STOCK
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
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
            this.btnexport = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRIGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAXX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkDISABLED = new System.Windows.Forms.CheckBox();
            this.cboNhacungcap = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboXuatXU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.spGia = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBARCODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGia.Properties)).BeginInit();
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
            this.toolStripSeparator1,
            this.btnexport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1290, 27);
            this.toolStrip1.TabIndex = 4;
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
            // btnexport
            // 
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(101, 24);
            this.btnexport.Text = "Xuất Excel";
            this.btnexport.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 27);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcDanhSach);
            this.splitContainerControl1.Panel1.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1290, 626);
            this.splitContainerControl1.SplitterPosition = 360;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 66);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(924, 560);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BARCODE,
            this.TENHH,
            this.TENTAT,
            this.MOTA,
            this.DVT,
            this.TRIGIA,
            this.MANCC,
            this.MAXX,
            this.IDNHOM,
            this.DISABLED});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // BARCODE
            // 
            this.BARCODE.Caption = "BARCODE";
            this.BARCODE.FieldName = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Visible = true;
            this.BARCODE.VisibleIndex = 0;
            // 
            // TENHH
            // 
            this.TENHH.Caption = "TÊN";
            this.TENHH.FieldName = "TENHH";
            this.TENHH.Name = "TENHH";
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            // 
            // TENTAT
            // 
            this.TENTAT.Caption = "TENTAT";
            this.TENTAT.FieldName = "TENTAT";
            this.TENTAT.Name = "TENTAT";
            this.TENTAT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "MÔ Tả";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.Name = "MOTA";
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 3;
            // 
            // DVT
            // 
            this.DVT.Caption = "DVT";
            this.DVT.FieldName = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 2;
            // 
            // TRIGIA
            // 
            this.TRIGIA.Caption = "TRỊ GIÁ";
            this.TRIGIA.DisplayFormat.FormatString = "{0:N0}";
            this.TRIGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TRIGIA.FieldName = "DONGIA";
            this.TRIGIA.Name = "TRIGIA";
            this.TRIGIA.Visible = true;
            this.TRIGIA.VisibleIndex = 4;
            // 
            // MANCC
            // 
            this.MANCC.Caption = "MANCC";
            this.MANCC.FieldName = "MANCC";
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = true;
            this.MANCC.VisibleIndex = 5;
            // 
            // MAXX
            // 
            this.MAXX.Caption = "MAXX";
            this.MAXX.FieldName = "MAXX";
            this.MAXX.Name = "MAXX";
            this.MAXX.Visible = true;
            this.MAXX.VisibleIndex = 6;
            // 
            // IDNHOM
            // 
            this.IDNHOM.Caption = "IDNHOM";
            this.IDNHOM.FieldName = "IDNHOM";
            this.IDNHOM.Name = "IDNHOM";
            this.IDNHOM.Visible = true;
            this.IDNHOM.VisibleIndex = 7;
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "DEL";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboNhom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 66);
            this.panel1.TabIndex = 1;
            // 
            // cboNhom
            // 
            this.cboNhom.FormattingEnabled = true;
            this.cboNhom.Location = new System.Drawing.Point(136, 25);
            this.cboNhom.Name = "cboNhom";
            this.cboNhom.Size = new System.Drawing.Size(505, 24);
            this.cboNhom.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhóm:";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.chkDISABLED);
            this.groupControl1.Controls.Add(this.cboNhacungcap);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.cboXuatXU);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtMota);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.cboDVT);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.spGia);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtTenTat);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtBARCODE);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 626);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Hàng Hóa";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // chkDISABLED
            // 
            this.chkDISABLED.AutoSize = true;
            this.chkDISABLED.ForeColor = System.Drawing.Color.Red;
            this.chkDISABLED.Location = new System.Drawing.Point(24, 488);
            this.chkDISABLED.Name = "chkDISABLED";
            this.chkDISABLED.Size = new System.Drawing.Size(93, 21);
            this.chkDISABLED.TabIndex = 17;
            this.chkDISABLED.Text = "DISABLED";
            this.chkDISABLED.UseVisualStyleBackColor = true;
            // 
            // cboNhacungcap
            // 
            this.cboNhacungcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhacungcap.FormattingEnabled = true;
            this.cboNhacungcap.Location = new System.Drawing.Point(124, 450);
            this.cboNhacungcap.Name = "cboNhacungcap";
            this.cboNhacungcap.Size = new System.Drawing.Size(211, 24);
            this.cboNhacungcap.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // cboXuatXU
            // 
            this.cboXuatXU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXuatXU.FormattingEnabled = true;
            this.cboXuatXU.Location = new System.Drawing.Point(124, 415);
            this.cboXuatXU.Name = "cboXuatXU";
            this.cboXuatXU.Size = new System.Drawing.Size(211, 24);
            this.cboXuatXU.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Xuất xứ:";
            // 
            // txtMota
            // 
            this.txtMota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMota.Location = new System.Drawing.Point(120, 248);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(215, 143);
            this.txtMota.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mô tả:";
            // 
            // cboDVT
            // 
            this.cboDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Location = new System.Drawing.Point(124, 206);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(179, 24);
            this.cboDVT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn vị tính:";
            // 
            // spGia
            // 
            this.spGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spGia.Location = new System.Drawing.Point(120, 165);
            this.spGia.Name = "spGia";
            this.spGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spGia.Size = new System.Drawing.Size(125, 22);
            this.spGia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trị giá:";
            // 
            // txtTenTat
            // 
            this.txtTenTat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTat.Location = new System.Drawing.Point(120, 125);
            this.txtTenTat.Name = "txtTenTat";
            this.txtTenTat.Size = new System.Drawing.Size(204, 23);
            this.txtTenTat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Tắt:";
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Location = new System.Drawing.Point(120, 85);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(204, 23);
            this.txtTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // txtBARCODE
            // 
            this.txtBARCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBARCODE.Location = new System.Drawing.Point(120, 49);
            this.txtBARCODE.Name = "txtBARCODE";
            this.txtBARCODE.Size = new System.Drawing.Size(125, 23);
            this.txtBARCODE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARCODE";
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 653);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGia.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtBARCODE;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENTAT;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn TRIGIA;
        private DevExpress.XtraGrid.Columns.GridColumn MANCC;
        private DevExpress.XtraGrid.Columns.GridColumn MAXX;
        private DevExpress.XtraGrid.Columns.GridColumn IDNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDISABLED;
        private System.Windows.Forms.ComboBox cboNhacungcap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboXuatXU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit spGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private System.Windows.Forms.ToolStripButton btnexport;
    }
}