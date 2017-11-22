namespace DoAn_Win
{
    partial class ucEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.GrbMonHoc = new System.Windows.Forms.GroupBox();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.lblerrorLoiXoa = new System.Windows.Forms.Label();
            this.txtkq10update = new System.Windows.Forms.TextBox();
            this.txtkq4update = new System.Windows.Forms.TextBox();
            this.txtkqChuUpdate = new System.Windows.Forms.TextBox();
            this.txtdiem50update = new System.Windows.Forms.TextBox();
            this.txtdiem40update = new System.Windows.Forms.TextBox();
            this.txtdiem10update = new System.Windows.Forms.TextBox();
            this.txtTinChiUpdate = new System.Windows.Forms.TextBox();
            this.txtTenMonUpdate = new System.Windows.Forms.TextBox();
            this.txtMaMonUpdate = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblErrorUpdate50 = new System.Windows.Forms.Label();
            this.lblErrorUpdate40 = new System.Windows.Forms.Label();
            this.lblErrorUpdate10 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.chkMonDatBiet = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.GrbMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMonDatBiet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(977, 550);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.groupBox1);
            this.panelControl3.Controls.Add(this.GrbMonHoc);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(973, 546);
            this.panelControl3.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvwThongtin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 300);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn đã học";
            // 
            // dgvwThongtin
            // 
            this.dgvwThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvwThongtin.Location = new System.Drawing.Point(3, 17);
            this.dgvwThongtin.MainView = this.gridView1;
            this.dgvwThongtin.Name = "dgvwThongtin";
            this.dgvwThongtin.Size = new System.Drawing.Size(963, 244);
            this.dgvwThongtin.TabIndex = 27;
            this.dgvwThongtin.UseEmbeddedNavigator = true;
            this.dgvwThongtin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvwThongtin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvwThongtin_MouseClick);
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
            this.col_MaMon.OptionsColumn.FixedWidth = true;
            this.col_MaMon.OptionsColumn.ReadOnly = true;
            this.col_MaMon.Visible = true;
            this.col_MaMon.VisibleIndex = 0;
            this.col_MaMon.Width = 69;
            // 
            // col_TenMon
            // 
            this.col_TenMon.Caption = "Tên môn học";
            this.col_TenMon.FieldName = "TenMon";
            this.col_TenMon.Name = "col_TenMon";
            this.col_TenMon.OptionsColumn.AllowEdit = false;
            this.col_TenMon.OptionsColumn.FixedWidth = true;
            this.col_TenMon.OptionsColumn.ReadOnly = true;
            this.col_TenMon.Visible = true;
            this.col_TenMon.VisibleIndex = 1;
            this.col_TenMon.Width = 260;
            // 
            // col_SoTinChi
            // 
            this.col_SoTinChi.Caption = "Tín chỉ";
            this.col_SoTinChi.FieldName = "SoTinChi";
            this.col_SoTinChi.Name = "col_SoTinChi";
            this.col_SoTinChi.OptionsColumn.AllowEdit = false;
            this.col_SoTinChi.OptionsColumn.FixedWidth = true;
            this.col_SoTinChi.OptionsColumn.ReadOnly = true;
            this.col_SoTinChi.Visible = true;
            this.col_SoTinChi.VisibleIndex = 2;
            this.col_SoTinChi.Width = 44;
            // 
            // col_Diem_10
            // 
            this.col_Diem_10.Caption = "Điểm CC";
            this.col_Diem_10.FieldName = "Diem_10";
            this.col_Diem_10.Name = "col_Diem_10";
            this.col_Diem_10.OptionsColumn.AllowEdit = false;
            this.col_Diem_10.OptionsColumn.FixedWidth = true;
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
            this.col_Diem_40.OptionsColumn.FixedWidth = true;
            this.col_Diem_40.OptionsColumn.ReadOnly = true;
            this.col_Diem_40.Visible = true;
            this.col_Diem_40.VisibleIndex = 4;
            this.col_Diem_40.Width = 54;
            // 
            // col_Diem_50
            // 
            this.col_Diem_50.Caption = "Điểm CK";
            this.col_Diem_50.FieldName = "Diem_50";
            this.col_Diem_50.Name = "col_Diem_50";
            this.col_Diem_50.OptionsColumn.AllowEdit = false;
            this.col_Diem_50.OptionsColumn.FixedWidth = true;
            this.col_Diem_50.OptionsColumn.ReadOnly = true;
            this.col_Diem_50.Visible = true;
            this.col_Diem_50.VisibleIndex = 5;
            this.col_Diem_50.Width = 54;
            // 
            // col_He_10
            // 
            this.col_He_10.Caption = "Hệ 10";
            this.col_He_10.FieldName = "He_10";
            this.col_He_10.Name = "col_He_10";
            this.col_He_10.OptionsColumn.AllowEdit = false;
            this.col_He_10.OptionsColumn.FixedWidth = true;
            this.col_He_10.OptionsColumn.ReadOnly = true;
            this.col_He_10.Visible = true;
            this.col_He_10.VisibleIndex = 6;
            this.col_He_10.Width = 45;
            // 
            // col_DiemChu
            // 
            this.col_DiemChu.Caption = "Điểm chữ";
            this.col_DiemChu.FieldName = "DiemChu";
            this.col_DiemChu.Name = "col_DiemChu";
            this.col_DiemChu.OptionsColumn.AllowEdit = false;
            this.col_DiemChu.OptionsColumn.FixedWidth = true;
            this.col_DiemChu.OptionsColumn.ReadOnly = true;
            this.col_DiemChu.Visible = true;
            this.col_DiemChu.VisibleIndex = 7;
            this.col_DiemChu.Width = 57;
            // 
            // col_He_4
            // 
            this.col_He_4.Caption = "Hệ 4";
            this.col_He_4.FieldName = "He_4";
            this.col_He_4.Name = "col_He_4";
            this.col_He_4.OptionsColumn.AllowEdit = false;
            this.col_He_4.OptionsColumn.FixedWidth = true;
            this.col_He_4.OptionsColumn.ReadOnly = true;
            this.col_He_4.Visible = true;
            this.col_He_4.VisibleIndex = 8;
            this.col_He_4.Width = 39;
            // 
            // col_HocKy
            // 
            this.col_HocKy.Caption = "Học kỳ";
            this.col_HocKy.FieldName = "HocKy";
            this.col_HocKy.Name = "col_HocKy";
            this.col_HocKy.OptionsColumn.AllowEdit = false;
            this.col_HocKy.OptionsColumn.FixedWidth = true;
            this.col_HocKy.OptionsColumn.ReadOnly = true;
            this.col_HocKy.Visible = true;
            this.col_HocKy.VisibleIndex = 9;
            this.col_HocKy.Width = 203;
            // 
            // GrbMonHoc
            // 
            this.GrbMonHoc.Controls.Add(this.chkMonDatBiet);
            this.GrbMonHoc.Controls.Add(this.txtHocKy);
            this.GrbMonHoc.Controls.Add(this.labelControl1);
            this.GrbMonHoc.Controls.Add(this.btnTest);
            this.GrbMonHoc.Controls.Add(this.btnCapNhatMon);
            this.GrbMonHoc.Controls.Add(this.btnDeleteMon);
            this.GrbMonHoc.Controls.Add(this.btnView);
            this.GrbMonHoc.Controls.Add(this.btnReset);
            this.GrbMonHoc.Controls.Add(this.lblerrorLoiXoa);
            this.GrbMonHoc.Controls.Add(this.txtkq10update);
            this.GrbMonHoc.Controls.Add(this.txtkq4update);
            this.GrbMonHoc.Controls.Add(this.txtkqChuUpdate);
            this.GrbMonHoc.Controls.Add(this.txtdiem50update);
            this.GrbMonHoc.Controls.Add(this.txtdiem40update);
            this.GrbMonHoc.Controls.Add(this.txtdiem10update);
            this.GrbMonHoc.Controls.Add(this.txtTinChiUpdate);
            this.GrbMonHoc.Controls.Add(this.txtTenMonUpdate);
            this.GrbMonHoc.Controls.Add(this.txtMaMonUpdate);
            this.GrbMonHoc.Controls.Add(this.label39);
            this.GrbMonHoc.Controls.Add(this.label22);
            this.GrbMonHoc.Controls.Add(this.label45);
            this.GrbMonHoc.Controls.Add(this.label44);
            this.GrbMonHoc.Controls.Add(this.label43);
            this.GrbMonHoc.Controls.Add(this.label42);
            this.GrbMonHoc.Controls.Add(this.label41);
            this.GrbMonHoc.Controls.Add(this.lblErrorUpdate50);
            this.GrbMonHoc.Controls.Add(this.lblErrorUpdate40);
            this.GrbMonHoc.Controls.Add(this.lblErrorUpdate10);
            this.GrbMonHoc.Controls.Add(this.label40);
            this.GrbMonHoc.Controls.Add(this.label21);
            this.GrbMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrbMonHoc.Location = new System.Drawing.Point(2, 302);
            this.GrbMonHoc.Name = "GrbMonHoc";
            this.GrbMonHoc.Size = new System.Drawing.Size(969, 242);
            this.GrbMonHoc.TabIndex = 13;
            this.GrbMonHoc.TabStop = false;
            this.GrbMonHoc.Text = "Môn học:";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(210, 32);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(295, 20);
            this.txtHocKy.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(156, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Học kỳ:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(316, 62);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Kiểm tra";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCapNhatMon
            // 
            this.btnCapNhatMon.Enabled = false;
            this.btnCapNhatMon.Location = new System.Drawing.Point(529, 204);
            this.btnCapNhatMon.Name = "btnCapNhatMon";
            this.btnCapNhatMon.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatMon.TabIndex = 10;
            this.btnCapNhatMon.Text = "Cập nhật";
            this.btnCapNhatMon.Click += new System.EventHandler(this.btnCapNhatMon_Click);
            // 
            // btnDeleteMon
            // 
            this.btnDeleteMon.Location = new System.Drawing.Point(640, 204);
            this.btnDeleteMon.Name = "btnDeleteMon";
            this.btnDeleteMon.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMon.TabIndex = 10;
            this.btnDeleteMon.Text = "Xóa môn";
            this.btnDeleteMon.Click += new System.EventHandler(this.btnDeleteMon_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(418, 204);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "Xem trước";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(307, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblerrorLoiXoa
            // 
            this.lblerrorLoiXoa.AutoSize = true;
            this.lblerrorLoiXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorLoiXoa.ForeColor = System.Drawing.Color.Red;
            this.lblerrorLoiXoa.Location = new System.Drawing.Point(138, 186);
            this.lblerrorLoiXoa.Name = "lblerrorLoiXoa";
            this.lblerrorLoiXoa.Size = new System.Drawing.Size(0, 15);
            this.lblerrorLoiXoa.TabIndex = 4;
            // 
            // txtkq10update
            // 
            this.txtkq10update.Enabled = false;
            this.txtkq10update.ForeColor = System.Drawing.Color.Red;
            this.txtkq10update.Location = new System.Drawing.Point(210, 148);
            this.txtkq10update.Name = "txtkq10update";
            this.txtkq10update.Size = new System.Drawing.Size(46, 21);
            this.txtkq10update.TabIndex = 3;
            this.txtkq10update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkq4update
            // 
            this.txtkq4update.Enabled = false;
            this.txtkq4update.ForeColor = System.Drawing.Color.Red;
            this.txtkq4update.Location = new System.Drawing.Point(501, 148);
            this.txtkq4update.Name = "txtkq4update";
            this.txtkq4update.Size = new System.Drawing.Size(46, 21);
            this.txtkq4update.TabIndex = 3;
            this.txtkq4update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkqChuUpdate
            // 
            this.txtkqChuUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtkqChuUpdate.Enabled = false;
            this.txtkqChuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkqChuUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtkqChuUpdate.Location = new System.Drawing.Point(754, 148);
            this.txtkqChuUpdate.Name = "txtkqChuUpdate";
            this.txtkqChuUpdate.Size = new System.Drawing.Size(46, 20);
            this.txtkqChuUpdate.TabIndex = 3;
            this.txtkqChuUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdiem50update
            // 
            this.txtdiem50update.Location = new System.Drawing.Point(754, 106);
            this.txtdiem50update.Name = "txtdiem50update";
            this.txtdiem50update.Size = new System.Drawing.Size(46, 21);
            this.txtdiem50update.TabIndex = 5;
            // 
            // txtdiem40update
            // 
            this.txtdiem40update.Location = new System.Drawing.Point(501, 106);
            this.txtdiem40update.Name = "txtdiem40update";
            this.txtdiem40update.Size = new System.Drawing.Size(46, 21);
            this.txtdiem40update.TabIndex = 4;
            // 
            // txtdiem10update
            // 
            this.txtdiem10update.Location = new System.Drawing.Point(210, 106);
            this.txtdiem10update.Name = "txtdiem10update";
            this.txtdiem10update.Size = new System.Drawing.Size(46, 21);
            this.txtdiem10update.TabIndex = 3;
            // 
            // txtTinChiUpdate
            // 
            this.txtTinChiUpdate.Enabled = false;
            this.txtTinChiUpdate.Location = new System.Drawing.Point(754, 64);
            this.txtTinChiUpdate.Name = "txtTinChiUpdate";
            this.txtTinChiUpdate.Size = new System.Drawing.Size(42, 21);
            this.txtTinChiUpdate.TabIndex = 1;
            // 
            // txtTenMonUpdate
            // 
            this.txtTenMonUpdate.Enabled = false;
            this.txtTenMonUpdate.Location = new System.Drawing.Point(501, 64);
            this.txtTenMonUpdate.Name = "txtTenMonUpdate";
            this.txtTenMonUpdate.Size = new System.Drawing.Size(173, 21);
            this.txtTenMonUpdate.TabIndex = 1;
            // 
            // txtMaMonUpdate
            // 
            this.txtMaMonUpdate.Location = new System.Drawing.Point(210, 64);
            this.txtMaMonUpdate.Name = "txtMaMonUpdate";
            this.txtMaMonUpdate.Size = new System.Drawing.Size(84, 21);
            this.txtMaMonUpdate.TabIndex = 1;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(688, 69);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 15);
            this.label39.TabIndex = 0;
            this.label39.Text = "Số tín chỉ:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(420, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Tên môn học:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(680, 153);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 15);
            this.label45.TabIndex = 0;
            this.label45.Text = "Điểm chữ:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(427, 153);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(67, 15);
            this.label44.TabIndex = 0;
            this.label44.Text = "Điểm hệ 4:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(130, 153);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(74, 15);
            this.label43.TabIndex = 0;
            this.label43.Text = "Điểm hệ 10:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(680, 111);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 15);
            this.label42.TabIndex = 0;
            this.label42.Text = "Điểm 50%:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(427, 111);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(68, 15);
            this.label41.TabIndex = 0;
            this.label41.Text = "Điểm 40%:";
            // 
            // lblErrorUpdate50
            // 
            this.lblErrorUpdate50.AutoSize = true;
            this.lblErrorUpdate50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUpdate50.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUpdate50.Location = new System.Drawing.Point(806, 111);
            this.lblErrorUpdate50.Name = "lblErrorUpdate50";
            this.lblErrorUpdate50.Size = new System.Drawing.Size(0, 15);
            this.lblErrorUpdate50.TabIndex = 0;
            // 
            // lblErrorUpdate40
            // 
            this.lblErrorUpdate40.AutoSize = true;
            this.lblErrorUpdate40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUpdate40.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUpdate40.Location = new System.Drawing.Point(555, 111);
            this.lblErrorUpdate40.Name = "lblErrorUpdate40";
            this.lblErrorUpdate40.Size = new System.Drawing.Size(0, 15);
            this.lblErrorUpdate40.TabIndex = 0;
            // 
            // lblErrorUpdate10
            // 
            this.lblErrorUpdate10.AutoSize = true;
            this.lblErrorUpdate10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUpdate10.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUpdate10.Location = new System.Drawing.Point(269, 111);
            this.lblErrorUpdate10.Name = "lblErrorUpdate10";
            this.lblErrorUpdate10.Size = new System.Drawing.Size(0, 15);
            this.lblErrorUpdate10.TabIndex = 0;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(136, 111);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 15);
            this.label40.TabIndex = 0;
            this.label40.Text = "Điểm 10%:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(125, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Mã môn học:";
            // 
            // chkMonDatBiet
            // 
            this.chkMonDatBiet.Location = new System.Drawing.Point(529, 35);
            this.chkMonDatBiet.Name = "chkMonDatBiet";
            this.chkMonDatBiet.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.chkMonDatBiet.Properties.Appearance.Options.UseForeColor = true;
            this.chkMonDatBiet.Properties.Caption = "Môn đặt biệt";
            this.chkMonDatBiet.Size = new System.Drawing.Size(93, 19);
            this.chkMonDatBiet.TabIndex = 13;
            this.chkMonDatBiet.CheckedChanged += new System.EventHandler(this.chkMonDatBiet_CheckedChanged);
            // 
            // ucEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucEdit";
            this.Size = new System.Drawing.Size(977, 550);
            this.Load += new System.EventHandler(this.ucEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.GrbMonHoc.ResumeLayout(false);
            this.GrbMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMonDatBiet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox GrbMonHoc;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatMon;
        private DevExpress.XtraEditors.SimpleButton btnDeleteMon;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private System.Windows.Forms.Label lblerrorLoiXoa;
        private System.Windows.Forms.TextBox txtkq10update;
        private System.Windows.Forms.TextBox txtkq4update;
        private System.Windows.Forms.TextBox txtkqChuUpdate;
        private System.Windows.Forms.TextBox txtdiem50update;
        private System.Windows.Forms.TextBox txtdiem40update;
        private System.Windows.Forms.TextBox txtdiem10update;
        private System.Windows.Forms.TextBox txtTinChiUpdate;
        private System.Windows.Forms.TextBox txtTenMonUpdate;
        private System.Windows.Forms.TextBox txtMaMonUpdate;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblErrorUpdate50;
        private System.Windows.Forms.Label lblErrorUpdate40;
        private System.Windows.Forms.Label lblErrorUpdate10;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.CheckEdit chkMonDatBiet;
    }
}
