using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace Dormitory_Manager
{
    class DataProvider
    {
        public static SqlConnection Connect()
        {
            string PCName = Dns.GetHostName();
            string CTR = "Data Source="+PCName+ "\\Khang;Initial Catalog=QLPHONGTRO2310;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(CTR);
            con.InfoMessage += new SqlInfoMessageEventHandler(conn_InfoMessage);
            con.FireInfoMessageEventOnUserErrors = true;
            con.Open();
            return con;
        }

        public static bool ExecuteNonQuery(string CTR)
        {
            SqlCommand cmd = new SqlCommand(CTR, Connect());
            int icmd = cmd.ExecuteNonQuery();
            Connect().Close();
            if (icmd > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            try
            {
                
            }
            catch (Exception ex)
            {
       
                Connect().Close();
                return false;
            }
        }



        public static object _SQL_ExecuteScalar(string CTR)
        {
            
             
            try
            {
                SqlCommand cmd = new SqlCommand(CTR, Connect());
                object icmd = cmd.ExecuteScalar();
                Connect().Close();
                return icmd;
            }
            catch (Exception ex)
            {

                Connect().Close();
                return 0;
            }
        }

        public static DataTable ExecuteQuery(string CTR)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(CTR, Connect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                Connect().Close();
                return dt;
            }
            catch (Exception ex)
            {
   
                return null;
            }
        }

        public static string ExecuteScalar(string CTR)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(CTR, Connect());
                string kq = cmd.ExecuteScalar().ToString();
                Connect().Close();
                return kq;
            }
            catch (Exception ex)
            {
                Connect().Close();
                return null;
            }
        }

        static void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show("Lỗi:" +
            e.Errors[0].Class.ToString() + ":" + e.Message);
        }
    }
}
