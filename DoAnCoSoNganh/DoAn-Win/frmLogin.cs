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
using System.Threading;
using System.Data.SqlClient;

namespace DoAn_Win
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static string id;
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Models.DataProvider.Instance.open();
                string select = "select MSSV, Pass from SinhVien where MSSV='" + txtUser.Text + "' and Pass='" + txtPass.Text + "'";          
                DataTable data = new DataTable();
                data = Models.DataProvider.Instance.FillDataTable(select, data);
                if (data.Rows.Count > 0)
                {
                    id = txtUser.Text;
                    this.Dispose();

                   
                }
                else
                {
                    if (txtUser.Text == "")
                        lblErrorUse.Text = "Tên tài khoản không được để trống";
                    else
                        lblErrorUse.Text = "";
                    if (txtPass.Text == "")
                        lblErrorPass.Text = "Mật khẩu không được để trống";
                    else
                        lblErrorPass.Text = "";
                    lblErrorLogin.Text = "Tên tài khoản hoặc mật khẩu không chính xác.";
                }
                
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Mã lỗi 104", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


       
    }
}