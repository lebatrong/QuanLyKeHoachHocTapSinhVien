namespace DoAn_Win.UserControl
{
    partial class ucNote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.nmrMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdNote = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.txtTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.MemoNoiDung = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcNote = new DevExpress.XtraGrid.GridControl();
            this.gvNote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TieuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.nmrMinute);
            this.panel3.Controls.Add(this.nmrHours);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnAdNote);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.txtTieuDe);
            this.panel3.Controls.Add(this.MemoNoiDung);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 260);
            this.panel3.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::DoAn_Win.Properties.Resources.Button_Refresh_icon;
            this.btnRefresh.Location = new System.Drawing.Point(835, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 51);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // nmrMinute
            // 
            this.nmrMinute.Enabled = false;
            this.nmrMinute.Location = new System.Drawing.Point(632, 104);
            this.nmrMinute.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.nmrMinute.Name = "nmrMinute";
            this.nmrMinute.Size = new System.Drawing.Size(40, 21);
            this.nmrMinute.TabIndex = 5;
            this.nmrMinute.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nmrHours
            // 
            this.nmrHours.Enabled = false;
            this.nmrHours.Location = new System.Drawing.Point(542, 104);
            this.nmrHours.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(40, 21);
            this.nmrHours.TabIndex = 4;
            this.nmrHours.ValueChanged += new System.EventHandler(this.nmrHours_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phút:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giờ:";
            // 
            // btnAdNote
            // 
            this.btnAdNote.Image = global::DoAn_Win.Properties.Resources._07_plus_32;
            this.btnAdNote.Location = new System.Drawing.Point(720, 92);
            this.btnAdNote.Name = "btnAdNote";
            this.btnAdNote.Size = new System.Drawing.Size(109, 51);
            this.btnAdNote.TabIndex = 6;
            this.btnAdNote.Text = "Thêm mới";
            this.btnAdNote.Click += new System.EventHandler(this.btnAdNote_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(720, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::DoAn_Win.Properties.Resources.Save_icon;
            this.btnSave.Location = new System.Drawing.Point(810, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(720, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Làm lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Enabled = false;
            this.txtTieuDe.Location = new System.Drawing.Point(169, 61);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(245, 20);
            this.txtTieuDe.TabIndex = 1;
            this.txtTieuDe.EditValueChanged += new System.EventHandler(this.txtTieuDe_EditValueChanged);
            this.txtTieuDe.Leave += new System.EventHandler(this.txtTieuDe_Leave);
            // 
            // MemoNoiDung
            // 
            this.MemoNoiDung.Enabled = false;
            this.MemoNoiDung.Location = new System.Drawing.Point(169, 99);
            this.MemoNoiDung.Name = "MemoNoiDung";
            this.MemoNoiDung.Size = new System.Drawing.Size(245, 115);
            this.MemoNoiDung.TabIndex = 2;
            this.MemoNoiDung.EditValueChanged += new System.EventHandler(this.MemoNoiDung_EditValueChanged);
            this.MemoNoiDung.Leave += new System.EventHandler(this.MemoNoiDung_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(365, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "GHI CHÚ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nội dung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề:";
            // 
            // dateTime
            // 
            this.dateTime.EditValue = null;
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(527, 61);
            this.dateTime.Name = "dateTime";
            this.dateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Size = new System.Drawing.Size(157, 20);
            this.dateTime.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcNote);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ghi chú:";
            // 
            // gcNote
            // 
            this.gcNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNote.Location = new System.Drawing.Point(3, 17);
            this.gcNote.MainView = this.gvNote;
            this.gcNote.Name = "gcNote";
            this.gcNote.Size = new System.Drawing.Size(935, 239);
            this.gcNote.TabIndex = 0;
            this.gcNote.UseEmbeddedNavigator = true;
            this.gcNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNote});
            this.gcNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcNote_MouseClick);
            // 
            // gvNote
            // 
            this.gvNote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_STT,
            this.col_TieuDe,
            this.col_NgayTao});
            this.gvNote.GridControl = this.gcNote;
            this.gvNote.Name = "gvNote";
            this.gvNote.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // col_STT
            // 
            this.col_STT.Caption = "ID";
            this.col_STT.FieldName = "Id";
            this.col_STT.Name = "col_STT";
            this.col_STT.OptionsColumn.FixedWidth = true;
            this.col_STT.Width = 42;
            // 
            // col_TieuDe
            // 
            this.col_TieuDe.Caption = "Tiêu đề";
            this.col_TieuDe.FieldName = "TieuDe";
            this.col_TieuDe.Name = "col_TieuDe";
            this.col_TieuDe.OptionsColumn.AllowEdit = false;
            this.col_TieuDe.OptionsColumn.FixedWidth = true;
            this.col_TieuDe.OptionsColumn.ReadOnly = true;
            this.col_TieuDe.Visible = true;
            this.col_TieuDe.VisibleIndex = 0;
            this.col_TieuDe.Width = 650;
            // 
            // col_NgayTao
            // 
            this.col_NgayTao.Caption = "Ngày tạo";
            this.col_NgayTao.FieldName = "NgayLap";
            this.col_NgayTao.Name = "col_NgayTao";
            this.col_NgayTao.OptionsColumn.AllowEdit = false;
            this.col_NgayTao.OptionsColumn.FixedWidth = true;
            this.col_NgayTao.OptionsColumn.ReadOnly = true;
            this.col_NgayTao.Visible = true;
            this.col_NgayTao.VisibleIndex = 1;
            this.col_NgayTao.Width = 222;
            // 
            // ucNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucNote";
            this.Size = new System.Drawing.Size(941, 519);
            this.Load += new System.EventHandler(this.ucNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAdNote;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.TextEdit txtTieuDe;
        private DevExpress.XtraEditors.MemoEdit MemoNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gcNote;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNote;
        private DevExpress.XtraGrid.Columns.GridColumn col_TieuDe;
        private DevExpress.XtraGrid.Columns.GridColumn col_NgayTao;
        private System.Windows.Forms.NumericUpDown nmrMinute;
        private System.Windows.Forms.NumericUpDown nmrHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn col_STT;
    }
}
