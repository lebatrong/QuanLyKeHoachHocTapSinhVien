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
    public partial class ucNote : DevExpress.XtraEditors.XtraUserControl
    {
        public static int idNote;
        string id = frmLogin.id;
        public ucNote()
        {
            InitializeComponent();
            LoadNote();
        }


        private void LoadNote()
        {
            string select = "SELECT Id, TieuDe, NgayLap FROM Note WHERE MSSV='"+id+"'";
            DataTable tableNote = new DataTable();
            tableNote = Models.DataProvider.Instance.FillDataTable(select, tableNote);
            gcNote.DataSource = tableNote;
            
        }
        private void btnAdNote_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnReset.Enabled = true;
           // btnSave.Enabled = true;
            txtTieuDe.Enabled = true;
            MemoNoiDung.Enabled = true;
            dateTime.Enabled = true;
            btnAdNote.Enabled = false;
            nmrHours.Enabled = true;
            nmrMinute.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdNote.Enabled = true;
            btnCancel.Enabled = false;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            txtTieuDe.Enabled = false;
            MemoNoiDung.Enabled = false;
            dateTime.Enabled = false;
            nmrHours.Enabled = false;
            nmrMinute.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTieuDe.ResetText();
            MemoNoiDung.ResetText();
            dateTime.DateTime = DateTime.Now;
        }

        private void ucNote_Load(object sender, EventArgs e)
        {
            DeleteNote();
            LoadNote();
            dateTime.DateTime = DateTime.Now;
        }


        private void DeleteNote()
        {
            string del = "delete from Note where MSSV='"+frmLogin.id+"' and LanThongBao=1 and datediff(day,NgayThongBao,getdate())<0";
            Models.DataProvider.Instance.Exec_Tsql(del);
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(XtraMessageBox.Show("Bạn muốn thêm mới ghi chú?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
               
                if (txtTieuDe.Text!="" && MemoNoiDung.Text!="" && txtTieuDe.Text.Trim()!="")
                {
                    
                    string note = "exec spInsertNote '"+frmLogin.id+"',N'"+txtTieuDe.Text+"',N'"+MemoNoiDung.Text+"','"+ dateTime.DateTime.ToString("dd/MM/yyyy") + " " + (int)nmrHours.Value + ":" + (int)nmrMinute.Value +"'";
                    
                    if (Models.DataProvider.Instance.Exec_Tsql(note) == 1)
                    {
                        LoadNote();
                        XtraMessageBox.Show("Thêm ghi chú thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Lỗi dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                    XtraMessageBox.Show("Dữ liệu không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gcNote_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                frmNote.idNote = (int)gvNote.GetRowCellValue(gvNote.FocusedRowHandle, col_STT);
                frmNote note = new frmNote();
                note.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Bạn chưa có ghi chú!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (nmrMinute.Value >= 60)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNote();
        }

        private void txtTieuDe_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTieuDe.Text == "" || MemoNoiDung.Text == "")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void txtTieuDe_Leave(object sender, EventArgs e)
        {
            if (txtTieuDe.Text == "" || MemoNoiDung.Text == "")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void MemoNoiDung_EditValueChanged(object sender, EventArgs e)
        {
            if (MemoNoiDung.Text == "" || txtTieuDe.Text == "")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void MemoNoiDung_Leave(object sender, EventArgs e)
        {
            if (MemoNoiDung.Text == "" || txtTieuDe.Text=="")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }
    }
}
