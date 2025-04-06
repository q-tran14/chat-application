using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class UtilitiesDatabase
    {
        private static UtilitiesDatabase _instance;
        private static readonly object _lock = new object();
        private SqlConnection conn;
        private UtilitiesDatabase()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn = new SqlConnection(connString);
                conn.Open(); //Kết nối database ngay khi app chạy
                Console.WriteLine("SQL Server connect success!");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        public static UtilitiesDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null) _instance = new UtilitiesDatabase();
                    }
                }
                return _instance;
            }
        }
        public bool IsConnect()
        {
            return conn.State == ConnectionState.Open;
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
        }
        // Dành cho SELECT query
        // string query = "SELECT * FROM Users WHERE Username = @username";
        // SqlParameter[] parameters = { new SqlParameter("@username", "admin") };
        // DataTable dt = Database.Instance.ExecuteQuery(query, parameters);
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }

            return dt;
        }

        // Dành cho INSERT / UPDATE / DELETE query
        // string query = "DELETE FROM Users WHERE Username = @username";
        // SqlParameter[] parameters = { new SqlParameter("@username", "testuser") };
        // int rowsAffected = Database.Instance.ExecuteNonQuery(query, parameters);
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    return command.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
