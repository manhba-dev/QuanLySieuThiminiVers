using BusinesssLayer;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STOCK
{
    public partial class MainFrom : DevExpress.XtraEditors.XtraForm
    {
        public MainFrom()
        {
            InitializeComponent();
        } 
        SYS_FUNC _func;
        private void MainFrom_Load(object sender, EventArgs e)
        {
            _func = new SYS_FUNC();
            leftMenu();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        void leftMenu()
        {
            int i = 0;
            var _lsParent = _func.getParent();
            foreach (var _pr in _lsParent)
            {
                NavBarGroup navGroup = new NavBarGroup(_pr.DESCRIPTION);
                navGroup.Tag = _pr.FUNC_CODE;
                navGroup.Name = _pr.FUNC_CODE;
                navGroup.ImageOptions.LargeImageIndex = i;
                i++;
                navMain.Groups.Add(navGroup);

                var _lsChild = _func.getChild(_pr.FUNC_CODE);
                foreach(var _ch in _lsChild)
                {
                    NavBarItem navItem = new NavBarItem(_ch.DESCRIPTION);
                    navItem.Tag = _ch.FUNC_CODE;
                    navItem.Name = _ch.FUNC_CODE;
                    navItem.ImageOptions.SmallImageIndex = 0;
                    navGroup.ItemLinks.Add(navItem);
                }
                navMain.Groups[navGroup.Name].Expanded = true;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void navMain_Click(object sender, EventArgs e)
        {

        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();
            switch (func_code)
            {
                case "DONVI":
                    {
                        frmDonVi frm = new frmDonVi();
                        frm.ShowDialog();
                        break;
                    }
                case "CONGTY":
                    {
                        frmCongTy frm = new frmCongTy();
                        frm.ShowDialog();
                        break;
                    }
                case "NHACUNGCAP":
                    {
                        frmNhaCungCap frm = new frmNhaCungCap();
                        frm.ShowDialog();
                        break;
                    }
                case "DONVITINH":
                    {
                        frmDonViTinh frm = new frmDonViTinh();
                        frm.ShowDialog();
                        break;
                       
                    }
                case "XUATXU":
                    {
                        frmXuatXu frm = new frmXuatXu();
                        frm.ShowDialog();
                        break;
                    }
                case "NHOMHH":
                    {
                        frmNhomHangHoa frm = new frmNhomHangHoa();
                        frm.ShowDialog();
                        break;
                    }
                case "HANGHOA":
                    {
                        frmHangHoa frm = new frmHangHoa();
                        frm.ShowDialog();
                        break;
                    }
                case "NHAPMUA":
                    {
                        frmNhapMua frm = new frmNhapMua();
                        frm.ShowDialog();
                        break;
                    }
            }
        }
    }
}
