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

namespace DoAn_Win
{
    public partial class frmNote : DevExpress.XtraEditors.XtraForm
    {
        string id = frmLogin.id;

        public static int idNote;
        public frmNote()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            memoNoiDung.ReadOnly = false;
            memoTieuDe.ReadOnly = false;
            dtpNgayLap.ReadOnly = false;
            dtpThucHien.ReadOnly = false;
            nmrHours.Enabled = true;
            nmrMinute.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn thoát chi tiết ghi chú?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }


        private void LoadNote()
        {
            try
            {
                string sql = "SELECT TieuDe,GhiChu,NgayLap,NgayThongBao FROM Note WHERE MSSV='" + id + "' and id=" + idNote + "";
                DataTable table = new DataTable();
                table = Models.DataProvider.Instance.FillDataTable(sql, table);
                memoTieuDe.DataBindings.Clear();
                memoTieuDe.DataBindings.Add("text", table, "TieuDe");
                memoNoiDung.DataBindings.Clear();
                memoNoiDung.DataBindings.Add("text", table, "GhiChu");
                dtpNgayLap.DataBindings.Clear();
                dtpNgayLap.DataBindings.Add("datetime", table, "NgayLap");
                dtpThucHien.DataBindings.Clear();
                dtpThucHien.DataBindings.Add("datetime", table, "NgayThongBao");

                DateTime date = Convert.ToDateTime(table.Rows[0][3]);

                nmrHours.Value = (int)date.Hour;
                nmrMinute.Value = (int)date.Minute;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void frmNote_Load(object sender, EventArgs e)
        {
            LoadNote();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn chỉnh sửa ghi chú?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "UPDATE Note SET TieuDe=N'" + memoTieuDe.Text + "',GhiChu=N'" + memoNoiDung.Text + "',NgayLap=CONVERT(DATETIME,'" + dtpNgayLap.DateTime.ToString("dd/MM/yyyy") + "',103),NgayThongBao=CONVERT(DATETIME,'" + dtpThucHien.DateTime.ToString("dd/MM/yyyy")+" "+(int)nmrHours.Value +":"+(int)nmrMinute.Value+"',103) WHERE Id=" + idNote + " AND MSSV='" + id + "'";
                if (Models.DataProvider.Instance.Exec_Tsql(update) == 1)
                {
                    XtraMessageBox.Show("Chỉnh sửa thành công ghi chú!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNote();
                }
                else
                {
                    XtraMessageBox.Show("Chỉnh sửa không thành công (106)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn xóa ghi chú?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "DELETE FROM Note WHERE Id="+idNote+" AND MSSV='"+id+"'";
                if (Models.DataProvider.Instance.Exec_Tsql(delete) == 1)
                {
                    XtraMessageBox.Show("Xóa thành công ghi chú!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    XtraMessageBox.Show("Xóa không thành công (106)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(nmrMinute.Value>=60)
            {
                nmrMinute.Value = 0;
                nmrHours.Value += 1;
                if (nmrHours.Value >= 24)
                    nmrHours.Value = 0;
            }
            if (nmrHours.Value >= 24)
                nmrHours.Value = 0;
            
        }

        private void nmrHours_ValueChanged(object sender, EventArgs e)
        {
            if (nmrHours.Value >= 24)
                nmrHours.Value = 0;
        }
    }
}