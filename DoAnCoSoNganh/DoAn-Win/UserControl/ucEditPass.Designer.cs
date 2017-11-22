namespace DoAn_Win
{
    partial class ucEditPass
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
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtpassnew2 = new DevExpress.XtraEditors.TextEdit();
            this.txtpassnew = new DevExpress.XtraEditors.TextEdit();
            this.txtpassold = new DevExpress.XtraEditors.TextEdit();
            this.txtuse = new DevExpress.XtraEditors.TextEdit();
            this.lblErrorPassNew = new System.Windows.Forms.Label();
            this.lblErrorPassOld = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassnew2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassnew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtpassnew2);
            this.groupBox1.Controls.Add(this.txtpassnew);
            this.groupBox1.Controls.Add(this.txtpassold);
            this.groupBox1.Controls.Add(this.txtuse);
            this.groupBox1.Controls.Add(this.lblErrorPassNew);
            this.groupBox1.Controls.Add(this.lblErrorPassOld);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 515);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật mật khẩu";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::DoAn_Win.Properties.Resources.Save_icon;
            this.btnCapNhat.Location = new System.Drawing.Point(440, 289);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(104, 40);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtpassnew2
            // 
            this.txtpassnew2.Location = new System.Drawing.Point(440, 238);
            this.txtpassnew2.Name = "txtpassnew2";
            this.txtpassnew2.Properties.UseSystemPasswordChar = true;
            this.txtpassnew2.Size = new System.Drawing.Size(126, 20);
            this.txtpassnew2.TabIndex = 3;
            this.txtpassnew2.Click += new System.EventHandler(this.txtpassnew2_EditValueChanged);
            // 
            // txtpassnew
            // 
            this.txtpassnew.Location = new System.Drawing.Point(440, 209);
            this.txtpassnew.Name = "txtpassnew";
            this.txtpassnew.Properties.UseSystemPasswordChar = true;
            this.txtpassnew.Size = new System.Drawing.Size(126, 20);
            this.txtpassnew.TabIndex = 2;
            // 
            // txtpassold
            // 
            this.txtpassold.Location = new System.Drawing.Point(440, 177);
            this.txtpassold.Name = "txtpassold";
            this.txtpassold.Properties.UseSystemPasswordChar = true;
            this.txtpassold.Size = new System.Drawing.Size(126, 20);
            this.txtpassold.TabIndex = 1;
            // 
            // txtuse
            // 
            this.txtuse.Enabled = false;
            this.txtuse.Location = new System.Drawing.Point(440, 149);
            this.txtuse.Name = "txtuse";
            this.txtuse.Size = new System.Drawing.Size(126, 20);
            this.txtuse.TabIndex = 32;
            // 
            // lblErrorPassNew
            // 
            this.lblErrorPassNew.AutoSize = true;
            this.lblErrorPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassNew.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassNew.Location = new System.Drawing.Point(573, 243);
            this.lblErrorPassNew.Name = "lblErrorPassNew";
            this.lblErrorPassNew.Size = new System.Drawing.Size(0, 15);
            this.lblErrorPassNew.TabIndex = 30;
            // 
            // lblErrorPassOld
            // 
            this.lblErrorPassOld.AutoSize = true;
            this.lblErrorPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassOld.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassOld.Location = new System.Drawing.Point(573, 182);
            this.lblErrorPassOld.Name = "lblErrorPassOld";
            this.lblErrorPassOld.Size = new System.Drawing.Size(0, 15);
            this.lblErrorPassOld.TabIndex = 31;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(338, 181);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 16);
            this.label36.TabIndex = 24;
            this.label36.Text = "Mật khẩu cũ:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(272, 243);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(148, 16);
            this.label35.TabIndex = 25;
            this.label35.Text = "Xác nhận mật khẩu mới:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(325, 153);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(102, 16);
            this.label38.TabIndex = 26;
            this.label38.Text = "Tên đăng nhập:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(330, 213);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 16);
            this.label34.TabIndex = 27;
            this.label34.Text = "Mật khẩu mới:";
            // 
            // ucEditPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucEditPass";
            this.Size = new System.Drawing.Size(932, 515);
            this.Load += new System.EventHandler(this.ucEditPass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassnew2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassnew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.TextEdit txtpassnew2;
        private DevExpress.XtraEditors.TextEdit txtpassnew;
        private DevExpress.XtraEditors.TextEdit txtpassold;
        private DevExpress.XtraEditors.TextEdit txtuse;
        private System.Windows.Forms.Label lblErrorPassNew;
        private System.Windows.Forms.Label lblErrorPassOld;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label34;
    }
}
