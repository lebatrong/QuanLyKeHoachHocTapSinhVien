namespace DoAn_Win
{
    partial class frmNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNote));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nmrMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrHours = new System.Windows.Forms.NumericUpDown();
            this.dtpThucHien = new DevExpress.XtraEditors.DateEdit();
            this.dtpNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.memoNoiDung = new DevExpress.XtraEditors.MemoEdit();
            this.memoTieuDe = new DevExpress.XtraEditors.MemoEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThucHien.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThucHien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTieuDe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nmrMinute);
            this.panelControl1.Controls.Add(this.nmrHours);
            this.panelControl1.Controls.Add(this.dtpThucHien);
            this.panelControl1.Controls.Add(this.dtpNgayLap);
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.memoNoiDung);
            this.panelControl1.Controls.Add(this.memoTieuDe);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 461);
            this.panelControl1.TabIndex = 0;
            // 
            // nmrMinute
            // 
            this.nmrMinute.Enabled = false;
            this.nmrMinute.Location = new System.Drawing.Point(362, 396);
            this.nmrMinute.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.nmrMinute.Name = "nmrMinute";
            this.nmrMinute.Size = new System.Drawing.Size(40, 21);
            this.nmrMinute.TabIndex = 8;
            this.nmrMinute.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nmrHours
            // 
            this.nmrHours.Enabled = false;
            this.nmrHours.Location = new System.Drawing.Point(272, 396);
            this.nmrHours.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrHours.Name = "nmrHours";
            this.nmrHours.Size = new System.Drawing.Size(40, 21);
            this.nmrHours.TabIndex = 8;
            this.nmrHours.ValueChanged += new System.EventHandler(this.nmrHours_ValueChanged);
            // 
            // dtpThucHien
            // 
            this.dtpThucHien.EditValue = null;
            this.dtpThucHien.Location = new System.Drawing.Point(272, 368);
            this.dtpThucHien.Name = "dtpThucHien";
            this.dtpThucHien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpThucHien.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpThucHien.Properties.ReadOnly = true;
            this.dtpThucHien.Size = new System.Drawing.Size(143, 20);
            this.dtpThucHien.TabIndex = 7;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.EditValue = null;
            this.dtpNgayLap.Location = new System.Drawing.Point(272, 338);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayLap.Properties.ReadOnly = true;
            this.dtpNgayLap.Size = new System.Drawing.Size(143, 20);
            this.dtpNgayLap.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(489, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(489, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(489, 205);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(489, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // memoNoiDung
            // 
            this.memoNoiDung.Location = new System.Drawing.Point(124, 146);
            this.memoNoiDung.Name = "memoNoiDung";
            this.memoNoiDung.Properties.ReadOnly = true;
            this.memoNoiDung.Size = new System.Drawing.Size(291, 175);
            this.memoNoiDung.TabIndex = 2;
            // 
            // memoTieuDe
            // 
            this.memoTieuDe.Location = new System.Drawing.Point(124, 74);
            this.memoTieuDe.Name = "memoTieuDe";
            this.memoTieuDe.Properties.ReadOnly = true;
            this.memoTieuDe.Size = new System.Drawing.Size(291, 47);
            this.memoTieuDe.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phút:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giờ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày thực hiện công việc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nội dung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(214, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "CHI TIẾT GHI CHÚ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề:";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 461);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNote";
            this.Text = "Chi tiết ghi chú";
            this.Load += new System.EventHandler(this.frmNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThucHien.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThucHien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTieuDe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit memoNoiDung;
        private DevExpress.XtraEditors.MemoEdit memoTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtpThucHien;
        private DevExpress.XtraEditors.DateEdit dtpNgayLap;
        private System.Windows.Forms.NumericUpDown nmrMinute;
        private System.Windows.Forms.NumericUpDown nmrHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}