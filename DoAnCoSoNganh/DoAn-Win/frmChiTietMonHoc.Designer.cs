namespace DoAn_Win
{
    partial class frmChiTietMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietMonHoc));
            this.dgvwThongtin = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_MaMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SoTinChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Diem_10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Diem_40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Diem_50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_He_10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DiemChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_He_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_HocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvwThongtin
            // 
            this.dgvwThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwThongtin.Location = new System.Drawing.Point(0, 0);
            this.dgvwThongtin.MainView = this.gridView1;
            this.dgvwThongtin.Name = "dgvwThongtin";
            this.dgvwThongtin.Size = new System.Drawing.Size(899, 406);
            this.dgvwThongtin.TabIndex = 32;
            this.dgvwThongtin.UseEmbeddedNavigator = true;
            this.dgvwThongtin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_MaMon,
            this.col_TenMon,
            this.col_SoTinChi,
            this.col_Diem_10,
            this.col_Diem_40,
            this.col_Diem_50,
            this.col_He_10,
            this.col_DiemChu,
            this.col_He_4,
            this.col_HocKy});
            this.gridView1.GridControl = this.dgvwThongtin;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // col_MaMon
            // 
            this.col_MaMon.Caption = "Mã môn";
            this.col_MaMon.FieldName = "MaMon";
            this.col_MaMon.Name = "col_MaMon";
            this.col_MaMon.OptionsColumn.AllowEdit = false;
            this.col_MaMon.OptionsColumn.ReadOnly = true;
            this.col_MaMon.Visible = true;
            this.col_MaMon.VisibleIndex = 0;
            this.col_MaMon.Width = 53;
            // 
            // col_TenMon
            // 
            this.col_TenMon.Caption = "Tên môn học";
            this.col_TenMon.FieldName = "TenMon";
            this.col_TenMon.Name = "col_TenMon";
            this.col_TenMon.OptionsColumn.AllowEdit = false;
            this.col_TenMon.OptionsColumn.ReadOnly = true;
            this.col_TenMon.Visible = true;
            this.col_TenMon.VisibleIndex = 1;
            this.col_TenMon.Width = 230;
            // 
            // col_SoTinChi
            // 
            this.col_SoTinChi.Caption = "Tín chỉ";
            this.col_SoTinChi.FieldName = "SoTinChi";
            this.col_SoTinChi.Name = "col_SoTinChi";
            this.col_SoTinChi.OptionsColumn.AllowEdit = false;
            this.col_SoTinChi.OptionsColumn.ReadOnly = true;
            this.col_SoTinChi.Visible = true;
            this.col_SoTinChi.VisibleIndex = 2;
            this.col_SoTinChi.Width = 49;
            // 
            // col_Diem_10
            // 
            this.col_Diem_10.Caption = "Điểm CC";
            this.col_Diem_10.FieldName = "Diem_10";
            this.col_Diem_10.Name = "col_Diem_10";
            this.col_Diem_10.OptionsColumn.AllowEdit = false;
            this.col_Diem_10.OptionsColumn.ReadOnly = true;
            this.col_Diem_10.Visible = true;
            this.col_Diem_10.VisibleIndex = 3;
            this.col_Diem_10.Width = 50;
            // 
            // col_Diem_40
            // 
            this.col_Diem_40.Caption = "Điểm GK";
            this.col_Diem_40.FieldName = "Diem_40";
            this.col_Diem_40.Name = "col_Diem_40";
            this.col_Diem_40.OptionsColumn.AllowEdit = false;
            this.col_Diem_40.OptionsColumn.ReadOnly = true;
            this.col_Diem_40.Visible = true;
            this.col_Diem_40.VisibleIndex = 4;
            this.col_Diem_40.Width = 49;
            // 
            // col_Diem_50
            // 
            this.col_Diem_50.Caption = "Điểm CK";
            this.col_Diem_50.FieldName = "Diem_50";
            this.col_Diem_50.Name = "col_Diem_50";
            this.col_Diem_50.OptionsColumn.AllowEdit = false;
            this.col_Diem_50.OptionsColumn.ReadOnly = true;
            this.col_Diem_50.Visible = true;
            this.col_Diem_50.VisibleIndex = 5;
            this.col_Diem_50.Width = 52;
            // 
            // col_He_10
            // 
            this.col_He_10.Caption = "Hệ 10";
            this.col_He_10.FieldName = "He_10";
            this.col_He_10.Name = "col_He_10";
            this.col_He_10.OptionsColumn.AllowEdit = false;
            this.col_He_10.OptionsColumn.ReadOnly = true;
            this.col_He_10.Visible = true;
            this.col_He_10.VisibleIndex = 6;
            this.col_He_10.Width = 47;
            // 
            // col_DiemChu
            // 
            this.col_DiemChu.Caption = "Điểm chữ";
            this.col_DiemChu.FieldName = "DiemChu";
            this.col_DiemChu.Name = "col_DiemChu";
            this.col_DiemChu.OptionsColumn.AllowEdit = false;
            this.col_DiemChu.OptionsColumn.ReadOnly = true;
            this.col_DiemChu.Visible = true;
            this.col_DiemChu.VisibleIndex = 7;
            this.col_DiemChu.Width = 56;
            // 
            // col_He_4
            // 
            this.col_He_4.Caption = "Hệ 4";
            this.col_He_4.FieldName = "He_4";
            this.col_He_4.Name = "col_He_4";
            this.col_He_4.OptionsColumn.AllowEdit = false;
            this.col_He_4.OptionsColumn.ReadOnly = true;
            this.col_He_4.Visible = true;
            this.col_He_4.VisibleIndex = 8;
            this.col_He_4.Width = 36;
            // 
            // col_HocKy
            // 
            this.col_HocKy.Caption = "Học kỳ";
            this.col_HocKy.FieldName = "HocKy";
            this.col_HocKy.Name = "col_HocKy";
            this.col_HocKy.OptionsColumn.AllowEdit = false;
            this.col_HocKy.OptionsColumn.ReadOnly = true;
            this.col_HocKy.Visible = true;
            this.col_HocKy.VisibleIndex = 9;
            this.col_HocKy.Width = 231;
            // 
            // frmChiTietMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 406);
            this.Controls.Add(this.dgvwThongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChiTietMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết môn học";
            this.Load += new System.EventHandler(this.frmChiTietMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvwThongtin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaMon;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenMon;
        private DevExpress.XtraGrid.Columns.GridColumn col_SoTinChi;
        private DevExpress.XtraGrid.Columns.GridColumn col_Diem_10;
        private DevExpress.XtraGrid.Columns.GridColumn col_Diem_40;
        private DevExpress.XtraGrid.Columns.GridColumn col_Diem_50;
        private DevExpress.XtraGrid.Columns.GridColumn col_He_10;
        private DevExpress.XtraGrid.Columns.GridColumn col_DiemChu;
        private DevExpress.XtraGrid.Columns.GridColumn col_He_4;
        private DevExpress.XtraGrid.Columns.GridColumn col_HocKy;

    }
}