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
    public partial class ucNhapDiem : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNhapDiem()
        {
            InitializeComponent();
            loadMon();
        }

        void loadNamHoc()
        {
            DataTable table= new DataTable();
            string selectKhoaHoc = "select khoaHoc from SinhVien where MSSV='" + frmLogin.id + "'";
            table = Models.DataProvider.Instance.FillDataTable(selectKhoaHoc, table);
            int khoahoc = Convert.ToInt32(table.Rows[0][0].ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+0).ToString() + "-" + (khoahoc + 1).ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+1).ToString() + "-" + (khoahoc + 2).ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+2).ToString() + "-" + (khoahoc + 3).ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+3).ToString() + "-" + (khoahoc + 4).ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+4).ToString() + "-" + (khoahoc + 5).ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+5).ToString() + "-" + (khoahoc + 6).ToString());
            cbbNamHoc.Properties.Items.Add((khoahoc+6).ToString() + "-" + (khoahoc + 7).ToString());
            cbbNamHoc.SelectedIndex = 0;

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
   
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtmamon.Clear();
            txtTenMon.Clear();
            txtTim.Clear();
            txttinchi.Clear();
            txt10.Clear();
            txt40.Clear();
            txt50.Clear();
            lblDiemChu.Text = "";
            lblDiem4.Text = "";
            lblDiem10.Text = "";
            lblError10.Text = "";
            lblError40.Text = "";
            lblError50.Text = "";
            btnNhap.Enabled = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn thêm môn vào?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                    try
                    {

                        try
                        {
                            string sql;
                            if (!chkMonDatBiet.Checked){
                                float diem50 = Convert.ToSingle(txt50.Text);
                                float diemhe10 = Convert.ToSingle(lblDiem10.Text);
                                float diemhe4 = Convert.ToSingle(lblDiem4.Text);
                                float diem10 = Convert.ToSingle(txt10.Text);
                                float diem40 = Convert.ToSingle(txt40.Text);
                                sql = "INSERT INTO diem values('" + txtmamon.Text + "'," + diem10 + "," + diem40 + "," + diem50 + "," + diemhe10 + "," + diemhe4 + ",'" + lblDiemChu.Text + "','" + frmLogin.id + "',N'" + cbbHocKy.Text + " Năm học " + cbbNamHoc.Text + "','" + cbbNamHoc.Text + "')";
                          //  MessageBox.Show(sql);
                            } else
                            {
                                float diem50 = Convert.ToSingle(txt50.Text);
                                float diemhe10 = Convert.ToSingle(lblDiem10.Text);
                                float diemhe4 = Convert.ToSingle(lblDiem4.Text);
                                sql = "INSERT INTO diem values('" + txtmamon.Text + "',0,0," + diem50 + "," + diemhe10 + "," + diemhe4 + ",'" + lblDiemChu.Text + "','" + frmLogin.id + "',N'" + cbbHocKy.Text + " Năm học " + cbbNamHoc.Text + "','" + cbbNamHoc.Text + "')";

                            }
                            if (Models.DataProvider.Instance.Exec_Tsql(sql) == 1)
                            {
                                XtraMessageBox.Show("Bạn đã thêm thành công!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblErrorMonDaCo.Text = "";
                            }
                            else
                            {
                                lblErrorMonDaCo.Text = "(*) Môn học đã có điểm.";
                            }
                        }
                        catch (Exception ex)
                        {

                            XtraMessageBox.Show("Mã lỗi 106", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception)
                    {
                        lblErrorMonDaCo.Text = "(*) lỗi 123";

                    }
                
            }

            }
        
        public void click()
        {
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("text", gridCtrlThongtinmon.DataSource, "MaMon");
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("text", gridCtrlThongtinmon.DataSource, "TenMon");
            txttinchi.DataBindings.Clear();
            txttinchi.DataBindings.Add("text", gridCtrlThongtinmon.DataSource, "SoTinChi");
        }

        private void gridCtrlThongtinmon_MouseClick(object sender, MouseEventArgs e)
        {
            click();
        }

        private void gridCtrlTimMon_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtmamon.DataBindings.Clear();
                txtmamon.DataBindings.Add("text", gridCtrlTimMon.DataSource, "MaMon");
                txtTenMon.DataBindings.Clear();
                txtTenMon.DataBindings.Add("text", gridCtrlTimMon.DataSource, "TenMon");
                txttinchi.DataBindings.Clear();
                txttinchi.DataBindings.Add("text", gridCtrlTimMon.DataSource, "SoTinChi");
            }
            catch (Exception)
            {
                lblErrorTim.Text = "";
            }
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (chkMonDatBiet.Checked == false)
            {
                try
                {
                    decimal diem10 = Convert.ToDecimal(txt10.Text);
                    decimal diem40 = Convert.ToDecimal(txt40.Text);
                    decimal diem50 = Convert.ToDecimal(txt50.Text);
                    if (txt10.Text != "" || txt40.Text != "" || txt50.Text != "")
                    {
                        if (diem10 <= 10M && diem10 >= 0 && diem40 <= 10M && diem40 >= 0 && diem50 <= 10M && diem50 >= 0)
                        {
                            decimal kq = (diem10 + diem40 * 4 + diem50 * 5) / 10;
                            string kq4;
                            lblDiem10.Text = Convert.ToString(Math.Round(kq, 1, MidpointRounding.AwayFromZero));
                            decimal kq10 = Convert.ToDecimal(Math.Round(kq, 1, MidpointRounding.AwayFromZero));
                            if (diem50 > 3)
                            {
                                if (kq10 >= 8.5M)
                                    kq4 = "A";
                                else if (kq10 >= 7.8M)
                                    kq4 = "B+";
                                else if (kq10 >= 7.0M)
                                    kq4 = "B";
                                else if (kq10 >= 6.3M)
                                    kq4 = "C+";
                                else if (kq10 >= 5.5M)
                                    kq4 = "C";
                                else if (kq10 >= 4.8M)
                                    kq4 = "D+";
                                else if (kq10 >= 4.0M)
                                    kq4 = "D";
                                else
                                    kq4 = "F";
                            }
                            else
                                kq4 = "F";

                            lblDiemChu.Text = kq4;
                            float kqhe4;
                            if (kq4 == "A")
                                kqhe4 = 4.0f;
                            else if (kq4 == "B+")
                                kqhe4 = 3.5f;
                            else if (kq4 == "B")
                                kqhe4 = 3.0f;
                            else if (kq4 == "C+")
                                kqhe4 = 2.5f;
                            else if (kq4 == "C")
                                kqhe4 = 2.0f;
                            else if (kq4 == "D+")
                                kqhe4 = 1.5f;
                            else if (kq4 == "D")
                                kqhe4 = 1.0f;
                            else kqhe4 = 0.0f;
                            lblDiem4.Text = kqhe4.ToString();
                            btnNhap.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    lblError10.Text = "* Lỗi";
                    lblError40.Text = "* Lỗi";
                    lblError50.Text = "* Lỗi";
                }
            }
            else
            {
                if(txt50.Text!="")
                {
                    try
                    {
                         decimal diem50 = Convert.ToDecimal(txt50.Text);
                         string kq4;
                         if(diem50 <= 10M && diem50 >= 0)
                         {
                             if (diem50 > 3)
                             {
                                 
                                 if (diem50 >= 8.5M)
                                     kq4 = "A";
                                 else if (diem50 >= 7.8M)
                                     kq4 = "B+";
                                 else if (diem50 >= 7.0M)
                                     kq4 = "B";
                                 else if (diem50 >= 6.3M)
                                     kq4 = "C+";
                                 else if (diem50 >= 5.5M)
                                     kq4 = "C";
                                 else if (diem50 >= 4.8M)
                                     kq4 = "D+";
                                 else if (diem50 >= 4.0M)
                                     kq4 = "D";
                                 else
                                     kq4 = "F";
                             }
                             else
                                 kq4 = "F";

                             lblDiemChu.Text = kq4;
                             float kqhe4;
                             if (kq4 == "A")
                                 kqhe4 = 4.0f;
                             else if (kq4 == "B+")
                                 kqhe4 = 3.5f;
                             else if (kq4 == "B")
                                 kqhe4 = 3.0f;
                             else if (kq4 == "C+")
                                 kqhe4 = 2.5f;
                             else if (kq4 == "C")
                                 kqhe4 = 2.0f;
                             else if (kq4 == "D+")
                                 kqhe4 = 1.5f;
                             else if (kq4 == "D")
                                 kqhe4 = 1.0f;
                             else kqhe4 = 0.0f;
                             lblDiem4.Text = kqhe4.ToString();
                             lblDiem10.Text = diem50.ToString();
                             btnNhap.Enabled = true;
                         }
                    }
                    catch (Exception)
                    {
                        
                        lblError50.Text = "* Lỗi";
                    }
                }
            }
            
        }

        private void UcNhapDiem_Load(object sender, EventArgs e)
        {
            loadMon();
            loadNamHoc();
        }

        private void chkMonDatBiet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonDatBiet.Checked)
            {
                txt10.Enabled = false;
                txt40.Enabled = false;
            }else
            {
                txt10.Enabled = true;
                txt40.Enabled = true;
            }
        }

    

    }
}