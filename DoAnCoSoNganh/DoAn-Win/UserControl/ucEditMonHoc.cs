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

namespace DoAn_Win.UserControl
{
    public partial class ucEditMonHoc : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEditMonHoc()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text != "")
            {
                gridCtrlTimMon.DataSource = "";

                Models.DataProvider.Instance.open();
                lblErrorTim.Text = "";
                string Tim = "select MaMon,TenMon,SoTinChi from MonHoc where MaMon like'%" + txtTim.Text + "%' or TenMon like'%" + txtTim.Text + "%'";

                DataTable data = new DataTable();
                data = Models.DataProvider.Instance.FillDataTable(Tim, data);
                if (data.Rows.Count > 0)
                {
                    lblErrorTim.Text = "";
                    gridCtrlTimMon.DataSource = data;
                }
                else
                    lblErrorTim.Text = "(*) Không tìm thấy môn học!";
            }
            else
            {
                gridCtrlTimMon.DataSource = "";
                lblErrorTim.Text = "(*) Mã môn học không được trống!";
            }
        }
        void loadMon()
        {
            gridCtrlThongtinmon.DataSource = "";
            Models.DataProvider.Instance.open();
            lblErrorTim.Text = "";
            string Tim = "select MaMon,TenMon,SoTinChi from MonHoc";

            DataTable data = new DataTable();
            data = Models.DataProvider.Instance.FillDataTable(Tim, data);
            gridCtrlThongtinmon.DataSource = data;
        }

        private void ucEditMonHoc_Load(object sender, EventArgs e)
        {
            loadMon();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;

            //txtmamon.Enabled = true;
            txtTenMon.Enabled = true;
            txtTinChi.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;

           // txtmamon.Enabled = false;
            txtTenMon.Enabled = false;
            txtTinChi.Enabled = false;
            txtmamon.ResetText();
            txtTinChi.ResetText();
            txtTenMon.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn xóa môn học.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string del = "exec spDeleteMonHoc '" + txtmamon.Text + "'";
                if (Models.DataProvider.Instance.Exec_Tsql(del)!=0)
                {
                    XtraMessageBox.Show("Xóa thành công môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMon();
                }
                else
                {
                    XtraMessageBox.Show("Lỗi Dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void click()
        {
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("text", gridCtrlThongtinmon.DataSource, "MaMon");
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("text", gridCtrlThongtinmon.DataSource, "TenMon");
            txtTinChi.DataBindings.Clear();
            txtTinChi.DataBindings.Add("text", gridCtrlThongtinmon.DataSource, "SoTinChi");



        }
        private void gridCtrlThongtinmon_MouseClick(object sender, MouseEventArgs e)
        {
            click();
        }

        private void txtTinChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridCtrlTimMon_MouseClick(object sender, MouseEventArgs e)
        {
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("text", gridCtrlTimMon.DataSource, "MaMon");
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("text", gridCtrlTimMon.DataSource, "TenMon");
            txtTinChi.DataBindings.Clear();
            txtTinChi.DataBindings.Add("text", gridCtrlTimMon.DataSource, "SoTinChi");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn cập nhật môn học.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "exec spUpdateMH '"+txtmamon.Text+"', N'"+txtTenMon.Text+"',"+txtTinChi.Text+"";

                if (Models.DataProvider.Instance.Exec_Tsql(update) != 0)
                {
                    XtraMessageBox.Show("Cập nhật thành công môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMon();
                }
                else
                {
                    XtraMessageBox.Show("Lỗi Dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
       
    }
}
