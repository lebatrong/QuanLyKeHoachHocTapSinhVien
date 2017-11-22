namespace DoAn_Win.UserControl
{
    partial class ucAddMon
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvwMonHoc = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddMon = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBro = new DevExpress.XtraEditors.SimpleButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwMonHoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 529);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvwMonHoc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 427);
            this.panel4.TabIndex = 2;
            // 
            // dtgvwMonHoc
            // 
            this.dtgvwMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvwMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvwMonHoc.Location = new System.Drawing.Point(0, 0);
            this.dtgvwMonHoc.Name = "dtgvwMonHoc";
            this.dtgvwMonHoc.Size = new System.Drawing.Size(1005, 427);
            this.dtgvwMonHoc.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddMon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 67);
            this.panel3.TabIndex = 1;
            // 
            // btnAddMon
            // 
            this.btnAddMon.Image = global::DoAn_Win.Properties.Resources._07_plus_32;
            this.btnAddMon.Location = new System.Drawing.Point(47, 6);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(130, 42);
            this.btnAddMon.TabIndex = 0;
            this.btnAddMon.Text = "Thêm môn";
            this.btnAddMon.Click += new System.EventHandler(this.btnAddMon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBro);
            this.panel2.Controls.Add(this.lblPath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 35);
            this.panel2.TabIndex = 0;
            // 
            // btnBro
            // 
            this.btnBro.Location = new System.Drawing.Point(30, 6);
            this.btnBro.Name = "btnBro";
            this.btnBro.Size = new System.Drawing.Size(75, 23);
            this.btnBro.TabIndex = 1;
            this.btnBro.Text = "Browse...";
            this.btnBro.Click += new System.EventHandler(this.btnBro_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(150, 13);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // ucAddMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucAddMon";
            this.Size = new System.Drawing.Size(1005, 529);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwMonHoc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnAddMon;
        private System.Windows.Forms.DataGridView dtgvwMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnBro;
    }
}
