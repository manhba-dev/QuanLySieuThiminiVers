using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataLayer;
using BusinesssLayer;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace STOCK
{
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        XuatXu _xuatxu = new XuatXu();
        NHACUNGCAP _nhacungcap = new NHACUNGCAP();
        DONVITINH _dvt = new DONVITINH();
        NHOMHANGHOA _nhomhanghoa = new NHOMHANGHOA();
        HANGHOA _hanghoa = new HANGHOA();
        bool _them;
        string _barcode;
        tb_SYS_SEQUENCE _seq;
        SYS_SEQUENCE _sysSeq = new SYS_SEQUENCE();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        void showHidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            btnexport.Visible = t;
            toolStripSeparator1.Visible = t;
            toolStripSeparator2.Visible = t;
            toolStripSeparator3.Visible = t;
            toolStripSeparator4.Visible = t;
            toolStripSeparator5.Visible = !t;
            toolStripSeparator6.Visible = !t;
            toolStripSeparator7.Visible = t;
        }
        public void _edcontrol(bool t)
        {
            txtTen.Enabled = t;
            txtTenTat.Enabled = t;
            txtMota.Enabled = t;
            cboDVT.Enabled = t;
            spGia.Enabled = t;
            cboNhacungcap.Enabled = t;
            cboXuatXU.Enabled = t;
            chkDISABLED.Enabled = t;
        }
        public void _reset()
        {
            txtBARCODE.Clear();
            txtTen.Clear();
            txtMota.Clear();
            txtTenTat.Clear();
        }
        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHidecontrol(false);
            _edcontrol(true);
            _reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHidecontrol(false);
            _edcontrol(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc muốn xóa không?","thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                _hanghoa.delete(_barcode);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                 tb_HANGHOA hh = new tb_HANGHOA();
                _seq = _sysSeq.getItem("HH@" + DateTime.Now.Year.ToString() + "@" + cboNhom.SelectedValue.ToString());
                 if (_seq == null)
                 {
                    _seq = new tb_SYS_SEQUENCE();
                    _seq.SEQNAME = "HH@" + DateTime.Now.Year.ToString() + "@" + cboNhom.SelectedValue.ToString();
                    _seq.SEQVALUE = 1;
                    _sysSeq.add(_seq);
                 }
                
                hh.BARCODE = BarcodeEAN13.BuidEan13(DateTime.Now.Year.ToString() + cboNhom.SelectedValue.ToString() + _seq.SEQVALUE.Value.ToString("0000000"));
                hh.TENHH = txtTen.Text;
                hh.TENTAT = txtTenTat.Text;
                hh.IDNHOM = int.Parse(cboNhom.SelectedValue.ToString());
                hh.MOTA = txtMota.Text;
                hh.MANCC = int.Parse(cboNhacungcap.SelectedValue.ToString());
                hh.MAXX = int.Parse(cboXuatXU.SelectedValue.ToString());
                hh.DVT = cboDVT.Text;
                hh.DISABLED = chkDISABLED.Checked;
                hh.CREATED_DATE = DateTime.Now;
                hh.CREATED_BY = 1;
                hh.DONGIA = float.Parse(spGia.Text);
                var _hh = _hanghoa.add(hh);
                _sysSeq.update(_seq);
                txtBARCODE.Text = _hh.BARCODE;
                MessageBox.Show(hh.BARCODE);
            }
            else
            {
                tb_HANGHOA hh = new tb_HANGHOA();
                hh.BARCODE = _barcode;
                hh.TENHH = txtTen.Text;
                hh.TENTAT = txtTenTat.Text;
                hh.IDNHOM = int.Parse(cboNhom.SelectedValue.ToString());
                hh.MOTA = txtMota.Text;
                hh.MANCC = int.Parse(cboNhacungcap.SelectedValue.ToString());
                hh.MAXX = int.Parse(cboXuatXU.SelectedValue.ToString());
                hh.DVT = cboDVT.Text;
                hh.DISABLED = chkDISABLED.Checked;
                hh.DONGIA = float.Parse(spGia.Text);
                var _hh = _hanghoa.update(hh);
                txtBARCODE.Text = _hh.BARCODE;
                
            }
            _them = false;
            showHidecontrol(true);
            loadData();
           
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            showHidecontrol(true);
            _reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            showHidecontrol(true);
            loadData();
            loadNHH();
            loadDVT();
            loadDataXuatxu();
            loadDataNCC();
            //cboNhom.SelectedIndexChanged += cboNhom_SelectedIndexChanged;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _hanghoa.getlist();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadDataXuatxu()
        {
            cboXuatXU.DataSource = _xuatxu.getList();
            cboXuatXU.DisplayMember = "TEN";
            cboXuatXU.ValueMember = "ID";
        }
        void loadDataNCC()
        {
            cboNhacungcap.DataSource = _nhacungcap.getALL();
            cboNhacungcap.DisplayMember = "TENNCC";
            cboNhacungcap.ValueMember = "MANCC";
        }
        void loadDVT()
        {
            cboDVT.DataSource = _dvt.getList();
            cboDVT.DisplayMember = "TEN";
            cboDVT.ValueMember = "ID";
        }
        void loadNHH()
        {
            cboNhom.DataSource = _nhomhanghoa.getList();
            cboNhom.DisplayMember = "TENNHOM";
            cboNhom.ValueMember = "IDNHOM";
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _barcode = gvDanhSach.GetFocusedRowCellValue("BARCODE").ToString();
                txtBARCODE.Text = gvDanhSach.GetFocusedRowCellValue("BARCODE").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENHH").ToString();
                txtTenTat.Text = gvDanhSach.GetFocusedRowCellValue("TENTAT").ToString();
                txtMota.Text = gvDanhSach.GetFocusedRowCellValue("MOTA").ToString();
                cboNhacungcap.SelectedValue = gvDanhSach.GetFocusedRowCellValue("MANCC");
                cboXuatXU.SelectedValue = gvDanhSach.GetFocusedRowCellValue("MAXX");
                cboDVT.Text = gvDanhSach.GetFocusedRowCellValue("DVT").ToString();
                cboNhom.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDNHOM");
                spGia.Text = gvDanhSach.GetFocusedRowCellValue("DONGIA").ToString();
                chkDISABLED.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gcDanhSach.ExportToXlsx(path, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG });
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        //private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    gcDanhSach.DataSource = _hanghoa.getListByNhom(int.Parse(cboNhom.SelectedValue.ToString()));
        //}
    }
}