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
    public partial class UcEditAccount : DevExpress.XtraEditors.XtraUserControl
    {
        public UcEditAccount()
        {
            InitializeComponent();
        }
        private void ucEditAcconut_Load(object sender, EventArgs e)
        {
            loadInfoAcc();
            KhoaAll(false);
        }
        void KhoaAll(bool TrueOrFalse)
        {
            txthoten.Enabled = TrueOrFalse;
            cbbHeDT.Enabled = TrueOrFalse;
            cbbNganh.Enabled = TrueOrFalse;
            nmrKhoaHoc.Enabled = TrueOrFalse;
            dtpngaysinh.Enabled = TrueOrFalse;
            btnHuy.Enabled = TrueOrFalse;
            btnSaves.Enabled = TrueOrFalse;
        }

        void loadInfoAcc()
        {
           
            string account = "select HoTenSV, NgaySinh,Lop,Nganh, HeDT, khoaHoc from SinhVien where MSSV='" + frmLogin.id + "' ";
            DataTable table = new DataTable();
            table = Models.DataProvider.Instance.FillDataTable(account, table);
            string lop = table.Rows[0][2].ToString();
            string nganh = table.Rows[0][3].ToString();
            string heDt = table.Rows[0][4].ToString();
            try 
	        {	        
		            dtpngaysinh.DateTime = Convert.ToDateTime(table.Rows[0][1].ToString());
	        }
	        catch (Exception){}
            
            
            if (heDt == "Đại học")
                cbbHeDT.SelectedIndex = 0;
            else
                cbbHeDT.SelectedIndex = 1;

            if (nganh == "Công nghệ thông tin")
                cbbNganh.SelectedIndex = 0;
            else if (nganh == "Công nghệ kỹ thuật ô tô")
                cbbNganh.SelectedIndex = 1;
            else
                cbbNganh.SelectedIndex = 2;

            txtmssv.Text = frmLogin.id.ToString();
            txthoten.DataBindings.Clear();
            txthoten.DataBindings.Add("text", table, "HoTenSV");
            nmrKhoaHoc.DataBindings.Clear();
            nmrKhoaHoc.DataBindings.Add("text", table, "khoaHoc");

            loadlop();
            loadnganh();
            lblErrorHoTen.Text = "";
            lblErrorKhoaHoc.Text = "";
            lblErrorNgaySinh.Text = "";
            
         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            KhoaAll(true);
        }


        void loadlop()
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


        void loadnganh()
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
            if (sinhvien.ktkhoahoc((int)nmrKhoaHoc.Value, dtpngaysinh.DateTime))

                lblErrorKhoaHoc.Text = "";

            else

                lblErrorKhoaHoc.Text = "Khóa học không hợp lệ.";

        }

        private void txthoten_EditValueChanged(object sender, EventArgs e)
        {
            if (txthoten.Text == "")

                lblErrorHoTen.Text = "Tên không được để trống";

            else
            {
                if (sinhvien.ktten(txthoten.Text))

                    lblErrorHoTen.Text = "";

                else

                    lblErrorHoTen.Text = "Tên không đúng định dạng";

            }
        }

    

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadInfoAcc();
            KhoaAll(false);
        }

        private void btnSaves_Click(object sender, EventArgs e)
        {
            string mssv = txtmssv.Text;

            string hoten = txthoten.Text;
            string ngaysinh = dtpngaysinh.DateTime.ToString("dd/MM/yyyy");
            string lop = lbllop1.Text + lbllop2.Text + lbllop3.Text + lbllop4.Text;
            string nganh = cbbNganh.Text;
            string hedaotao = cbbHeDT.Text;
            int khoa = (int)nmrKhoaHoc.Value;
            string update = "update SinhVien set HoTenSV=N'" + hoten + "', NgaySinh='" + ngaysinh + "',Lop='" + lop + "',Nganh=N'" + nganh + "',HeDT=N'" + hedaotao + "',khoaHoc=" + khoa + " where MSSV='" + frmLogin.id + "'";
            if (XtraMessageBox.Show("Bạn muốn cập nhật thông tin tài khoản?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Models.DataProvider.Instance.Exec_Tsql(update) == 1)
                {
                    XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadInfoAcc();
                    KhoaAll(false);
                }


            }
        }

        private void dtpngaysinh_EditValueChanged(object sender, EventArgs e)
        {
            if (sinhvien.ktkhoahoc((int)nmrKhoaHoc.Value, dtpngaysinh.DateTime))
                lblErrorKhoaHoc.Text = "";
            else
                lblErrorKhoaHoc.Text = "Khóa học không hợp lệ.";
        }

        private void dtpngaysinh_Leave_1(object sender, EventArgs e)
        {
            if (sinhvien.ngaysinh(dtpngaysinh.DateTime))
                lblErrorNgaySinh.Text = "";
            else
                lblErrorNgaySinh.Text = "Ngày sinh không hợp lệ";

        }
    }
}