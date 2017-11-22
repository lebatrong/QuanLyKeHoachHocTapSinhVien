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
using System.Threading;

namespace DoAn_Win
{
    public partial class ucRegister : DevExpress.XtraEditors.XtraUserControl
    {
        public ucRegister()
        {
            InitializeComponent();
        }
        bool co = false;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void ucRegister_Load(object sender, EventArgs e)
        {
            cbbHeDT.SelectedIndex = 0;
            cbbNganh.SelectedIndex = 0;
            loadlop();
            loadnganh();
        }
        private void loadlop()
        {
            int khoa = (int)nmrKhoaHoc.Value - 2000;
            if (cbbHeDT.Text == "Đại học")
                lbllop1.Text = "1";
            else
                lbllop1.Text = "2";

            string nganh;
            if (cbbNganh.Text == "Công nghệ thông tin")
                nganh = "CTT";
            else if (cbbNganh.Text == "Công nghệ kỹ thuật ô tô")
                nganh = "OTO";
            else
                nganh = "CTP";
            lbllop2.Text = nganh;
            lbllop3.Text = khoa.ToString();
           //lbllop4.Text=
        }
        private void loadnganh()
        {
            if (cbbHeDT.Text == "Đại học")
                lblNganh.Text = "ĐH";
            else
                lblNganh.Text = "CĐ";
        }

        private void cbbHeDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadnganh();
            loadlop();
        }

        private void cbbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlop();
        }

        private void nmrKhoaHoc_ValueChanged(object sender, EventArgs e)
        {
            
            loadlop();
            if (sinhvien.ktkhoahoc((int)nmrKhoaHoc.Value,dtpngaysinh.DateTime))
            {
                co = true;
                lblErrorKhoaHoc.Text = "";
            }
            else
            {
                co = false;
                lblErrorKhoaHoc.Text = "Khóa học không hợp lệ.";
            }
          
        }
        private void showFrmLogin()
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbHeDT.SelectedIndex = 0;
            cbbNganh.SelectedIndex = 0;
            txthoten.ResetText();
            txtmssv.ResetText();
            txtpass.ResetText();
            txtpass2.ResetText();
            nmrKhoaHoc.Value = 2010;
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
           
            if (co == true)
            {
                try
                {
                    string mssv = txtmssv.Text;
                    string pass = txtpass.Text;
                    string hoten = txthoten.Text;
                    string ngaysinh = dtpngaysinh.DateTime.ToString("dd/MM/yyyy");
                    string lop = lbllop1.Text + lbllop2.Text + lbllop3.Text + lbllop4.Text;
                    string nganh = cbbNganh.Text;
                    string hedaotao = cbbHeDT.Text;
                    int khoa = (int)nmrKhoaHoc.Value;
                
                    string insert = "insert into SinhVien values('" + mssv + "','" + pass + "',N'" + hoten + "','"+ ngaysinh + "','" + lop + "',N'" + nganh + "',N'" + hedaotao + "'," + khoa + ")";

                    if (Models.DataProvider.Instance.Exec_Tsql(insert) == 1)
                    {
                        XtraMessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread th = new Thread(new ThreadStart(showFrmLogin));
                        th.Start();
                        this.Dispose();
                        
                    }
                    else

                        XtraMessageBox.Show("Mã số sinh viên đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Lỗi 111!  ","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
                XtraMessageBox.Show("Lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtpass2_EditValueChanged(object sender, EventArgs e)
        {
            if (!sinhvien.ktmatkhau(txtpass.Text, txtpass2.Text))
            {
                lblErrorPass2.Text = "Mật khẩu không khớp";
                co = false;
            }
            else
            {
                lblErrorPass2.Text = "";
                lblErrorPass.Text = "";
                co = true;
            }
        }

        private void txtmssv_EditValueChanged(object sender, EventArgs e)
        {
            
                if (!sinhvien.kttendangnhap(txtmssv.Text))
                {
                    lblErrorMssv.Text = "MSSV không hợp lệ";
                    co = false;
                }
                else
                {
                    lblErrorMssv.Text = "";
                    co = true;
                }
            
        }


        private void txthoten_EditValueChanged(object sender, EventArgs e)
        {
            if (txthoten.Text == "")
            {
                co = false;
                lblErrorHoTen.Text = "Tên không được để trống";
            }
            else
            {
                if (sinhvien.ktten(txthoten.Text))
                {
                    lblErrorHoTen.Text = "";
                    co = true;
                }
                else
                {
                    co = false;
                    lblErrorHoTen.Text = "Tên không đúng định dạng";
                }
            }
        }

 

        private void txthoten_Leave(object sender, EventArgs e)
        {
            if (txthoten.Text == "")
            {
                co = false;
                lblErrorHoTen.Text = "Tên không được để trống";
            }
            else
            {
                if (sinhvien.ktten(txthoten.Text))
                {
                    lblErrorHoTen.Text = "";
                    co = true;
                }
                else
                {
                    co = false;
                    lblErrorHoTen.Text = "Tên không đúng định dạng";
                }
            }
           
                
            
        }

        private void dtpngaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (sinhvien.ktkhoahoc((int)nmrKhoaHoc.Value, dtpngaysinh.DateTime))
            {
                co = true;
                lblErrorKhoaHoc.Text = "";
            }
            else
            {
                co = false;
                lblErrorKhoaHoc.Text = "Khóa học không hợp lệ.";
            }
        }

        private void dtpngaysinh_Leave(object sender, EventArgs e)
        {
            if (sinhvien.ngaysinh(dtpngaysinh.DateTime))
            {
                lblErrorNgaySinh.Text = "";
                co = true;
            }
            else
            {
                lblErrorNgaySinh.Text = "Ngày sinh không hợp lệ";
                co = false;
            }

        }

        private void txtpass_EditValueChanged(object sender, EventArgs e)
        {
            if (!sinhvien.ktmatkhau(txtpass.Text, txtpass2.Text))
            {
                lblErrorPass.Text = "Mật khẩu không khớp";
                co = false;
            }
            else
            {
                lblErrorPass2.Text = "";
                lblErrorPass.Text = "";
                co = true;
            }
        }

    }
}