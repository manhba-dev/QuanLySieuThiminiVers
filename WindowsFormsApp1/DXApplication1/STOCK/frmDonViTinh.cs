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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }
        DONVITINH _donvitinh = new DONVITINH();
        bool _them;
        int _ID;
        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            loadData();
            showHidecontrol(true);
            txtMa.Enabled = false;
        }
        void showHidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            toolStripSeparator1.Visible = t;
            toolStripSeparator2.Visible = t;
            toolStripSeparator3.Visible = t;
            toolStripSeparator4.Visible = t;
            toolStripSeparator6.Visible = !t;
            toolStripSeparator7.Visible = t;
        }
        void _reset()
        {
            txtMa.Clear();
            txtTen.Clear();
            
        }
        void loadData()
        {
            gcDanhSach.DataSource = _donvitinh.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_DVT dvt = new tb_DVT();
                dvt.TEN = txtTen.Text;
                _donvitinh.add(dvt);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_DVT dvt = _donvitinh.getItem(_ID);
                dvt.TEN = txtTen.Text;
               
                _donvitinh.update(dvt);
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
                _ID = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtMa.Text = gvDanhSach.GetFocusedRowCellValue("ID").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TEN").ToString();
            }
        }
    }
}