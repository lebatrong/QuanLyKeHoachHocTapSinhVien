using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAn_Win.UserControl
{
    public partial class ucInformation : DevExpress.XtraEditors.XtraUserControl
    {
        int speed = 1;

        Point plblInfo;
        public ucInformation()
        {
            InitializeComponent();
            plblInfo = lblInfo.Location;
            timer1.Start();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = new Point(lblInfo.Location.X, lblInfo.Location.Y-speed);
            if(p.Y>-lblInfo.Height)
                lblInfo.Location = p;
            else
            {
                lblInfo.Location = plblInfo;
            }
        }
    }
}
