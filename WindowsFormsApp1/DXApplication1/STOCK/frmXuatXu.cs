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

namespace STOCK
{
    public partial class frmXuatXu : DevExpress.XtraEditors.XtraForm
    {
        public frmXuatXu()
        {
            InitializeComponent();
        }
        XuatXu _xuatxu = new XuatXu();
        bool _them;
        int _ID;
        private void frmXuatXu_Load(object sender, EventArgs e)
        {
            loadData();
            showHidecontrol(true);
            txtMa.Enabled = false;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _xuatxu.getList();
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
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _ID = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("ID").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TEN").ToString();
                chbDISABLED.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _reset();
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
                _xuatxu.delete(_ID);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_XUATXU xx = new tb_XUATXU();
                xx.TEN = txtTen.Text;
                xx.DISABLED = chbDISABLED.Checked;
                _xuatxu.add(xx);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_XUATXU xx = _xuatxu.getItem(_ID);
                xx.TEN = txtTen.Text;
                xx.DISABLED = chbDISABLED.Checked;
                _xuatxu.update(xx);
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
    }
}