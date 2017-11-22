using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Text.RegularExpressions;

namespace DoAn_Win.Models
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        

        public string sqlcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=SoftQuanLySV;Integrated Security=True";

        public string sqlconMaster = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";


        public SqlConnection GetConnec()
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            return conn;
        }
        public void open()
        {
            try
            {
                if (GetConnec().State == ConnectionState.Closed)
                    GetConnec().Open();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Mã lỗi 103.2", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void close()
        {
            try
            {
                if (GetConnec().State == ConnectionState.Open)
                    GetConnec().Close();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Mã lỗi 103.1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable FillDataTable(string sql, DataTable tb)
        {
            DataTable table = new DataTable();
            if (GetConnec().State == ConnectionState.Closed)
                GetConnec().Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, GetConnec());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                adapter.Dispose();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Mã lỗi 102","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            GetConnec().Close();
            return table;
        }


        public int Exec_Tsql(string sql)
        {
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn = GetConnec();
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Mã lỗi 101  ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return count;

        }

        public void ReadDatabase()
        {
            try
            {
                #region    Đọc file text
                    string url = Application.StartupPath + "\\database.txt"; 
                    File.SetAttributes(url, FileAttributes.Hidden);
                    FileStream fs = new FileStream(url, FileMode.Open);

                    string sqlDatabase;

                    string[] query;

                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {

                        sqlDatabase = sr.ReadToEnd();

                        query = Regex.Split(sqlDatabase, "GO");
                    }
                #endregion
                    
                #region Tạo database
                
                using (SqlConnection cdb = new SqlConnection(sqlconMaster))
                {

                    cdb.Open();

                    SqlCommand cmd = new SqlCommand(query[0], cdb);

                    cmd.ExecuteNonQuery();
                }
                #endregion

                #region Thêm data
               
                using (SqlConnection cdb = new SqlConnection(sqlcon))
                {
                    cdb.Open();
                    SqlCommand cmd;
                    for (int i = 1; i < query.Length; i++)
                    {
                        cmd= new SqlCommand(query[i], cdb);

                        cmd.ExecuteNonQuery();
                    }

                }
                #endregion
                MessageBox.Show("Tạo dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Mã lỗi 100: Tạo database không thành công\nVui lòng khởi động lại phần mềm bằng quyền Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
        


       
        public bool CheckDatabase()
        {
            try
            {
               
                DataTable table;

                using (SqlConnection c = new SqlConnection(sqlconMaster))
                {

                    c.Open();

                    string sql = "SELECT name FROM sys.databases WHERE name='SoftQuanLySV'";

                    table = new DataTable();

                    SqlCommand cmd = new SqlCommand(sql, c);

                    SqlDataAdapter adapte = new SqlDataAdapter(cmd);

                    adapte.Fill(table);

                }
                
                if (table.Rows.Count==1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối vui lòng kiểm tra lại!");
                return true;
            }
            

        }
        //public void DropDatabase()
        //{
        //    try
        //    {
        //        using (SqlConnection c = new SqlConnection(sqlconMaster))
        //        {
        //            c.Open();

        //            string sql = "DROP DATABASE SoftQuanLySV";

        //            SqlCommand cmd = new SqlCommand(sql, c);

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.ToString());
        //    }
        //}
        //public bool CheckTableInDatabase()
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(sqlcon);
        //        string Check = "SELECT MSSV FROM dbo.SinhVien";
        //        SqlCommand cmd = new SqlCommand(Check, conn);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

      

    }
}
