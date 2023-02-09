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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        CONGTY _congty = new CONGTY();
        bool _them;
        string _macty;
        void loadData()
        {
            gcDanhSach.DataSource = _congty.getALL();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void showHidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            toolStripSeparator1.Visible = t;
            toolStripSeparator2.Visible = t;
            toolStripSeparator3.Visible = t;
            toolStripSeparator4.Visible = t;
            toolStripSeparator5.Visible = !t;
            toolStripSeparator6.Visible = !t;
            toolStripSeparator7.Visible = t;
        }
        void _reset()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtFax.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            loadData();
            showHidecontrol(true);
            txtMa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            showHidecontrol(false);
            _them = true;
            txtMa.Enabled = true;
            _reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHidecontrol(false);
            _them = false;
            txtMa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa không","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                _congty.delete(_macty);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                if (txtMa.Text == "" || txtTen.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtFax.Text == "" ) {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tb_CONGTY cty = new tb_CONGTY();
                    cty.MACTY = txtMa.Text;
                    cty.TENCTY = txtTen.Text;
                    cty.DIENTHOAI = txtDienThoai.Text;
                    cty.DIACHI = txtDiaChi.Text;
                    cty.EMAIL = txtEmail.Text;
                    cty.FAX = txtFax.Text;
                    cty.DISABLED = chbDISABLED.Checked;
                    _congty.add(cty);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                tb_CONGTY cty = _congty.getItem(_macty);
                cty.TENCTY = txtTen.Text;
                cty.DIENTHOAI = txtDienThoai.Text;
                cty.DIACHI = txtDiaChi.Text;
                cty.EMAIL = txtEmail.Text;
                cty.FAX = txtFax.Text;
                cty.DISABLED = chbDISABLED.Checked;
                _congty.update(cty);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _them = false;
            loadData();
            showHidecontrol(true);
            _reset();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHidecontrol(true);
            txtMa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _macty = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MACTY").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                chbDISABLED.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        //private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        //{
        //    if(e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString())== true)
        //    {
        //        Image ing = Properties.Resources._38999_exit_icon;
        //        e.Graphics.DrawImage(ing, e.Bounds.X, e.Bounds.Y);
        //        e.Handled = true;
        //    }
        //}
    }
}