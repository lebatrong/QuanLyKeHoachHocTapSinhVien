namespace DoAn_Win
{
    partial class ucThongTin
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvwThongtin = new DevExpress.XtraGrid.GridControl();
            this.cbbHocKy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblDplus = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCplus = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBplus = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDiemHe4 = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.lblDiemTrungBinh = new System.Windows.Forms.Label();
            this.lblTinChi = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.lblHDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblMonRot = new System.Windows.Forms.LinkLabel();
            this.lblMonDat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHocLuc = new System.Windows.Forms.Label();
            this.lblTBTichLuy = new System.Windows.Forms.Label();
            this.lblSVnam = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Họ và tên:";
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
            this.col_MaMon.Width = 54;
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
            this.col_TenMon.Width = 290;
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
            this.col_SoTinChi.Width = 49;
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
            this.col_Diem_10.Width = 55;
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
            this.col_Diem_40.Width = 60;
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
            this.col_Diem_50.Width = 60;
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
            this.col_He_10.Width = 37;
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
            this.col_DiemChu.Width = 55;
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
            this.col_He_4.Width = 45;
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
            this.col_HocKy.Width = 253;
            // 
            // dgvwThongtin
            // 
            this.dgvwThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwThongtin.Location = new System.Drawing.Point(0, 88);
            this.dgvwThongtin.MainView = this.gridView1;
            this.dgvwThongtin.Name = "dgvwThongtin";
            this.dgvwThongtin.Size = new System.Drawing.Size(976, 241);
            this.dgvwThongtin.TabIndex = 31;
            this.dgvwThongtin.UseEmbeddedNavigator = true;
            this.dgvwThongtin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.Location = new System.Drawing.Point(104, 61);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbHocKy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbHocKy.Size = new System.Drawing.Size(209, 20);
            this.cbbHocKy.TabIndex = 23;
            this.cbbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbbHocKy_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(695, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(16, 16);
            this.label32.TabIndex = 3;
            this.label32.Text = "F";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label24.Location = new System.Drawing.Point(750, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 16);
            this.label24.TabIndex = 20;
            this.label24.Text = "D+";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label31.Location = new System.Drawing.Point(643, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 16);
            this.label31.TabIndex = 19;
            this.label31.Text = "D";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label30.Location = new System.Drawing.Point(695, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 16);
            this.label30.TabIndex = 18;
            this.label30.Text = "C";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label29.Location = new System.Drawing.Point(643, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 16);
            this.label29.TabIndex = 17;
            this.label29.Text = "C+";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label28.Location = new System.Drawing.Point(750, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 16);
            this.label28.TabIndex = 16;
            this.label28.Text = "B";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label27.Location = new System.Drawing.Point(695, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 16);
            this.label27.TabIndex = 15;
            this.label27.Text = "B+";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.Red;
            this.lblF.Location = new System.Drawing.Point(676, 94);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(0, 16);
            this.lblF.TabIndex = 14;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblD.Location = new System.Drawing.Point(626, 94);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(0, 16);
            this.lblD.TabIndex = 13;
            // 
            // lblDplus
            // 
            this.lblDplus.AutoSize = true;
            this.lblDplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDplus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDplus.Location = new System.Drawing.Point(731, 66);
            this.lblDplus.Name = "lblDplus";
            this.lblDplus.Size = new System.Drawing.Size(0, 16);
            this.lblDplus.TabIndex = 12;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblC.Location = new System.Drawing.Point(676, 66);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 16);
            this.lblC.TabIndex = 11;
            // 
            // lblCplus
            // 
            this.lblCplus.AutoSize = true;
            this.lblCplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCplus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCplus.Location = new System.Drawing.Point(626, 66);
            this.lblCplus.Name = "lblCplus";
            this.lblCplus.Size = new System.Drawing.Size(0, 16);
            this.lblCplus.TabIndex = 10;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblB.Location = new System.Drawing.Point(731, 35);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 16);
            this.lblB.TabIndex = 9;
            // 
            // lblBplus
            // 
            this.lblBplus.AutoSize = true;
            this.lblBplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBplus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBplus.Location = new System.Drawing.Point(676, 35);
            this.lblBplus.Name = "lblBplus";
            this.lblBplus.Size = new System.Drawing.Size(0, 16);
            this.lblBplus.TabIndex = 8;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblA.Location = new System.Drawing.Point(626, 35);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 16);
            this.lblA.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(283, 9);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(23, 15);
            this.lblHoTen.TabIndex = 37;
            this.lblHoTen.Text = "HT";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(643, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "A";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(579, 65);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(28, 15);
            this.lblLop.TabIndex = 35;
            this.lblLop.Text = "Lop";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label23.Location = new System.Drawing.Point(499, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 16);
            this.label23.TabIndex = 5;
            this.label23.Text = "Kết quả đạt được:";
            // 
            // lblDiemHe4
            // 
            this.lblDiemHe4.AutoSize = true;
            this.lblDiemHe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemHe4.ForeColor = System.Drawing.Color.Red;
            this.lblDiemHe4.Location = new System.Drawing.Point(275, 115);
            this.lblDiemHe4.Name = "lblDiemHe4";
            this.lblDiemHe4.Size = new System.Drawing.Size(0, 16);
            this.lblDiemHe4.TabIndex = 4;
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXepLoai.ForeColor = System.Drawing.Color.Red;
            this.lblXepLoai.Location = new System.Drawing.Point(202, 115);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(0, 16);
            this.lblXepLoai.TabIndex = 4;
            // 
            // lblDiemTrungBinh
            // 
            this.lblDiemTrungBinh.AutoSize = true;
            this.lblDiemTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTrungBinh.ForeColor = System.Drawing.Color.Red;
            this.lblDiemTrungBinh.Location = new System.Drawing.Point(201, 91);
            this.lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            this.lblDiemTrungBinh.Size = new System.Drawing.Size(15, 16);
            this.lblDiemTrungBinh.TabIndex = 4;
            this.lblDiemTrungBinh.Text = "0";
            // 
            // lblTinChi
            // 
            this.lblTinChi.AutoSize = true;
            this.lblTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinChi.ForeColor = System.Drawing.Color.Red;
            this.lblTinChi.Location = new System.Drawing.Point(158, 33);
            this.lblTinChi.Name = "lblTinChi";
            this.lblTinChi.Size = new System.Drawing.Size(15, 16);
            this.lblTinChi.TabIndex = 4;
            this.lblTinChi.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label25.Location = new System.Drawing.Point(188, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 16);
            this.label25.TabIndex = 21;
            this.label25.Text = "tín chỉ.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(101, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Xếp loại học kỳ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(87, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Trung bình học kỳ:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(283, 37);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(41, 15);
            this.lblMSSV.TabIndex = 36;
            this.lblMSSV.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(49, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Học kỳ:";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::DoAn_Win.Properties.Resources.Button_Refresh_icon;
            this.btnReset.Location = new System.Drawing.Point(6, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(736, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Khóa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hệ ĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã số SV:";
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNganh.Location = new System.Drawing.Point(579, 9);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(42, 15);
            this.lblNganh.TabIndex = 31;
            this.lblNganh.Text = "nganh";
            // 
            // lblHDT
            // 
            this.lblHDT.AutoSize = true;
            this.lblHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDT.Location = new System.Drawing.Point(579, 37);
            this.lblHDT.Name = "lblHDT";
            this.lblHDT.Size = new System.Drawing.Size(37, 15);
            this.lblHDT.TabIndex = 32;
            this.lblHDT.Text = "heDT";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(283, 65);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(55, 15);
            this.lblNgaySinh.TabIndex = 33;
            this.lblNgaySinh.Text = "1/1/1997";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(49, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 16);
            this.label20.TabIndex = 22;
            this.label20.Text = "Số tín chỉ đã học:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblMonRot);
            this.groupControl3.Controls.Add(this.cbbHocKy);
            this.groupControl3.Controls.Add(this.lblMonDat);
            this.groupControl3.Controls.Add(this.label32);
            this.groupControl3.Controls.Add(this.label24);
            this.groupControl3.Controls.Add(this.label31);
            this.groupControl3.Controls.Add(this.label30);
            this.groupControl3.Controls.Add(this.label29);
            this.groupControl3.Controls.Add(this.label28);
            this.groupControl3.Controls.Add(this.label27);
            this.groupControl3.Controls.Add(this.lblF);
            this.groupControl3.Controls.Add(this.lblD);
            this.groupControl3.Controls.Add(this.lblDplus);
            this.groupControl3.Controls.Add(this.lblC);
            this.groupControl3.Controls.Add(this.lblCplus);
            this.groupControl3.Controls.Add(this.lblB);
            this.groupControl3.Controls.Add(this.lblBplus);
            this.groupControl3.Controls.Add(this.lblA);
            this.groupControl3.Controls.Add(this.label26);
            this.groupControl3.Controls.Add(this.label12);
            this.groupControl3.Controls.Add(this.label11);
            this.groupControl3.Controls.Add(this.label23);
            this.groupControl3.Controls.Add(this.lblDiemHe4);
            this.groupControl3.Controls.Add(this.lblXepLoai);
            this.groupControl3.Controls.Add(this.lblHocLuc);
            this.groupControl3.Controls.Add(this.lblTBTichLuy);
            this.groupControl3.Controls.Add(this.lblDiemTrungBinh);
            this.groupControl3.Controls.Add(this.lblTinChi);
            this.groupControl3.Controls.Add(this.label25);
            this.groupControl3.Controls.Add(this.label10);
            this.groupControl3.Controls.Add(this.lblSVnam);
            this.groupControl3.Controls.Add(this.label14);
            this.groupControl3.Controls.Add(this.label13);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.label20);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 329);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(976, 218);
            this.groupControl3.TabIndex = 29;
            this.groupControl3.Text = "Thống kê";
            // 
            // lblMonRot
            // 
            this.lblMonRot.AutoSize = true;
            this.lblMonRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonRot.LinkColor = System.Drawing.Color.Red;
            this.lblMonRot.Location = new System.Drawing.Point(642, 159);
            this.lblMonRot.Name = "lblMonRot";
            this.lblMonRot.Size = new System.Drawing.Size(19, 20);
            this.lblMonRot.TabIndex = 24;
            this.lblMonRot.TabStop = true;
            this.lblMonRot.Text = "0";
            this.lblMonRot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMonRot_LinkClicked);
            // 
            // lblMonDat
            // 
            this.lblMonDat.AutoSize = true;
            this.lblMonDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonDat.ForeColor = System.Drawing.Color.Green;
            this.lblMonDat.Location = new System.Drawing.Point(642, 128);
            this.lblMonDat.Name = "lblMonDat";
            this.lblMonDat.Size = new System.Drawing.Size(18, 20);
            this.lblMonDat.TabIndex = 3;
            this.lblMonDat.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(498, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Số môn chưa đạt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(511, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Số môn đã đạt:";
            // 
            // lblHocLuc
            // 
            this.lblHocLuc.AutoSize = true;
            this.lblHocLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocLuc.ForeColor = System.Drawing.Color.Red;
            this.lblHocLuc.Location = new System.Drawing.Point(275, 139);
            this.lblHocLuc.Name = "lblHocLuc";
            this.lblHocLuc.Size = new System.Drawing.Size(0, 16);
            this.lblHocLuc.TabIndex = 4;
            // 
            // lblTBTichLuy
            // 
            this.lblTBTichLuy.AutoSize = true;
            this.lblTBTichLuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBTichLuy.ForeColor = System.Drawing.Color.Red;
            this.lblTBTichLuy.Location = new System.Drawing.Point(202, 139);
            this.lblTBTichLuy.Name = "lblTBTichLuy";
            this.lblTBTichLuy.Size = new System.Drawing.Size(15, 16);
            this.lblTBTichLuy.TabIndex = 4;
            this.lblTBTichLuy.Text = "0";
            // 
            // lblSVnam
            // 
            this.lblSVnam.AutoSize = true;
            this.lblSVnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSVnam.ForeColor = System.Drawing.Color.Red;
            this.lblSVnam.Location = new System.Drawing.Point(202, 163);
            this.lblSVnam.Name = "lblSVnam";
            this.lblSVnam.Size = new System.Drawing.Size(59, 16);
            this.lblSVnam.TabIndex = 22;
            this.lblSVnam.Text = "Thứ nhất";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(106, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Đang học năm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(47, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Trung bình chung tích lũy:";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkhoa.Location = new System.Drawing.Point(782, 9);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(34, 15);
            this.lblkhoa.TabIndex = 34;
            this.lblkhoa.Text = "khoa";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnReset);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.lblNganh);
            this.panelControl1.Controls.Add(this.lblHDT);
            this.panelControl1.Controls.Add(this.lblNgaySinh);
            this.panelControl1.Controls.Add(this.lblkhoa);
            this.panelControl1.Controls.Add(this.lblLop);
            this.panelControl1.Controls.Add(this.lblMSSV);
            this.panelControl1.Controls.Add(this.lblHoTen);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(976, 88);
            this.panelControl1.TabIndex = 30;
            // 
            // ucThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvwThongtin);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucThongTin";
            this.Size = new System.Drawing.Size(976, 547);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private DevExpress.XtraGrid.GridControl dgvwThongtin;
        private DevExpress.XtraEditors.ComboBoxEdit cbbHocKy;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblDplus;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblCplus;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBplus;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblDiemHe4;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.Label lblDiemTrungBinh;
        private System.Windows.Forms.Label lblTinChi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.Label lblHDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label lblkhoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblMonDat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSVnam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTBTichLuy;
        private System.Windows.Forms.Label lblHocLuc;
        private System.Windows.Forms.LinkLabel lblMonRot;

    }
}
