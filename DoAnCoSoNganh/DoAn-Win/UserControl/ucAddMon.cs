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
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace DoAn_Win.UserControl
{
    public partial class ucAddMon : DevExpress.XtraEditors.XtraUserControl
    {

        private DataTable TableMonHoc;

        public ucAddMon()
        {
            InitializeComponent();
        }



        private void btnAddMon_Click(object sender, EventArgs e)
        {
            if (lblPath.Text != "")
            {
                string mamon = "";
                string tenmon = "";
                string sotinchi = "";

                #region Kết nối csdl

               
                SqlConnection conn = new SqlConnection(Models.DataProvider.Instance.sqlcon);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi kết nối!");
                }

                #endregion

                int demmautin = 0;
                int i = 0;
                int j = 0;
                // tạo mãng chứa stt các dòng lỗi
                int[] ERROR = new int[TableMonHoc.Rows.Count];
                int count;
                try
                {
                    do
                    {
                        String sql = String.Format("Exec spInsertMonHoc '{0}',N'{1}',{2}", mamon, tenmon, sotinchi);
                        mamon = TableMonHoc.Rows[i][1].ToString();
                        tenmon = TableMonHoc.Rows[i][2].ToString();
                        sotinchi = TableMonHoc.Rows[i][5].ToString();
                        //Kiểm tra nếu lỗi sẽ tự gián count=0;
                        try
                        {
                            SqlCommand command = new SqlCommand(sql, conn);
                            count = command.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            count = 0;
                        }
                        if (count != 0)
                        {
                            demmautin++;
                            i++;
                        }
                        else
                        {
                            ERROR[j] = i;
                            j++;
                            i++;
                        }
                    } while (i < TableMonHoc.Rows.Count);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã lỗi 105", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Lệnh in thông báo thành công hoặc lỗi

                string danhsach = "";
                for (int a = 0; a < ERROR.Length; a++)
                {
                    if (ERROR[a] != 0)
                        danhsach += ERROR[a].ToString() + " ,";
                }
                if (demmautin != 0 && danhsach != "")
                {
                    XtraMessageBox.Show("Thêm thành công " + (demmautin + 1) + "/" + (TableMonHoc.Rows.Count) + " môn học. Số thứ tự mẫu tin lỗi " + danhsach);
                }
                else if (demmautin != 0)
                {
                    XtraMessageBox.Show("Thêm thành công " + (demmautin + 1) + "/" + (TableMonHoc.Rows.Count));
                }
                else
                    XtraMessageBox.Show("Lỗi dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng Ấn Browse để chọn file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBro_Click(object sender, EventArgs e)
        {
            #region Tạo hộp thoại file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(Tệp Excel)|*.xls;*.xlsx";
            ofd.Multiselect = false; // chỉ được chọn 1 file
            ofd.RestoreDirectory = true; //Nhớ đường dẫn
            ofd.Title = "Chọn file Excel";
            ofd.ShowDialog();
            #endregion

            if (ofd.FileName != "")
            {
                lblPath.Text = ofd.FileName.ToString();
                //Tạo mới đối tượng excel
                Excel.Application app = new Excel.Application();
                //Mở tệp excel
                Excel.Workbook wb = app.Workbooks.Open(ofd.FileName);

                #region Lấy dữ liệu ra
                try
                {

                    Excel._Worksheet sheet = wb.Sheets[1];  //Lấy ra sheet thứ 1

                    Excel.Range range = sheet.UsedRange;  // Lấy toàn bộ vùng dữ liệu

                    //Tạo 2 biến lưu số dòng cột.

                    int cols = range.Columns.Count;
                    int rows = range.Rows.Count;
                    TableMonHoc = new DataTable();
                    //Tạo ra các column
                    for (int i = 1; i <= cols; i++)
                    {
                        TableMonHoc.Columns.Add(range.Cells[i][1].Value.ToString());
                    }
                    //Thêm dữ liệu vào column
                    for (int r = 2; r <= rows; r++) //Thêm dữ liệu từ dòng thứ 2 (dòng thứ 1 chứa tiêu đề)
                    {
                        DataRow dr = TableMonHoc.NewRow(); //Tạo mới 1 row
                        int cot = 0; //Tạo biến đếm cho cột khi thiêm xong 1 dòng cột sẽ tự reset về 0
                        for (int c = 1; c <= cols; c++)
                        {
                            dr[cot] = range.Cells[r, c].Value.ToString();
                            cot++;
                        }
                        TableMonHoc.Rows.Add(dr);
                    }
                    dtgvwMonHoc.DataSource = TableMonHoc;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi file " + ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else

                XtraMessageBox.Show("Bạn chưa chọn file", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}