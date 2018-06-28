using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using MySql.Data;
using MySql.Data.MySqlClient;

//160202103 Tarık BİR
//150202040 Yasin Emir KUTLU

namespace VehicleDatabase
{
    static class Program
    {
        private static MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;user=root;database=vehicle;port=3306;password=;charset=utf8");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VehicleDatabase.MainPage());
        }

        internal static bool sendSingleQuery(string query)
        {
            mySqlConnection.Open();
            //Console.WriteLine("SQL: MySQL connection opened.");
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            Console.WriteLine("SQL: Executing MySQL query: \"" + query + "\"");
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                mySqlConnection.Close();
                //Console.WriteLine("SQL: MySQL connection terminated.");
            }
            return true;
        }

        internal static void fillFromDB(ComboBox cb, string listname, string columnName)
        {
            mySqlConnection.Open();
            //Console.WriteLine("SQL: MySQL connection opened.");
            string query = "SELECT " + columnName + " from " + listname;
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            Console.WriteLine("SQL: Executing MySQL query: \"" + query + "\"");
            try
            {
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string obj = rdr.GetString(0);
                        cb.Items.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            mySqlConnection.Close();
            //Console.WriteLine("SQL: MySQL connection terminated.");
        }

        internal static void fillFromDB(ListBox lb, string listname, string columnName)
        {
            mySqlConnection.Open();
            //Console.WriteLine("SQL: MySQL connection opened.");
            string query = "SELECT " + columnName + " from " + listname;
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            Console.WriteLine("SQL: Executing MySQL query: \"" + query + "\"");
            try
            {
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string obj = rdr.GetString(0);
                        lb.Items.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            mySqlConnection.Close();
            //Console.WriteLine("SQL: MySQL connection terminated.");
        }

        internal static void fillDataGrid(DataGridView db, string sql)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, mySqlConnection);
                mySqlConnection.Open();
                //Console.WriteLine("SQL: MySQL connection opened.");
                Console.WriteLine("SQL: Executing MySQL query: \"" + sql + "\"");
                dataAdapter.Fill(dataSet, "mainTable");
                db.DataSource = dataSet;
                db.DataMember = "mainTable";
                db.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            mySqlConnection.Close();
            //Console.WriteLine("SQL: MySQL connection terminated.");
        }

        internal static string getSQLCell(string query)
        {
            mySqlConnection.Open();
            //Console.WriteLine("SQL: MySQL connection opened.");
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            Console.WriteLine("SQL: Executing MySQL query: \"" + query + "\"");
            string returnString = "";
            try
            {
                returnString = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            mySqlConnection.Close();
            //Console.WriteLine("SQL: MySQL connection terminated.");
            return returnString;
        }

        internal static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                    return true;
            }
            catch (SocketException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }
    }
}
