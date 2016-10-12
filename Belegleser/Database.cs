using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Belegleser
{
    public enum DBType { MySQL, MsSQL }

    class Database
    {
        public static string ExecuteQuery(string sql, Dictionary<string, string> parameter, DBType dbType)
        {
            string ret = "";
            try
            {
                if(dbType == DBType.MySQL)
                {
                    string myConnectionString = "SERVER=" + Config.getInstance().MySQLHost + ";" +
                                           "DATABASE=" + Config.getInstance().MySQLDatabase + ";" +
                                           "UID=" + Config.getInstance().MySQLUser + ";" +
                                           "PASSWORD=" + Config.getInstance().MySQLPassword + ";";
                    MySqlConnection con = new MySqlConnection(myConnectionString);
                    con.Open();
                    MySqlCommand com = new MySqlCommand(sql, con);
                    foreach (KeyValuePair<string, string> param in parameter)
                    {
                        com.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    ret = Convert.ToString(com.ExecuteScalar());
                    if (ret == "")
                    {
                        ret = "leer";
                    }
                    con.Close();
                }
                else
                {
                    string myConnectionString = "SERVER=" + Config.getInstance().SQLHost + ";" +
                                           "DATABASE=" + Config.getInstance().SQLInstance + ";" +
                                           "UID=" + Config.getInstance().SQLUser + ";" +
                                           "PASSWORD=" + Config.getInstance().SQLPassword + ";";
                    SqlConnection con = new SqlConnection(myConnectionString);
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    foreach (KeyValuePair<string, string> param in parameter)
                    {
                        com.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    ret = Convert.ToString(com.ExecuteScalar());
                    if (ret == "")
                    {
                        ret = "leer";
                    }
                    con.Close();
                }
            }
            catch(Exception e)
            {
                throw new InvalidOperationException("Error while gethetring data");
            }

            return ret;
        }
    }
}
