using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAn_Win
{
    public partial class ucEditPass : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEditPass()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn cập nhật thông tin tài khoản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                
                string query = "select Pass from SinhVien where MSSV='" + frmLogin.id + "'";
               
                DataTable table = new DataTable();
                table = Models.DataProvider.Instance.FillDataTable(query, table);
                string pass = table.Rows[0][0].ToString();
                if (txtpassold.Text != pass)
                    lblErrorPassOld.Text = "*  Mật khẩu không đúng.";
                else
                {
                    if (txtpassnew.Text == txtpassnew2.Text)
                    {
                        try
                        {
                            
                            string update = "update SinhVien set Pass='" + txtpassnew.Text + "' where MSSV='" + frmLogin.id + "'";
                            if (Models.DataProvider.Instance.Exec_Tsql(update) == 1)
                                XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                            XtraMessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
            }
        }

        private void txtpassnew2_EditValueChanged(object sender, EventArgs e)
        {
            if (sinhvien.ktmatkhau(txtpassnew.Text, txtpassnew2.Text))
                lblErrorPassNew.Text = "";
            else
                lblErrorPassNew.Text = "Mật khẩu không khớp.";
        }


        private void ucEditPass_Load(object sender, EventArgs e)
        {
            txtuse.Text = frmLogin.id.ToString();
        }
    }
}