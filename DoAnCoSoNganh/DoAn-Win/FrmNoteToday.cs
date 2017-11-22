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
    public partial class FrmNoteToday : DevExpress.XtraEditors.XtraForm
    {
        public static int idNote;

        public FrmNoteToday()
        {
            InitializeComponent();
           
        }

        private void _LoadNote()
        {
            string sel = "SELECT Id, TieuDe, NgayLap FROM Note where MSSV='" + frmLogin.id + "' AND abs(datediff(day,NgayThongBao,getdate()))<=1 and LanThongBao=0";

            DataTable table = new DataTable();
            table = Models.DataProvider.Instance.FillDataTable(sel, table);
            gcNote.DataSource = table;
        }

        private void _UpdateNote()
        {
           
            string update = "update Note set LanThongBao=1 where MSSV='" + frmLogin.id + "' AND abs(datediff(day,NgayThongBao,getdate()))<=1 and LanThongBao=0";
            if (Models.DataProvider.Instance.Exec_Tsql(update) == 0)
            {
                XtraMessageBox.Show("Lỗi Exec 123", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmNoteToday_Load(object sender, EventArgs e)
        {
            _LoadNote();
            _UpdateNote();
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
                XtraMessageBox.Show("Bạn chưa có ghi chú!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmNoteToday_Activated(object sender, EventArgs e)
        {
           
        }

       
    }
}