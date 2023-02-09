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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        NHACUNGCAP _nhacungcap = new NHACUNGCAP();
        bool _them;
        int _mancc;
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadData();
            showHidecontrol(true);
            txtMa.Enabled = false;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhacungcap.getALL();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            showHidecontrol(false);
            _them = true;
            txtMa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHidecontrol(false);
            _them = false;
            txtMa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhacungcap.delete(_mancc);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_NHACUNGCAP ncc = new tb_NHACUNGCAP();
                ncc.TENNCC = txtTen.Text;
                ncc.DIENTHOAI = txtDienThoai.Text;
                ncc.DIACHI = txtDiaChi.Text;
                ncc.EMAIL = txtEmail.Text;
                ncc.FAX = txtFax.Text;
                ncc.DISABLED = chbDISABLED.Checked;
                _nhacungcap.add(ncc);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_NHACUNGCAP cty = _nhacungcap.getItem(_mancc);
                cty.TENNCC = txtTen.Text;
                cty.DIENTHOAI = txtDienThoai.Text;
                cty.DIACHI = txtDiaChi.Text;
                cty.EMAIL = txtEmail.Text;
                cty.FAX = txtFax.Text;
                cty.DISABLED = chbDISABLED.Checked;
                _nhacungcap.update(cty);
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
            if (gvDanhSach.RowCount > 0)
            {
                _mancc = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("MANCC").ToString());
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("MANCC").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENNCC").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtFax.Text = gvDanhSach.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
                chbDISABLED.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}