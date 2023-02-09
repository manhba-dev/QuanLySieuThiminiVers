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

namespace STOCK
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "admin" && txtpass.Text == "1234")
            {
                MainFrom frm = new MainFrom();
                MessageBox.Show("dăng nhập thành công");
                frm.ShowDialog();
                
            }
            else {

                MessageBox.Show("Tài khoản Hoặc mật khẩu không chính xác!");
                    
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}