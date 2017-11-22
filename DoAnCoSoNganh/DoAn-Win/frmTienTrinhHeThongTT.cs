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
    public partial class frmTienTrinhHeThongTT : DevExpress.XtraEditors.XtraForm
    {
        public frmTienTrinhHeThongTT()
        {
            InitializeComponent();
        }
        private void LoadTienTrinh1Trong2()
        {
            DataTable tbTienTrinh = new DataTable();
            string query = "exec sp_GetTienTrinh '" + frmLogin.id + "'";
            tbTienTrinh = Models.DataProvider.Instance.FillDataTable(query, tbTienTrinh);

            //Thay đổi trạng thái môn học thành đã đạt
            Image imgDD = Image.FromFile("MonDaDat.png"); // image môn đã đạt
            Image imgCD = Image.FromFile("MonChuaDat.png");  // image môn chưa đạt

            #region Kiểm tra một trong 2 môn
            for (int i = 0; i < tbTienTrinh.Rows.Count; i++)
            {
                if (tbTienTrinh.Rows[i][0].ToString() == "CT1105" || tbTienTrinh.Rows[i][0].ToString() == "CT1106")
                {
                    pic2CT1105.Visible = true;
                    //Kiểm tra xem môn đã đạt hay chưa
                    if (tbTienTrinh.Rows[i][4].ToString() == "F")
                        pic2CT1105.Image = imgCD;
                    else
                        pic2CT1105.Image = imgDD;

                }

                else if (tbTienTrinh.Rows[i][0].ToString() == "CB1114" || tbTienTrinh.Rows[i][0].ToString() == "CB1115")
                {
                    pic2CB1114.Visible = true;
                    //Kiểm tra xem môn đã đạt hay chưa
                    if (tbTienTrinh.Rows[i][4].ToString() == "F")
                        pic2CB1114.Image = imgCD;
                    else
                        pic2CB1114.Image = imgDD;

                }

                else if (tbTienTrinh.Rows[i][0].ToString() == "CB1109" || tbTienTrinh.Rows[i][0].ToString() == "CB1110")
                {
                    pic2CB1109.Visible = true;
                    //Kiểm tra xem môn đã đạt hay chưa
                    if (tbTienTrinh.Rows[i][4].ToString() == "F")
                        pic2CB1109.Image = imgCD;
                    else
                        pic2CB1109.Image = imgDD;
                }

                else if ((tbTienTrinh.Rows[i][0].ToString() == "TH1602") || (tbTienTrinh.Rows[i][0].ToString() == "TH1603" && tbTienTrinh.Rows[i][0].ToString() == "TH1604" && tbTienTrinh.Rows[i][0].ToString() == "TH1605")) //kiểm tra khóa luận tốt nghiệp
                {
                    pic2TH1602.Visible = true;
                    //Kiểm tra xem môn đã đạt hay chưa
                    if (tbTienTrinh.Rows[i][4].ToString() == "F")
                        pic2TH1602.Image = imgCD;
                    else
                        pic2TH1602.Image = imgDD;
                }
            }
            #endregion
        }

        private void LoadTienTrinh()
        {

            if (frmLogin.id != null)
            {
                DataTable tbTienTrinh = new DataTable();
                string query = "exec sp_GetTienTrinh '" + frmLogin.id + "'";
                tbTienTrinh = Models.DataProvider.Instance.FillDataTable(query, tbTienTrinh);

                //Thay đổi trạng thái môn học thành đã đạt
                Image imgDD = Image.FromFile("MonDaDat.png"); // image môn đã đạt
                Image imgCD = Image.FromFile("MonChuaDat.png");  // image môn chưa đạt

                //Vòng lập duyệt qua tất cả các control (picture Môn học) trong frmTienTrinh
                try
                {
                    foreach (PictureEdit pic in pnlMain.Controls)
                    {
                        //vòng lặp xác định môn.

                        for (int i = 0; i < tbTienTrinh.Rows.Count; i++)
                        {
                            //Kiểm tra tất cả những môn học

                            if (tbTienTrinh.Rows[i][0].ToString() == pic.Name.Substring(3, 6))  //Lấy cột mã môn so với name của picture
                            {
                                pic.Visible = true;
                                //Kiểm tra xem môn đã đạt hay chưa
                                if (tbTienTrinh.Rows[i][4].ToString() == "F")
                                    pic.Image = imgCD;
                                else
                                    pic.Image = imgDD;
                            }

                        }
                    }


                }
                catch (Exception)
                {
                }


            }

        }

        private void LoadDiemChiTiet(string MaMon)
        {
            try
            {

                pnlChiTiet.Visible = true;
                string sql = "exec sp_TienTrinhChiTietMon '" + frmLogin.id + "','" + MaMon + "'";
                DataTable tb = new DataTable();
                tb = Models.DataProvider.Instance.FillDataTable(sql, tb);
                lblMaMon.Text = tb.Rows[0][0].ToString();
                lblTenMon.Text = tb.Rows[0][1].ToString();
                lblDiem10.Text = tb.Rows[0][2].ToString();
                lblDiem40.Text = tb.Rows[0][3].ToString();
                lblDiem50.Text = tb.Rows[0][4].ToString();
                lblDiemchu.Text = tb.Rows[0][5].ToString();
                VisibleThongTinMon(true);
            }
            catch (Exception)
            {
                VisibleThongTinMon(false);
                lblMaMon.Text = "Môn chưa học";

            }

        }

        private void VisibleThongTinMon(bool ToF)
        {
            labeld10.Visible = ToF;
            labeld40.Visible = ToF;
            labeld50.Visible = ToF;
            labeldChu.Visible = ToF;
            labelmm.Visible = ToF;
            lblTenMon.Visible = ToF;
            lblDiem10.Visible = ToF;
            lblDiem40.Visible = ToF;
            lblDiem50.Visible = ToF;
            lblDiemchu.Visible = ToF;
        }

        private void frmTienTrinhHeThongTT_Load(object sender, EventArgs e)
        {
            LoadTienTrinh();
            LoadTienTrinh1Trong2();
        }
        #region chi tiết điểm


        private void btnTH1337_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1337");
        }

        private void btnTH1327_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1327");
        }

        private void btnTH1328_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1328");
        }

        private void btnTH1332_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1332");
        }

        private void btnTH1330_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1330");
        }

        private void btnTH1331_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1331");
        }

        private void btnCT1101_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CT1101");
        }

        private void btnTH1210_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1210");
        }

        private void btnCT1102_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CT1102");
        }

        private void btnCT1103_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CT1103");
        }

        private void btnTH1105_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1105");
        }


        private void btnTH1212_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1212");
        }

        private void btnCB1106_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CB1106");
        }

        private void btnTH1114_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1114");
        }

        private void btnCB1111_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CB1111");
        }

        private void btnNN1101_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("NN1101");
        }

        private void btnCB1112_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CB1112");
        }

        private void btnCB1107_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CB1107");
        }

        private void btnNN1102_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("NN1102");
        }

        private void btnNN1103_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("NN1103");
        }

        private void btnTH1201_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1201");
        }

        private void btnTH1204_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1204");
        }

        private void btnTH1209_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1209");
        }

        private void btnTH1206_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1206");
        }

        private void btnCT1104_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CT1104");
        }

        private void btnTH1306_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1306");
        }

        private void btnTH1302_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1302");
        }

        private void btnTH1211_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1211");
        }

        private void btnTH1304_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1304");
        }

        private void btnTH1323_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1323");
        }

        private void btnTH1325_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1325");
        }

        private void btnTH1308_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1308");
        }

        private void btnTH1310_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1310");
        }

        private void btnTH1301_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1301");
        }

        private void btnTH1213_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1213");
        }

        private void btnTH1309_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1309");
        }

        private void btnCB1108_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CB1108");
        }

        private void btnCB1113_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("CB1113");
        }

        private void btnTH1321_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1321");
        }

        private void btnTH1324_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1324");
        }

        private void btnTH1336_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1336");
        }

        private void btnTH1215_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1215");
        }

        private void btnTH1214_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1214");
        }

        private void btnTH1208_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1208");
        }

        private void btnTH1303_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1303");
        }

        private void btnTH1205_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1205");
        }

        private void btnDT1229_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("DT1229");
        }

        private void btnTH1203_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1203");
        }

        private void btnTH1207_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1207");
        }

        private void btnTH1307_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1307");
        }

        private void btnTH1305_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1305");
        }

        private void btnTH1216_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1216");
        }

        private void btnTH1333_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1333");
        }

        private void btnQS1103_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("QP1103");
        }

        private void btnQS1102_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("QP1102");
        }

        private void btnTC1103_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TC1106");
        }

        private void btnTC1102_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TC1102");
        }

        private void btnQS1101_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("QP1101");
        }

        private void btnTC1101_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TC1101");
        }

        private void btnTH1601_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1601");
        }

        private void btnTH1326_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1326");
        }

        private void btnTH1322_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1322");
        }

        private void btnTH1317_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1317");
        }

        private void btnTH1320_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1320");
        }

        private void btnTH1319_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1319");
        }

        private void btnTH1318_Click(object sender, EventArgs e)
        {
            LoadDiemChiTiet("TH1318");
        }

        #endregion

        #region Load điểm những ô nhiều môn
        private void btnCB1114_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaMon, Diem_10, Diem_40, Diem_50, DiemChu,He_4 FROM diem WHERE MSSV='" + frmLogin.id + "' and MaMon='CB1114'  or MaMon='CB1115'";
            DataTable tb = new DataTable();
            tb = Models.DataProvider.Instance.FillDataTable(sql, tb);
            if (tb.Rows.Count == 0)
            {
                LoadDiemChiTiet("CB1114");
            }
            else
            {
                //Nếu có nhiều hơn 2 môn thì so sánh điểm hệ 4 của 2 môn đó
                if (tb.Rows.Count > 1)
                {
                    float Row1 = Convert.ToSingle(tb.Rows[0][5]);
                    float Row2 = Convert.ToSingle(tb.Rows[1][5]);

                    if (Row1 < Row2)
                    {
                        LoadDiemChiTiet(tb.Rows[1][0].ToString());
                    }
                    else
                    {
                        LoadDiemChiTiet(tb.Rows[0][0].ToString());
                    }
                }
                else
                    LoadDiemChiTiet(tb.Rows[0][0].ToString());
            }

        }

        private void btnCT1105_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaMon, Diem_10, Diem_40, Diem_50, DiemChu,He_4 FROM diem WHERE MSSV='" + frmLogin.id + "' and MaMon='CT1106'  or MaMon='CT1105'";
            DataTable tb = new DataTable();
            tb = Models.DataProvider.Instance.FillDataTable(sql, tb);

            if (tb.Rows.Count == 0)
            {
                LoadDiemChiTiet("CT1105");
            }
            else
            {
                //Nếu có nhiều hơn 2 môn thì so sánh điểm hệ 4 của 2 môn đó
                if (tb.Rows.Count > 1)
                {
                    float Row1 = Convert.ToSingle(tb.Rows[0][5]);
                    float Row2 = Convert.ToSingle(tb.Rows[1][5]);

                    if (Row1 < Row2)
                    {
                        LoadDiemChiTiet(tb.Rows[1][0].ToString());
                    }
                    else
                    {
                        LoadDiemChiTiet(tb.Rows[0][0].ToString());
                    }
                }
                else
                    LoadDiemChiTiet(tb.Rows[0][0].ToString());
            }
        }

        private void btnCB1109_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaMon, Diem_10, Diem_40, Diem_50, DiemChu,He_4 FROM diem WHERE MSSV='" + frmLogin.id + "' and MaMon='CB1109'  or MaMon='CB1110'";
            DataTable tb = new DataTable();
            tb = Models.DataProvider.Instance.FillDataTable(sql, tb);

            //Nếu có nhiều hơn 2 môn thì so sánh điểm hệ 4 của 2 môn đó
            if (tb.Rows.Count == 0)
            {
                LoadDiemChiTiet("CB1109");
            }
            else
            {
                if (tb.Rows.Count > 1)
                {
                    float Row1 = Convert.ToSingle(tb.Rows[0][5]);
                    float Row2 = Convert.ToSingle(tb.Rows[1][5]);

                    if (Row1 < Row2)
                    {
                        LoadDiemChiTiet(tb.Rows[1][0].ToString());
                    }
                    else
                    {
                        LoadDiemChiTiet(tb.Rows[0][0].ToString());
                    }
                }
                else
                    LoadDiemChiTiet(tb.Rows[0][0].ToString());
            }
        }

        private void btnTH1602_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaMon, Diem_10, Diem_40, Diem_50, DiemChu,He_4 FROM diem WHERE MSSV='" + frmLogin.id + "' and MaMon='TH1602' OR (MaMon='TH1603' AND MaMon='TH1604' AND MaMon='TH1605')";
            DataTable tb = new DataTable();
            tb = Models.DataProvider.Instance.FillDataTable(sql, tb);


            if (tb.Rows.Count == 0)
            {
                LoadDiemChiTiet("TH1602");
            }
            else
            {
                if (tb.Rows.Count > 1)          //Nếu có nhiều hơn 2 môn thì so sánh điểm hệ 4 của 2 môn đó
                {
                    float Row1 = Convert.ToSingle(tb.Rows[0][5]);
                    float Row2 = Convert.ToSingle(tb.Rows[1][5]);

                    if (Row1 < Row2)
                    {
                        LoadDiemChiTiet(tb.Rows[1][0].ToString());
                    }
                    else
                    {
                        LoadDiemChiTiet(tb.Rows[0][0].ToString());
                    }
                }
                else
                    LoadDiemChiTiet(tb.Rows[0][0].ToString());
            }

        }

        #endregion

      
    }
}