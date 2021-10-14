using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add this for MessageBox
using System.Windows.Forms;

//add data fuction classes
using System.Data;

using MySql.Data.MySqlClient;

namespace LoginRegisterWindows
{
    public class Config
    {
        string ConnectionString = ""; //save con string
        public MySqlConnection connection = null;
        public string server = "localhost"; //MySql Host
        public string user = "root"; //mySql user
        public string password = "root"; //Mysql password
        DataSet ds;
        DataTable dt;
        public string Table = "user_info"; //init db table
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempData;

        public Config()
        {

        }

        //function to connect database
        public void Connect(string databaseName)
        {
            try
            {
                ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + databaseName + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(ConnectionString);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //function to execute select statement
        public void ExecuteSql(string sqlCommand)
        {
            nowquiee(sqlCommand);
        }

        //create connection to Mysqlbefore execution
        public void nowquiee(string sqlCommand)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sqlCommand, cs);
                myc.ExecuteNonQuery();
                cs.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //function to execute delete, insert and update
        public void Execute(string sqlCommand)
        {
            RecordSource = sqlCommand;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                //===============if sql contain select======================
                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                //da2.Fill(tempds);
                //==========================================================
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //function to bring selected result based on column name and row index
        public string Results(int row, string columnName)
        {
            try
            {
                return dt.Rows[row][columnName].ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        //execute select statement
        public void ExecuteSelect(string sqlCommend)
        {
            RecordSource = sqlCommend;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempData = new DataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //count number of row after select
        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
