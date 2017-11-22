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
   
    public partial class ucThongTin : DevExpress.XtraEditors.XtraUserControl
    {
        string id = frmLogin.id;
        public ucThongTin()
        {
            InitializeComponent();
            LoadAccount();
            loadThongtindiem();
            LoadThongKe();
            LoadHocKy();
        }
         
        
       
        public void loadThongtindiem()
        {
            Models.DataProvider.Instance.open();

            string query = "select Diem.MaMon,TenMon,SoTinChi,Diem_10,Diem_40,Diem_50,He_10,DiemChu,He_4,HocKy from MonHoc,Diem where Diem.MaMon=MonHoc.MaMon and MSSV='" +frmLogin.id+ "'";

            DataTable data = new DataTable();
            data = Models.DataProvider.Instance.FillDataTable(query, data);
            dgvwThongtin.DataSource = data;
        }
    
        void LoadAccount()
        {
            Models.DataProvider.Instance.open();

            string query = "select * from SinhVien where MSSV='" + frmLogin.id + "'";

            
            DataTable data = new DataTable();
            data = Models.DataProvider.Instance.FillDataTable(query, data);

            lblMSSV.Text = data.Rows[0][0].ToString();
            lblHoTen.Text = data.Rows[0][2].ToString();
            lblNgaySinh.Text = data.Rows[0][3].ToString();           
            lblLop.Text = data.Rows[0][4].ToString();
            lblNganh.Text = data.Rows[0][5].ToString();
            lblHDT.Text = data.Rows[0][6].ToString();
            lblkhoa.Text = data.Rows[0][7].ToString();

        }

        public void LoadThongKe()
        {
            int a = 0;
            int bp = 0;
            int b = 0;
            int c = 0;
            int cp = 0;
            int dp = 0;
            int d = 0;
            int f = 0;

            Models.DataProvider.Instance.open();
            string Select = "select He_10,He_4,DiemChu,SoTinChi from Diem,MonHoc where Diem.MaMon=MonHoc.MaMon and MSSV='" + frmLogin.id + "'";
            
            DataTable tableThongke = new DataTable();
            tableThongke = Models.DataProvider.Instance.FillDataTable(Select, tableThongke);

            //TÍNH TỔNG TÍN CHỈ ĐÃ ĐẠT//
            int tongtinchi=0;
            for (int i = 0; i < tableThongke.Rows.Count;i++ )
            {
                string diemchu=tableThongke.Rows[i][2].ToString();
                if(diemchu!="F")
                {
                    tongtinchi += Convert.ToInt32(tableThongke.Rows[i][3]);
                }
            }
            lblTinChi.Text = tongtinchi.ToString();

            //THỐNG KÊ SINH VIÊN ĐÃ HỌC NĂM

            if (tongtinchi < 38)
                lblSVnam.Text = "Thứ nhất";
            else if(tongtinchi<=75)
                lblSVnam.Text = "Thứ hai";
            else if(tongtinchi <=113)
                lblSVnam.Text = "Thứ ba";
            else if(tongtinchi<=150)
                lblSVnam.Text = "Thứ tư";
            else
                lblSVnam.Text = "Thứ năm";
            //THỐNG KÊ SỐ ĐIỂM ĐÃ HỌC//
                foreach (DataRow row in tableThongke.Rows)
                {
                    if (row[2].ToString() == "A")
                        a++;
                    else if (row[2].ToString() == "B+")
                        bp++;
                    else if (row[2].ToString() == "B")
                        b++;
                    else if (row[2].ToString() == "C+")
                        cp++;
                    else if (row[2].ToString() == "C")
                        c++;
                    else if (row[2].ToString() == "D+")
                        dp++;
                    else if (row[2].ToString() == "D")
                        d++;
                    else
                        f++;
                }
            lblA.Text = a.ToString();
            lblB.Text = b.ToString();
            lblC.Text = c.ToString();
            lblD.Text = d.ToString();
            lblF.Text = f.ToString();
            lblDplus.Text = dp.ToString();
            lblCplus.Text = cp.ToString();
            lblBplus.Text = bp.ToString();

            //THỐNG KÊ TRUNG BÌNH CHUNG TÍCH LŨY

            string tbt = "SELECT d.He_4, mh.SoTinChi FROM Diem AS d, MonHoc AS mh WHERE d.MaMon=mh.MaMon AND d.DiemChu!='F' AND d.MSSV='" + id + "'";
            DataTable tabletbt = new DataTable();
            tabletbt = Models.DataProvider.Instance.FillDataTable(tbt, tabletbt);
            decimal TBCTichLuy = 0M;
            foreach (DataRow row in tabletbt.Rows)
            {
                TBCTichLuy += Convert.ToDecimal(row[0]) * Convert.ToDecimal(row[1]);
            }
            try
            {
                TBCTichLuy = Math.Round((TBCTichLuy / tongtinchi), 2, MidpointRounding.AwayFromZero);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Tài khoản bạn chưa có môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
            lblTBTichLuy.Text = TBCTichLuy.ToString();

            if (TBCTichLuy >= 3.60M)
                lblHocLuc.Text = "Xuất sắc";
            else if (TBCTichLuy >= 3.20M)
                lblHocLuc.Text = "Giỏi";
            else if (TBCTichLuy >= 2.5M)
                lblHocLuc.Text = "Khá";
            else if (TBCTichLuy >= 2M)
                lblHocLuc.Text = "Trung Bình";
            else
                lblHocLuc.Text = "Kém";


            //THỐNG KÊ SỐ MÔN HỌC

            int count = 0;
            string sqlMonHoc = "SELECT d.DiemChu FROM Diem AS d WHERE d.MSSV='" + id + "'";
            DataTable tableMonHoc = new DataTable();
            tableMonHoc = Models.DataProvider.Instance.FillDataTable(sqlMonHoc, tableMonHoc);
            int total = tableMonHoc.Rows.Count;
            foreach(DataRow row in tableMonHoc.Rows)
            {
                if (row[0].ToString() != "F")
                    count++;
            }
            lblMonDat.Text = count.ToString();
            lblMonRot.Text = (total - count).ToString();
        }
     

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadThongtindiem();
            LoadThongKe();
            LoadAccount();
            cbbHocKy.Properties.Items.Clear();
            LoadHocKy();
        }

        void LoadHocKy()
        {
            string hocky = "select distinct HocKy from Diem where MSSV='"+frmLogin.id+"'";
            DataTable table = new DataTable();
            table = Models.DataProvider.Instance.FillDataTable(hocky, table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbbHocKy.Properties.Items.Add(table.Rows[i][0]);
            }
            cbbHocKy.SelectedIndex = 0;
        }
        void LoadDiemTrungBinh()
        {
            try
            {
                DataTable table = new DataTable();
                string select = "select HocKy,He_10,He_4,SoTinChi  from Diem,MonHoc where Diem.MaMon=MonHoc.MaMon  and MSSV='" + frmLogin.id + "'";
                table = Models.DataProvider.Instance.FillDataTable(select, table);
                decimal tongHe10 = 0M;
                decimal tongHe4 = 0M;
                int tongtinchi = 0;
                decimal DiemTrungBinhHe10;
                decimal DiemTrungBinhHe4;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string hocky = table.Rows[i][0].ToString();
                    if (cbbHocKy.Text == hocky)
                    {
                        decimal he10 = Convert.ToDecimal(table.Rows[i][1]);
                        decimal he4 = Convert.ToDecimal(table.Rows[i][2]);
                        int tinchi = Convert.ToInt32(table.Rows[i][3]);
                        tongHe10 += he10 * tinchi;
                        tongHe4 += he4 * tinchi;
                        tongtinchi += tinchi;
                    }
                }

                DiemTrungBinhHe10 = Math.Round((tongHe10 / tongtinchi), 2, MidpointRounding.AwayFromZero);
                DiemTrungBinhHe4 = Math.Round((tongHe4 / tongtinchi), 2, MidpointRounding.AwayFromZero);
                lblDiemTrungBinh.Text = DiemTrungBinhHe10.ToString();

                lblDiemHe4.Text = "( " + DiemTrungBinhHe4.ToString() + " )";


                if (DiemTrungBinhHe4 >= 3.60M)
                    lblXepLoai.Text = "Xuất sắc";
                else if (DiemTrungBinhHe4 >= 3.20M)
                    lblXepLoai.Text = "Giỏi";
                else if (DiemTrungBinhHe4 >= 2.5M)
                    lblXepLoai.Text = "Khá";
                else if (DiemTrungBinhHe4 >= 2M)
                    lblXepLoai.Text = "Trung Bình";
                else
                    lblXepLoai.Text = "Kém";
            
            }
            catch (Exception ex)
            {

                lblDiemHe4.Text = "0";
                lblDiemTrungBinh.Text = "0";
                lblHocLuc.Text = "";
            }
            
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiemTrungBinh();
        }

        private void lblMonRot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(lblMonRot.Text) != 0)
            {
                frmChiTietMonHoc.DiemChu = "F";
                frmChiTietMonHoc f = new frmChiTietMonHoc();
                f.Show();
            }
        }
    }
}