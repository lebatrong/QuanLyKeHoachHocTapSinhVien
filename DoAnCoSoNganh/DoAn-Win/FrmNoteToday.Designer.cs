namespace DoAn_Win
{
    partial class FrmNoteToday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoteToday));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcNote = new DevExpress.XtraGrid.GridControl();
            this.gvNote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TieuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC GHI CHÚ";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.groupBox1);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(664, 432);
            this.pnMain.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcNote);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ghi chú";
            // 
            // gcNote
            // 
            this.gcNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNote.Location = new System.Drawing.Point(3, 17);
            this.gcNote.MainView = this.gvNote;
            this.gcNote.Name = "gcNote";
            this.gcNote.Size = new System.Drawing.Size(658, 312);
            this.gcNote.TabIndex = 1;
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
            this.col_NgayLap});
            this.gvNote.GridControl = this.gcNote;
            this.gvNote.Name = "gvNote";
            this.gvNote.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // col_STT
            // 
            this.col_STT.Caption = "ID";
            this.col_STT.FieldName = "Id";
            this.col_STT.Name = "col_STT";
            this.col_STT.OptionsColumn.AllowEdit = false;
            this.col_STT.OptionsColumn.FixedWidth = true;
            this.col_STT.OptionsColumn.ReadOnly = true;
            this.col_STT.Width = 56;
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
            this.col_TieuDe.Width = 550;
            // 
            // col_NgayLap
            // 
            this.col_NgayLap.Caption = "Ngày lập";
            this.col_NgayLap.FieldName = "NgayLap";
            this.col_NgayLap.Name = "col_NgayLap";
            this.col_NgayLap.OptionsColumn.AllowEdit = false;
            this.col_NgayLap.OptionsColumn.FixedWidth = true;
            this.col_NgayLap.OptionsColumn.ReadOnly = true;
            this.col_NgayLap.Visible = true;
            this.col_NgayLap.VisibleIndex = 1;
            this.col_NgayLap.Width = 181;
            // 
            // FrmNoteToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 432);
            this.Controls.Add(this.pnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNoteToday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo hôm nay";
            this.Activated += new System.EventHandler(this.FrmNoteToday_Activated);
            this.Load += new System.EventHandler(this.FrmNoteToday_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcNote;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNote;
        private DevExpress.XtraGrid.Columns.GridColumn col_STT;
        private DevExpress.XtraGrid.Columns.GridColumn col_TieuDe;
        private DevExpress.XtraGrid.Columns.GridColumn col_NgayLap;
    }
}