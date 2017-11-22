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
using System.Threading;
using DoAn_Win.UserControl;
using WMPLib;

namespace DoAn_Win
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        int Day,Month,Year,Hours,Minute,Second;

        string id = frmLogin.id;
        public frmMain()
        {
            
            InitializeComponent();
            loadRibboStt();
            _GetTime();
      
           
            
        }

        #region HÀM LẤY THỜI GIAN
        private int _GetDayOfMonth(int Month, int Years)
        {
            int Day = 0;
            if (Month == 2)
            {
                if (((Years % 4 == 0) && (Years % 100 != 0)) || (Years % 400 == 0)) // Năm nhuận
                    Day = 29;
                else
                    Day = 28;
            }
            else
            {
                switch (Month)
                {
                    case 1: Day = 31;
                        break;
                    case 3: Day = 31;
                        break;
                    case 4: Day = 30;
                        break;
                    case 5: Day = 31;
                        break;
                    case 6: Day = 30;
                        break;
                    case 7: Day = 31;
                        break;
                    case 8: Day = 31;
                        break;
                    case 9: Day = 30;
                        break;
                    case 10: Day = 31;
                        break;
                    case 11: Day = 30;
                        break;
                    default: Day = 31;
                        break;
                }
            }
            return Day;
        }


        private void _GetTime()
        {
            Day = DateTime.Now.Day;
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            Hours = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;
        }
        #endregion

        #region HÀM ĐỒNG HỒ
        private void timer_Tick(object sender, EventArgs e)
        {
            Second++;
            //tính phút
            if (Second >= 60)
            {
                Second = 0;
                Minute++;
            }
            //Tính giờ
            if (Minute >= 60)
            {
                Minute = 0;
                Hours++;
            }
            //tính ngày
            if (Hours >= 24)
            {
                Hours = 0;
                Day++;
            }


            //tính tháng
            if (Day > _GetDayOfMonth(Month, Year))
            {
                Day = 1;
                Month++;
            }
            //Tính năm
            if (Month > 12)
            {
                Year++;
                Month = 1;
            }
            string day, month, hours, minute, second;

            if (Day < 10)
                day = "0" + Day.ToString();
            else
                day = Day.ToString();

            if (Month < 10)
                month = "0" + Month.ToString();
            else
                month = Month.ToString();

            if (Hours < 10)
                hours = "0" + Hours.ToString();
            else
                hours = Hours.ToString();

            if (Minute < 10)
                minute = "0" + Minute.ToString();
            else
                minute = Minute.ToString();

            if (Second < 10)
                second = "0" + Second.ToString();
            else
                second = Second.ToString();


            barstaTime.Caption = "Ngày: " + day + "/" + month + "/" + Year.ToString() + " " + hours + ":" + minute + ":" + second;
        }
#endregion

        #region PHÂN QUYỀN
        private void PhanQuyen()
        {
            bool keyF = false;
            bool keyT = true;
            //Phân quyền
            if (frmLogin.id == null || frmLogin.id == "")
            {
                //NavarGrounp

                nvGrSetting.Visible = keyF;
                nvGrBaoMat.Visible = keyF;

                //RiboControl
                rbGrHeThong.Visible = keyF;
                rbGrThongTin.Visible = keyF;

                //Button
                btnNote.Enabled = keyF;
                btnChinhSua.Enabled = keyF;
                btnNhapdiem.Enabled = keyF;
                btnThongTin.Enabled = keyF;
                btnTienTrinh.Enabled = keyF;
                nbItemEditAccount.Enabled = keyF;
                nbItemUpdatePass.Enabled = keyF;
                nbItemLogOut.Enabled = keyF;
                //Đăng nhập đăng ký
                rbGrQuanLy.Visible = keyT;
                btnLogin.Enabled = keyT;
                btnDangKy.Enabled = keyT;

                //Tạo database

                rbGrSetting.Visible = keyT;

                //panelMain.Controls.Clear();
                //ucIndex uc = new ucIndex();
                //uc.Dock = System.Windows.Forms.DockStyle.Fill;
                //panelMain.Controls.Add(uc);

            }
            else
            {

                //NavarGrounp
                nbItemAddMonHoc.Enabled = keyT;
                nbItemEditMonHoc.Enabled = keyT;

                nvGrSetting.Visible = keyT;
                nvGrBaoMat.Visible = keyT;

                //RiboControl
                rbGrHeThong.Visible = keyT;
                rbGrThongTin.Visible = keyT;

                //Button
                btnNote.Enabled = keyT;
                btnChinhSua.Enabled = keyT;
                nbItemLogOut.Enabled = keyT;
                btnNhapdiem.Enabled = keyT;
                btnThongTin.Enabled = keyT;
                btnTienTrinh.Enabled = keyT;
                nbItemEditAccount.Enabled = keyT;
                nbItemUpdatePass.Enabled = keyT;

                //đăng nhập đăng ký
                rbGrQuanLy.Visible = keyF;
                btnLogin.Enabled = keyF;
                btnDangKy.Enabled = keyF;

                //Tạo database
                rbGrSetting.Visible = keyF;

            }
            
        }
        #endregion

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongTin uc = new ucThongTin();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnNhapdiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucNhapDiem Uc = new ucNhapDiem();
            Uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(Uc);
        }
  
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
            _GetTime();

            PhanQuyen();

            loadtheme();
            loadRibboStt();
            
            //Load index
            panelMain.Controls.Clear();
            ucIndex uc = new ucIndex();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);


            //Kiểm tra database

            if (Models.DataProvider.Instance.CheckDatabase() == false)
                rbGrSetting.Visible = true;
            else
                rbGrSetting.Visible = false;
        }

        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucEdit uc = new ucEdit();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        private void loadtheme()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Office 2007 Blue";
        }
        private void showlogin()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn muốn đăng xuất tài khoản?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                frmLogin.id = null;
                CloseAllForm();

                PhanQuyen();

            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin f = new frmLogin();
            CloseAllForm();
            f.ShowDialog();
           
            
            
        }
        private void CloseAllForm()
        {
            panelMain.Controls.Clear();
        }
        private void frmMain_Activated(object sender, EventArgs e)
        {
            //Hiển thị có thông báo
            if (frmLogin.id != null)
            {
                string sel = "select LanThongBao from Note where MSSV='" + frmLogin.id + "' AND abs(datediff(day,NgayThongBao,getdate()))<=1 and LanThongBao=0";
                DataTable table = new DataTable();
                table = Models.DataProvider.Instance.FillDataTable(sel, table);
                if (table.Rows.Count != 0)
                {
                    timer_Noti.Start();
                }
            }
            //----------------------------
            _GetTime();

            PhanQuyen();

            loadRibboStt();

            
            
        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucRegister uc = new ucRegister();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnEditAcc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            UcEditAccount uc = new UcEditAccount();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
       
        }

        private void btnUpdatePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucEditPass uc = new ucEditPass();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
          
            }

        private void navBarControl2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ucEditPass uc = new ucEditPass();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void nbItemEditAccount_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            UcEditAccount uc = new UcEditAccount();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void nbItemUpdatePass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            ucEditPass uc = new ucEditPass();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn đăng xuất tài khoản?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                frmLogin.id = null;
                CloseAllForm();

                bool keyF = false;
                bool keyT = true;
                //Phân quyền
                if (frmLogin.id == null || frmLogin.id=="")
                {
                    //NavarGrounp
                    nvGrSetting.Visible = keyF;
                    nvGrBaoMat.Visible = keyT;

                    //RiboControl
                    rbGrHeThong.Visible = keyF;
                    rbGrQuanLy.Visible = keyT;
                    rbGrThongTin.Visible = keyF;

                    //Button
                    btnNote.Enabled = keyF;
                    btnChinhSua.Enabled = keyF;
                    btnNhapdiem.Enabled = keyF;
                    btnThongTin.Enabled = keyF;
                    btnTienTrinh.Enabled = keyF;
                    nbItemEditAccount.Enabled = keyF;
                    nbItemUpdatePass.Enabled = keyF;
                    nbItemLogOut.Enabled = keyF;
                    btnLogin.Enabled = keyT;
                    btnDangKy.Enabled = keyT;


                    //Tạo database
                    rbGrSetting.Visible = keyT;


                    panelMain.Controls.Clear();
                    ucIndex uc = new ucIndex();
                    uc.Dock = System.Windows.Forms.DockStyle.Fill;
                    panelMain.Controls.Add(uc);

                }
                else
                {

                    //NavarGrounp
                    nbItemAddMonHoc.Enabled = keyT;
                    nbItemEditMonHoc.Enabled = keyT;

                    nvGrSetting.Visible = keyT;
                    nvGrBaoMat.Visible = keyT;

                    //RiboControl
                    rbGrHeThong.Visible = keyT;
                    rbGrQuanLy.Visible = keyF;
                    rbGrThongTin.Visible = keyT;

                    //Button
                    btnNote.Enabled = keyT;
                    btnChinhSua.Enabled = keyT;
                    nbItemLogOut.Enabled = keyT;
                    btnNhapdiem.Enabled = keyT;
                    btnThongTin.Enabled = keyT;
                    btnTienTrinh.Enabled = keyT;
                    nbItemEditAccount.Enabled = keyT;
                    nbItemUpdatePass.Enabled = keyT;
                    btnLogin.Enabled = keyF;
                    btnDangKy.Enabled = keyF;


                    //Tạo database
                    rbGrSetting.Visible = keyF;

                }
               
                loadRibboStt();
            }
        }
       
        private void loadRibboStt()
        {
            barNamePC.Caption ="  ComputerName: [ "+ SystemInformation.ComputerName.ToString()+" ]  ";
            if(frmLogin.id==null)
                barStaItemTrangThai.Caption = "Trạng thái: Chưa hoạt động";
            else
                barStaItemTrangThai.Caption = "Trạng thái: Đang hoạt động (" + frmLogin.id.ToString() +")";
            
        }

        private void nbItemAddMonHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            ucAddMon uc = new ucAddMon();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void nbItemEditMonHoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            ucEditMonHoc uc = new ucEditMonHoc();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucNote uc = new ucNote();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barbtnKHMT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTienTrinhKhoaHocMT f = new frmTienTrinhKhoaHocMT();
            f.Show();
        }

        private void barbtnHeThongTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTienTrinhHeThongTT f = new frmTienTrinhHeThongTT();
            f.Show();
        }

        private void nbItemInformation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            ucInformation uc = new ucInformation();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void _LoadNote()
        {
           
            timer_Noti.Stop();
            if(frmLogin.id!=null)
            {

                string sel = "select Id,NgayThongBao,LanThongBao from Note where MSSV='" + frmLogin.id + "' AND abs(datediff(day,NgayThongBao,getdate()))<=1 and LanThongBao=0";
                DataTable table = new DataTable();
                table = Models.DataProvider.Instance.FillDataTable(sel, table);

                
                if (table.Rows.Count != 0)
                {
                    WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer();
                    a.URL = @"ThongBao.mp3";
                    a.controls.play();

                    if(XtraMessageBox.Show("Bạn có thông báo mới, Xem ngay?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
                    {
                        FrmNoteToday note = new FrmNoteToday();
                        note.ShowDialog();   
                    }
                 }
            }

        }

        private void btnCreateData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckDatabase();
        }

        private void timer_Noti_Tick(object sender, EventArgs e)
        {
            _LoadNote();
        }

        private void btnTienTrinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barbtnCNPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTienTrinh f = new frmTienTrinh();
            f.Show();
        }

        private void barbtnTTvaMMT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTienTrinhMMT f = new frmTienTrinhMMT();
            f.Show();
        }

        #region Kiểm tra database và tạo database

        private void CheckDatabase()
        {

            if (Models.DataProvider.Instance.CheckDatabase() == false)
                Models.DataProvider.Instance.ReadDatabase();
            else
                XtraMessageBox.Show("Đã có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        #endregion

    }
}
