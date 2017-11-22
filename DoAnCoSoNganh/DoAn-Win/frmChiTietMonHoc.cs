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
    public partial class frmChiTietMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public static string DiemChu;
        public frmChiTietMonHoc()
        {
            InitializeComponent();
        }

        private void frmChiTietMonHoc_Load(object sender, EventArgs e)
        {
            string query = "select Diem.MaMon,TenMon,SoTinChi,Diem_10,Diem_40,Diem_50,He_10,DiemChu,He_4,HocKy from MonHoc,Diem where Diem.MaMon=MonHoc.MaMon and MSSV='" + frmLogin.id + "' and DiemChu='"+DiemChu+"'";
            DataTable data = new DataTable();
            data = Models.DataProvider.Instance.FillDataTable(query, data);
            dgvwThongtin.DataSource = data;
        }
    }
}