namespace DoAn_Win.UserControl
{
    partial class ucEditMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblErrorTim = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gridCtrlTimMon = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_MaMon_tim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MaMon_tim_Edit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_TenMon_Tim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenMon_Tim_Edit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_TinChi_Tim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TinChi_Tim_Edit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridCtrlThongtinmon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_MaMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SoTinChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTimMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_MaMon_tim_Edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_TenMon_Tim_Edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_TinChi_Tim_Edit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlThongtinmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.lblErrorTim);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.gridCtrlTimMon);
            this.groupBox1.Controls.Add(this.gridCtrlThongtinmon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 270);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(760, 200);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(456, 202);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(298, 21);
            this.txtTim.TabIndex = 1;
            // 
            // lblErrorTim
            // 
            this.lblErrorTim.AutoSize = true;
            this.lblErrorTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTim.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTim.Location = new System.Drawing.Point(453, 230);
            this.lblErrorTim.Name = "lblErrorTim";
            this.lblErrorTim.Size = new System.Drawing.Size(0, 16);
            this.lblErrorTim.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(453, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "Nhập mã môn hoặc tên môn:";
            // 
            // gridCtrlTimMon
            // 
            this.gridCtrlTimMon.Location = new System.Drawing.Point(451, 19);
            this.gridCtrlTimMon.MainView = this.gridView2;
            this.gridCtrlTimMon.Name = "gridCtrlTimMon";
            this.gridCtrlTimMon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_MaMon_tim_Edit1,
            this.col_TenMon_Tim_Edit1,
            this.col_TinChi_Tim_Edit1});
            this.gridCtrlTimMon.Size = new System.Drawing.Size(457, 155);
            this.gridCtrlTimMon.TabIndex = 0;
            this.gridCtrlTimMon.UseEmbeddedNavigator = true;
            this.gridCtrlTimMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridCtrlTimMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridCtrlTimMon_MouseClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_MaMon_tim,
            this.col_TenMon_Tim,
            this.col_TinChi_Tim});
            this.gridView2.GridControl = this.gridCtrlTimMon;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // col_MaMon_tim
            // 
            this.col_MaMon_tim.Caption = "Mã môn";
            this.col_MaMon_tim.ColumnEdit = this.col_MaMon_tim_Edit1;
            this.col_MaMon_tim.FieldName = "MaMon";
            this.col_MaMon_tim.Name = "col_MaMon_tim";
            this.col_MaMon_tim.OptionsColumn.AllowEdit = false;
            this.col_MaMon_tim.OptionsColumn.FixedWidth = true;
            this.col_MaMon_tim.OptionsColumn.ReadOnly = true;
            this.col_MaMon_tim.Visible = true;
            this.col_MaMon_tim.VisibleIndex = 0;
            this.col_MaMon_tim.Width = 73;
            // 
            // col_MaMon_tim_Edit1
            // 
            this.col_MaMon_tim_Edit1.AutoHeight = false;
            this.col_MaMon_tim_Edit1.Name = "col_MaMon_tim_Edit1";
            // 
            // col_TenMon_Tim
            // 
            this.col_TenMon_Tim.Caption = "Tên môn";
            this.col_TenMon_Tim.ColumnEdit = this.col_TenMon_Tim_Edit1;
            this.col_TenMon_Tim.FieldName = "TenMon";
            this.col_TenMon_Tim.Name = "col_TenMon_Tim";
            this.col_TenMon_Tim.OptionsColumn.AllowEdit = false;
            this.col_TenMon_Tim.OptionsColumn.FixedWidth = true;
            this.col_TenMon_Tim.OptionsColumn.ReadOnly = true;
            this.col_TenMon_Tim.Visible = true;
            this.col_TenMon_Tim.VisibleIndex = 1;
            this.col_TenMon_Tim.Width = 296;
            // 
            // col_TenMon_Tim_Edit1
            // 
            this.col_TenMon_Tim_Edit1.AutoHeight = false;
            this.col_TenMon_Tim_Edit1.Name = "col_TenMon_Tim_Edit1";
            // 
            // col_TinChi_Tim
            // 
            this.col_TinChi_Tim.Caption = "Tín chỉ";
            this.col_TinChi_Tim.ColumnEdit = this.col_TinChi_Tim_Edit1;
            this.col_TinChi_Tim.FieldName = "SoTinChi";
            this.col_TinChi_Tim.Name = "col_TinChi_Tim";
            this.col_TinChi_Tim.OptionsColumn.AllowEdit = false;
            this.col_TinChi_Tim.OptionsColumn.FixedWidth = true;
            this.col_TinChi_Tim.OptionsColumn.ReadOnly = true;
            this.col_TinChi_Tim.Visible = true;
            this.col_TinChi_Tim.VisibleIndex = 2;
            this.col_TinChi_Tim.Width = 70;
            // 
            // col_TinChi_Tim_Edit1
            // 
            this.col_TinChi_Tim_Edit1.AutoHeight = false;
            this.col_TinChi_Tim_Edit1.Name = "col_TinChi_Tim_Edit1";
            // 
            // gridCtrlThongtinmon
            // 
            this.gridCtrlThongtinmon.Location = new System.Drawing.Point(3, 17);
            this.gridCtrlThongtinmon.MainView = this.gridView1;
            this.gridCtrlThongtinmon.Name = "gridCtrlThongtinmon";
            this.gridCtrlThongtinmon.Size = new System.Drawing.Size(439, 248);
            this.gridCtrlThongtinmon.TabIndex = 0;
            this.gridCtrlThongtinmon.UseEmbeddedNavigator = true;
            this.gridCtrlThongtinmon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCtrlThongtinmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridCtrlThongtinmon_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_MaMon,
            this.col_TenMon,
            this.col_SoTinChi});
            this.gridView1.GridControl = this.gridCtrlThongtinmon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.col_MaMon.Width = 68;
            // 
            // col_TenMon
            // 
            this.col_TenMon.Caption = "Tên môn";
            this.col_TenMon.FieldName = "TenMon";
            this.col_TenMon.Name = "col_TenMon";
            this.col_TenMon.OptionsColumn.AllowEdit = false;
            this.col_TenMon.OptionsColumn.FixedWidth = true;
            this.col_TenMon.OptionsColumn.ReadOnly = true;
            this.col_TenMon.Visible = true;
            this.col_TenMon.VisibleIndex = 1;
            this.col_TenMon.Width = 271;
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
            this.col_SoTinChi.Width = 82;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.txtTinChi);
            this.panelControl1.Controls.Add(this.txtTenMon);
            this.panelControl1.Controls.Add(this.txtmamon);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 270);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(914, 214);
            this.panelControl1.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(532, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(760, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 58);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(389, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(252, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTinChi
            // 
            this.txtTinChi.Enabled = false;
            this.txtTinChi.Location = new System.Drawing.Point(648, 58);
            this.txtTinChi.MaxLength = 2;
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(62, 21);
            this.txtTinChi.TabIndex = 5;
            this.txtTinChi.TextChanged += new System.EventHandler(this.txtTinChi_TextChanged);
            this.txtTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTinChi_KeyPress);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Enabled = false;
            this.txtTenMon.Location = new System.Drawing.Point(330, 58);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(201, 21);
            this.txtTenMon.TabIndex = 4;
            // 
            // txtmamon
            // 
            this.txtmamon.Enabled = false;
            this.txtmamon.Location = new System.Drawing.Point(130, 58);
            this.txtmamon.MaxLength = 6;
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(75, 21);
            this.txtmamon.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(581, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Số tín chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tên môn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Mã môn học:";
            // 
            // ucEditMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucEditMonHoc";
            this.Size = new System.Drawing.Size(914, 484);
            this.Load += new System.EventHandler(this.ucEditMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTimMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_MaMon_tim_Edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_TenMon_Tim_Edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_TinChi_Tim_Edit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlThongtinmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblErrorTim;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraGrid.GridControl gridCtrlTimMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaMon_tim;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_MaMon_tim_Edit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenMon_Tim;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_TenMon_Tim_Edit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_TinChi_Tim;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_TinChi_Tim_Edit1;
        private DevExpress.XtraGrid.GridControl gridCtrlThongtinmon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaMon;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenMon;
        private DevExpress.XtraGrid.Columns.GridColumn col_SoTinChi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinChi;
    }
}
