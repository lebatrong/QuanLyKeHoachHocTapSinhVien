using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAn_Win
{
    public partial class frmDoHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmDoHoa()
        {
            InitializeComponent();
            LoadMonTienQuyet("15004116");
            LoadMonNhapLieu();

           
        }

        private void LoadMonTienQuyet(string id)
        {
            Models.DataProvider.Instance.open();

            string query = "select Diem.MaMon,TenMon from MonHoc,Diem where Diem.MaMon=MonHoc.MaMon and MSSV='" + id + "'";

            DataTable data = new DataTable();

            data = Models.DataProvider.Instance.FillDataTable(query, data);

            foreach( DataRow row in data.Rows)
            {
                cbbMonTienQuyet.Properties.Items.Add(row[1]);
            }
            cbbMonTienQuyet.SelectedIndex = 0;
        }

        private void LoadMonNhapLieu()
        {
            Models.DataProvider.Instance.open();

            string query = "select MaMon,TenMon from MonHoc";

            DataTable data = new DataTable();

            data = Models.DataProvider.Instance.FillDataTable(query, data);

            foreach (DataRow row in data.Rows)
            {
                lsbMonNhapLieu.Items.Add(row[1]);
            }
        }

        //vẽ đường thẳng
        private void Draw_Line(Graphics g, int x1, int y1, int x2, int y2)
        {
            Point[] p = new Point[2];
            p[0] = new Point(x1, y1);
            p[1] = new Point(x2, y2);
            Pen pen = new Pen(Brushes.Black, 3);
            pen.EndCap = LineCap.ArrowAnchor;
            g.DrawLines(pen, p);
            pen.Dispose();
        }
        
        private List<string> truocsau(string id)
        {
            List<string> mamon= new List<string>();

            string query = "select Diem.MaMon from MonHoc,Diem where Diem.MaMon=MonHoc.MaMon and MSSV='" + id + "'";

            DataTable tb = new DataTable();

            tb=Models.DataProvider.Instance.FillDataTable(query, tb);

            foreach (DataRow row in tb.Rows)
            {
                mamon.Add(row[0].ToString());
            }

            return mamon;
        }

        private void Draw_Regtanle(Graphics g, Pen p, int x, int y,  int width,int height, string str)
        {
            g.DrawRectangle(p, x, y, width, height);
            SolidBrush sb = new SolidBrush(Color.Red);
            Font font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
            g.DrawString(str,font,sb,x,3+(height/2));
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            Graphics g = pnlMain.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Black);
            g.Clear(Color.White);


            //Khoảng cách giữa 2 môn
            int x = 50;
            int y = 0;

            //Môn tiên quyết
            Draw_Regtanle(g, p, 10, 10, 120, 40, cbbMonTienQuyet.Text);


            //Môn tiếp theo
            Draw_Regtanle(g, p, 10+130+x, 10+y, 120, 40, lsbMonNhapLieu.Text);

            //Đường nối
            Draw_Line(g, 130, 35,140+x,35);
            
        }
    }
}