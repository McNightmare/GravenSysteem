using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GravenSysteem
{
    class DatabaseHandler
    {
        public string DefaultConnectionString { get { return "Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True"; } }
        public string ConnectionString { get; private set; }
        public SqlConnection DefaultConnection { get { return new SqlConnection(DefaultConnectionString); } }
        public SqlConnection Connection { get; private set; }

        /// <summary> Default contructor. Uses the default ConnectionString and Connection. </summary>
        public DatabaseHandler()
        {
            ConnectionString = DefaultConnectionString;
            Connection = DefaultConnection;
        }

        /// <summary> Custom contructor. Uses the ConnectString to create a new connection. </summary>
        /// <param name="ConnectionString"> ConnectionString for creating a new Connection. </param>
        /// <example> DatabaseHandler("Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True"); </example>
        public DatabaseHandler(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        /// <summary> Opens Connection. </summary>
        /// <example> OpenConnection(); </example>
        private bool OpenConnection()
        {
            bool result = false;

            try
            {
                Connection.Open();
                result = true;
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = false;
                        break;
                    case DialogResult.Retry:
                        if (CloseConnection())
                            result = OpenConnection();
                        else
                            result = false;
                        break;
                    case DialogResult.Ignore:
                        result = false;
                        break;
                    default:
                        result = false;
                        break;
                }
            }

            return result;
        }

        /// <summary> Closes Connection. </summary>
        /// <example> CloseConnection(); </example>
        private bool CloseConnection()
        {
            bool result = false;

            try
            {
                Connection.Close();
                result = true;
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = false;
                        break;
                    case DialogResult.Retry:
                        result = CloseConnection();
                        break;
                    case DialogResult.Ignore:
                        result = false;
                        break;
                    default:
                        result = false;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns a string or null on error. </summary>
        /// <param name="query"> Custom query. This must return a value. </param>
        /// <example> GetString("SELECT Username FROM tbl_Users WHERE ID = '1';"); </example>
        public string GetString(string query)
        {
            string result = null;

            try
            {
                if (OpenConnection())
                {
                    SqlDataReader rdr = new SqlCommand(query).ExecuteReader();

                    while (rdr.Read())
                    {
                        result = rdr.GetString(0);
                    }
                }
                else
                    throw new Exception("De database of connectie die u probeert te openen kan niet worden geopent.");
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetString(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a string or empty string on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> GetString("tbl_Users", "Username", "ID", "1"); </example>
        public string GetString(string table, string column, ArgumentType argType)
        {
            string result = null;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType.Column + " = '" + argType.Value + "';";

            try
            {
                result = GetString(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetString(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            return result;
        }
        
        /// <summary> Preforms a query and returns a string array or null on error. </summary>
        /// <param name="query"> Custom query. </param>
        /// <example> GetStringArray("SELECT Username FROM tbl_Users WHERE Rights = '1';"); </example>
        public string[] GetStringArray(string query)
        {
            string[] result = null;

            try
            {
                SqlDataReader rdr = new SqlCommand(query, Connection).ExecuteReader();
                result = new string[rdr.FieldCount];

                int i = 0;
                while (rdr.Read())
                {
                    result[i] = rdr.GetString(0);
                    i++;
                }
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetStringArray(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns a string array or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> GetStringArray("tbl_Users", "Username", "Rights", "1"); </example>
        public string[] GetStringArray(string table, string column, ArgumentType argType)
        {
            string[] result;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType.Column + " = '" + argType.Value + "';";

            try
            {
                result = GetStringArray(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetStringArray(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int or '-1' on error. </summary>
        /// <param name="query"> Custom query. This must return an int. </param>
        /// <example> GetInt("SELECT ID FROM tbl_Users WHERE Username = 'admin';"); </example>
        public int GetInt(string query)
        {
            int result = -1;
            
            try
            {
                if (!int.TryParse(GetString(query), out result))
                    throw new Exception("Er is een fout opgetreden. Neem contact op met de systeembeheerder.");
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = -1;
                        break;
                    case DialogResult.Retry:
                        result = GetInt(query);
                        break;
                    case DialogResult.Ignore:
                        result = -1;
                        break;
                    default:
                        result = -1;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int or '-1' on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> GetInt("tbl_Users", "Username", "ID", "1"); </example>
        public int GetInt(string table, string column, ArgumentType argType)
        {
            int result = -1;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType.Column + " = '" + argType.Value + "';";

            try
            {
                result = GetInt(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = -1;
                        break;
                    case DialogResult.Retry:
                        result = GetInt(query);
                        break;
                    case DialogResult.Ignore:
                        result = -1;
                        break;
                    default:
                        result = -1;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int array or null on error. </summary>
        /// <param name="query"> Custom query. </param>
        /// <example> GetIntArray("SELECT ID FROM tbl_Users;"); </example>
        public int[] GetIntArray(string query)
        {
            int[] result = null;

            try
            {
                SqlDataReader rdr = new SqlCommand(query, Connection).ExecuteReader();
                result = new int[rdr.FieldCount];

                int i = 0;
                while (rdr.Read())
                {
                    result[i] = rdr.GetInt32(0);
                    i++;
                }
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetIntArray(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int array or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> GetIntArray("tbl_Users", "ID", "Rights", "1"); </example>
        public int[] GetIntArray(string table, string column, ArgumentType argType)
        {
            int[] result;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType.Column + " = '" + argType.Value + "';";

            try
            {
                result = GetIntArray(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetIntArray(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int or '-1' on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. </param>
        /// <example> GetLastInt("tbl_Users", "ID"); </example>
        public int GetLastInt(string table, string column)
        {
            int result = -1;
            string query = "SELECT Last(" + column + ") FROM " + table + ";";

            try
            {
                result = GetInt(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = -1;
                        break;
                    case DialogResult.Retry:
                        result = GetInt(query);
                        break;
                    case DialogResult.Ignore:
                        result = -1;
                        break;
                    default:
                        result = -1;
                        break;
                }
            }

            return result;
        }

        /// <summary> Preforms a query and returns a DataSet or null on error. </summary>
        /// <param name="query"> Custom query. </param>
        /// <example> GetDataSet("SELECT * FROM tbl_Users WHERE Username = 'admin';"); </example>
        public DataSet GetDataSet(string query)
        {
            DataSet result = new DataSet();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
                OpenConnection();
                sda.Fill(result);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetDataSet(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a DataSet or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> GetDataSet("tbl_Users", "Rights", "1"); </example>
        public DataSet GetDataSet(string table, ArgumentType argType)
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM " + table + " WHERE " + argType.Column + " = '" + argType.Value + "';";

            try
            {
                result = GetDataSet(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetDataSet(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns an entire table as DataSet or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <example> GetTable("tbl_Users"); </example>
        public DataSet GetTable(string table)
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM " + table + ";";

            try
            {
                result = GetDataSet(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = null;
                        break;
                    case DialogResult.Retry:
                        result = GetDataSet(query);
                        break;
                    case DialogResult.Ignore:
                        result = null;
                        break;
                    default:
                        result = null;
                        break;
                }
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a true or false. </summary>
        /// <param name="query"> Custom query. </param>
        /// <example> SetValue("UPDATE tbl_Users SET Username = 'ziggo', Password = 'draadloos' WHERE Username = 'admin';"); </example>
        public bool SetValue(string query)
        {
            bool result = false;

            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, Connection);
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = false;
                        break;
                    case DialogResult.Retry:
                        result = SetValue(query);
                        break;
                    case DialogResult.Ignore:
                        result = false;
                        break;
                    default:
                        result = false;
                        break;
                }
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a true or false. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> SetValue("tbl_Users", "Username", "Username", "admin"); </example>
        public bool SetValue(string table, string column, ArgumentType argType)
        {
            bool result = false;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType.Column + " = '" + argType.Value + "';";

            try
            {
                result = SetValue(query);
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message + "\nSource: " + e.Source, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = false;
                        break;
                    case DialogResult.Retry:
                        result = SetValue(query);
                        break;
                    case DialogResult.Ignore:
                        result = false;
                        break;
                    default:
                        result = false;
                        break;
                }
            }
            
            return result;
        }
    }

    public struct ArgumentType
    {
        private string DefaultColumn { get { return ""; } }
        private string DefaultValue { get { return ""; } }
        private Type DefaultType { get { return typeof(string); } }

        public string Column { get; set; }
        public string Value { get; set; }
        public Type Type { get; set; }

        public ArgumentType()
        {
            Column = DefaultColumn;
            Value = DefaultValue;
            Type = DefaultType;
        }

        public ArgumentType(string Column, string Value)
        {
            this.Column = Column;
            this.Value = Value;
            this.Type = DefaultType;
        }

        public ArgumentType(string Column, string Value, Type Type)
        {
            this.Column = Column;
            this.Value = Value;
            this.Type = Type;
        }
    }
}
