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
using BusinesssLayer;
using DataLayer;

namespace STOCK
{
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmDonVi()
        {
            InitializeComponent();
        }
        DONVI _donvi = new DONVI();
        CONGTY _congty = new CONGTY();
        bool _them;
        string _madvi;
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            _donvi = new DONVI();
            _congty = new CONGTY();
            loadCongTy();
            showHideControl(true);
            _enabled(false);
            txtMa.Enabled = false;
            cboCty.SelectedIndexChanged += cboCty_SelectedIndexChanged;
            loadDviByCty();
            

        }
        void _enabled(bool t)
        {
            txtTen.Enabled = t;
            txtDienThoai.Enabled = t;
            txtFax.Enabled = t;
            txtEmail.Enabled = t;
            txtDiaChi.Enabled = t;
            chbDISABLED.Enabled = t;
            chbKho.Enabled = t;
            txtKiHieu.Enabled = t;

        }
        void _reset()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDienThoai.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtKiHieu.Text = "";
            chbKho.Checked = false;
            chbDISABLED.Checked = false;

        }
        void loadCongTy()
        {
            cboCty.DataSource = _congty.getALL();
            cboCty.DisplayMember = "TENCTY";
            cboCty.ValueMember = "MACTY";
        }
         void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }
        void loadDviByCty()
        {
            gcDanhSach.DataSource = _donvi.getALL();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void cboCty_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDviByCty();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enabled(true);
            _reset();
            txtMa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enabled(true);
            showHideControl(false);
            txtMa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _donvi.delete(_madvi);
            }
            loadDviByCty();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_DONVI dvi = new tb_DONVI();
                dvi.MADVI = txtMa.Text;
                dvi.MACTY = cboCty.SelectedValue.ToString();
                dvi.TENDVI = txtTen.Text;
                dvi.DIACHI = txtDiaChi.Text;
                dvi.DIENTHOAI = txtDienThoai.Text;
                dvi.FAX = txtFax.Text;
                dvi.EMAIL = txtEmail.Text;
                dvi.DISABLED = chbDISABLED.Checked;
                dvi.KHO = chbKho.Checked;
                dvi.KYHIEU = txtKiHieu.Text;
                _donvi.add(dvi);
            }
            else
            {
                tb_DONVI dvi =  _donvi.getItem(_madvi);
                dvi.MACTY = cboCty.SelectedValue.ToString();
                dvi.TENDVI = txtTen.Text;
                dvi.DIACHI = txtDiaChi.Text;
                dvi.DIENTHOAI = txtDienThoai.Text;
                dvi.FAX = txtFax.Text;
                dvi.EMAIL = txtEmail.Text;
                dvi.DISABLED = chbDISABLED.Checked;
                dvi.KHO = chbKho.Checked;
                dvi.KYHIEU = txtKiHieu.Text;
                _donvi.update(dvi);
            }
            _them = false;
            loadDviByCty();
            _enabled(false);
            showHideControl(true);
            txtMa.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enabled(false);
            txtMa.Enabled = false;
            _reset();
            loadDviByCty();
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if(e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString()) == true){
            //    Image img = Properties.Resources.211652_close_icon
            //    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
            //    e.Handled = true;
            //}
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _madvi = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
                cboCty.SelectedValue = gvDanhSach.GetFocusedRowCellValue("MACTY");
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MADVI").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENDVI").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                chbDISABLED.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
                chbKho.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("KHO").ToString());
                txtKiHieu.Text = gvDanhSach.GetFocusedRowCellValue("KYHIEU").ToString();
            }
        }
    }
}