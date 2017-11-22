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
    public partial class ucEdit : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEdit()
        {
            InitializeComponent();
        }
        public void loadThongtindiem()
        {
            Models.DataProvider.Instance.open();

            string query = "select Diem.MaMon,TenMon,SoTinChi,Diem_10,Diem_40,Diem_50,He_10,DiemChu,He_4,HocKy from MonHoc,Diem where Diem.MaMon=MonHoc.MaMon and MSSV='" + frmLogin.id + "'";

            DataTable data = new DataTable();
            data = Models.DataProvider.Instance.FillDataTable(query, data);
            dgvwThongtin.DataSource = data;
        }

        
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                string sele = "select TenMon,SoTinChi,Diem_10,Diem_40,Diem_50,He_10,DiemChu,He_4,HocKy from MonHoc,Diem where Diem.MaMon=MonHoc.MaMon and MSSV='" + frmLogin.id + "' and Diem.MaMon='" + txtMaMonUpdate.Text + "'";
                DataTable table = new DataTable();
                table = Models.DataProvider.Instance.FillDataTable(sele, table);
                txtTenMonUpdate.Text = table.Rows[0][0].ToString();
                txtTinChiUpdate.Text = table.Rows[0][1].ToString();
                txtdiem10update.Text = table.Rows[0][2].ToString();
                txtdiem40update.Text = table.Rows[0][3].ToString();
                txtdiem50update.Text = table.Rows[0][4].ToString();
                txtkq10update.Text = table.Rows[0][5].ToString();
                txtkqChuUpdate.Text = table.Rows[0][6].ToString();
                txtkq4update.Text = table.Rows[0][7].ToString();
                txtHocKy.Text = table.Rows[0][8].ToString();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Không tìm thấy tên môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhatMon_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn cập nhật thông tin môn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    float diem10 = float.Parse(txtdiem10update.Text);
                    float diem40 = float.Parse(txtdiem40update.Text);
                    float diem50 = float.Parse(txtdiem50update.Text);
                    lblErrorUpdate10.Text = "";
                    lblErrorUpdate40.Text = "";
                    lblErrorUpdate50.Text = "";
                    if (txtdiem10update.Text != "" && txtdiem40update.Text != "" && txtdiem50update.Text != "")
                    {

                        string updateMon = "Update Diem set	Diem_10=" + txtdiem10update.Text + ",Diem_40=" + txtdiem40update.Text + ", Diem_50=" + txtdiem50update.Text + ", DiemChu='" + txtkqChuUpdate.Text + "',He_10=" + txtkq10update.Text + ",He_4=" + txtkq4update.Text + ",HocKy=N'" + txtHocKy.Text + "' where MaMon='" + txtMaMonUpdate.Text + "' and MSSV='" + frmLogin.id + "'";
                      //  MessageBox.Show(updateMon);
                        string kt = "select TenMon from Diem, MonHoc where Diem.MaMon=MonHoc.MaMon and Diem.MaMon='" + txtMaMonUpdate.Text + "' and MSSV='" + frmLogin.id + "'";
                        DataTable tbkt = new DataTable();
                        tbkt = Models.DataProvider.Instance.FillDataTable(kt, tbkt);


                        if (tbkt.Rows.Count > 0)
                        {
                            lblerrorLoiXoa.Text = "";
                            if (Models.DataProvider.Instance.Exec_Tsql(updateMon) == 1)
                            {
                                Reset();
                                loadThongtindiem();
                                XtraMessageBox.Show("Cập nhật môn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else

                                XtraMessageBox.Show("Lỗi 123", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        else
                        {
                            lblerrorLoiXoa.Text = "* Không tìm thấy môn học trong hệ thống.";
                        }
                    }
                    else
                    {
                        lblErrorUpdate10.Text = "* Lỗi!";
                        lblErrorUpdate40.Text = "* Lỗi!";
                        lblErrorUpdate50.Text = "* Lỗi!";
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnDeleteMon_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaMonUpdate.Text != "")
                {
                    if (XtraMessageBox.Show("Bạn muốn xóa môn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {

                        string deleteMon = "delete from Diem where MaMon='" + txtMaMonUpdate.Text + "' and MSSV='" + frmLogin.id + "'";
                        string kt = "select TenMon from Diem, MonHoc where Diem.MaMon=MonHoc.MaMon and Diem.MaMon='" + txtMaMonUpdate.Text + "' and MSSV='" + frmLogin.id + "'";

                        DataTable tbkt = new DataTable();
                        tbkt = Models.DataProvider.Instance.FillDataTable(kt, tbkt);
                        if (tbkt.Rows.Count > 0)
                        {
                            lblerrorLoiXoa.Text = "";
                            if (Models.DataProvider.Instance.Exec_Tsql(deleteMon) == 1)
                            {
                                XtraMessageBox.Show("Xóa môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadThongtindiem();
                                Reset();
                            }

                            else
                                XtraMessageBox.Show("Lỗi 123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            lblerrorLoiXoa.Text = "* Không tìm thấy môn học trong hệ thống.";
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Mã môn học không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void click()
        {

            txtMaMonUpdate.DataBindings.Clear();
            txtMaMonUpdate.DataBindings.Add("text", dgvwThongtin.DataSource, "MaMon");
            txtTenMonUpdate.DataBindings.Clear();
            txtTenMonUpdate.DataBindings.Add("text", dgvwThongtin.DataSource, "TenMon");
            txtTinChiUpdate.DataBindings.Clear();
            txtTinChiUpdate.DataBindings.Add("text", dgvwThongtin.DataSource, "SoTinChi");
            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("text", dgvwThongtin.DataSource, "HocKy");
            txtdiem10update.DataBindings.Clear();
            txtdiem10update.DataBindings.Add("text", dgvwThongtin.DataSource, "Diem_10");
            txtdiem40update.DataBindings.Clear();
            txtdiem40update.DataBindings.Add("text", dgvwThongtin.DataSource, "Diem_40");
            txtdiem50update.DataBindings.Clear();
            txtdiem50update.DataBindings.Add("text", dgvwThongtin.DataSource, "Diem_50");
            txtkq10update.DataBindings.Clear();
            txtkq10update.DataBindings.Add("text", dgvwThongtin.DataSource, "He_10");
            txtkq4update.DataBindings.Clear();
            txtkq4update.DataBindings.Add("text", dgvwThongtin.DataSource, "He_4");
            txtkqChuUpdate.DataBindings.Clear();
            txtkqChuUpdate.DataBindings.Add("text", dgvwThongtin.DataSource, "DiemChu");





        }
        private void dgvwThongtin_MouseClick(object sender, MouseEventArgs e)
        {
            click();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (chkMonDatBiet.Checked == false)
            {
                try
                {
                    decimal diem10 = Convert.ToDecimal(txtdiem10update.Text);
                    decimal diem40 = Convert.ToDecimal(txtdiem40update.Text);
                    decimal diem50 = Convert.ToDecimal(txtdiem50update.Text);
                    if (txtdiem10update.Text != "" || txtdiem40update.Text != "" || txtdiem50update.Text != "")
                    {
                        if (diem10 <= 10M && diem10 >= 0 && diem40 <= 10M && diem40 >= 0 && diem50 <= 10M && diem50 >= 0)
                        {
                            decimal kq = (diem10 + diem40 * 4 + diem50 * 5) / 10;
                            string kq4;
                            txtkq10update.Text = Convert.ToString(Math.Round(kq, 1, MidpointRounding.AwayFromZero));
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

                            txtkqChuUpdate.Text = kq4;
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
                            txtkq4update.Text = kqhe4.ToString();
                            btnCapNhatMon.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    lblErrorUpdate10.Text = "* Lỗi";
                    lblErrorUpdate40.Text = "* Lỗi";
                    lblErrorUpdate50.Text = "* Lỗi";
                }
            }
            else
            {
                if (txtdiem50update.Text != "")
                {
                    try
                    {
                        decimal diem50 = Convert.ToDecimal(txtdiem50update.Text);
                        string kq4;
                        if (diem50 <= 10M && diem50 >= 0)
                        {
                            btnCapNhatMon.Enabled = true;
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

                            txtkqChuUpdate.Text = kq4;
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
                            txtkq4update.Text = kqhe4.ToString();
                            txtkq10update.Text = diem50.ToString();
                           
                        }
                    }
                    catch (Exception)
                    {
                        lblErrorUpdate50.Text = "* Lỗi";
                    }
                }
            }
        }

        void Reset()
        {
            loadThongtindiem();
            loadThongtindiem();
            txtHocKy.Text = "";
            txtMaMonUpdate.Clear();
            txtTenMonUpdate.Clear();
            txtTinChiUpdate.Clear();
            txtdiem10update.Clear();
            txtdiem40update.Clear();
            txtdiem50update.Clear();
            txtkq10update.Clear();
            txtkq4update.Clear();
            txtkqChuUpdate.Clear();
            lblErrorUpdate10.Text = "";
            lblErrorUpdate40.Text = "";
            lblErrorUpdate50.Text = "";
            lblerrorLoiXoa.Text = "";
            btnCapNhatMon.Enabled = false;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ucEdit_Load(object sender, EventArgs e)
        {
            loadThongtindiem();
        }

        private void chkMonDatBiet_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}