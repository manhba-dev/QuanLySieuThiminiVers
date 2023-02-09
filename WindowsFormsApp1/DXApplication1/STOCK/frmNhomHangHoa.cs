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
    public partial class frmNhomHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHangHoa()
        {
            InitializeComponent();
        }
        NHOMHANGHOA _nhomhanghoa = new NHOMHANGHOA();
        bool _them;
        int _ID;
        private void frmNhomHangHoa_Load(object sender, EventArgs e)
        {
            loadData();
            showHidecontrol(true);
            txtMa.Enabled = false;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhomhanghoa.getList();
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
            txtGHICHU.Clear();
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
                _nhomhanghoa.delete(_ID);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_NHOMHH xx = new tb_NHOMHH();
                xx.TENNHOM = txtTen.Text;
                xx.GHICHU = txtGHICHU.Text;
                xx.DISABLED = chbDISABLED.Checked;
                _nhomhanghoa.add(xx);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_NHOMHH xx = _nhomhanghoa.getItem(_ID);
                xx.TENNHOM = txtTen.Text;
                xx.GHICHU = txtGHICHU.Text;
                xx.DISABLED = chbDISABLED.Checked;
                _nhomhanghoa.update(xx);
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
                _ID = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("IDNHOM").ToString());
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("IDNHOM").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENNHOM").ToString();
                txtGHICHU.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                chbDISABLED.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}