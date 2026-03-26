using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDADAL
{
    public class DataProvider
    {
        private static DataProvider instance;

        public string conStr =
            "Data Source=.;Initial Catalog=DB_QUANLYBIDA;Integrated Security=True;TrustServerCertificate=True;";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private DataProvider() { }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ', ',', '(', ')');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            string paraName = item.Trim().Replace(",", "").Replace(";", "");
                            if (i < parameter.Length)
                            {
                                cmd.Parameters.AddWithValue(paraName, parameter[i]);
                                i++;
                            }
                        }
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null && parameter.Length > 0)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }

            return data;
        }


        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object result = 0;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                result = cmd.ExecuteScalar();
                con.Close();
            }
            return result;
        }
    }
}