using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GravenAppServer
{
    class DatabaseHandler
    {
        public string DefaultConnectionString { get { return "Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True"; } }
        public string ConnectionString { get; private set; }
        public SqlConnection DefaultConnection { get { return new SqlConnection(DefaultConnectionString); } }
        public SqlConnection Connection { get; private set; }

        /// <summary> Default constructor. Uses the default ConnectionString and Connection. </summary>
        public DatabaseHandler()
        {
            ConnectionString = DefaultConnectionString;
            Connection = DefaultConnection;
        }

        /// <summary> Custom constructor. Uses the ConnectString to create a new connection. </summary>
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
                Console.WriteLine(e.Message);
                result = false;
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
                Console.WriteLine(e.Message);
                result = false;
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
                Console.WriteLine(e.Message);
                result = null;
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a string or empty string on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameters </param>
        /// <example> GetString("tbl_Users", "Username", new ArgumentType[] { new ArgumentType("Rights", "1") }); </example>
        public string GetString(string table, string column, ArgumentType[] argType)
        {
            string result = null;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType[0].Column + " = '" + argType[0].Value + "'";

            for (int i = 1; i < argType.Length; i++)
            {
                query += (argType[i].AndOr == AndOr.AND) ? " AND " : " OR ";
                query += "WHERE " + argType[i].Column;

                switch (argType[i].ArgsOp)
                {
                    case ArgumentOperator.EQUEL:
                        query += " = '";
                        break;
                    case ArgumentOperator.BIGGER:
                        query += " > '";
                        break;
                    case ArgumentOperator.SMALLER:
                        query += " < '";
                        break;
                    case ArgumentOperator.EQUELBIGGER:
                        query += " >= '";
                        break;
                    case ArgumentOperator.EQUELSMALLER:
                        query += " <= '";
                        break;
                    default:
                        query += " = '";
                        break;
                }

                query += argType[i].Value + "'";
            }

            query += ";";

            try
            {
                result = GetString(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = null;
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
                Console.WriteLine(e.Message);
                result = null;
            }

            return result;
        }

        /// <summary> Preforms a query and returns a string array or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameters </param>
        /// <example> GetStringArray("tbl_Users", "Username", new ArgumentType[] { new ArgumentType("Rights", "1") }); </example>
        public string[] GetStringArray(string table, string column, ArgumentType[] argType)
        {
            string[] result;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType[0].Column + " = '" + argType[0].Value + "'";

            for (int i = 1; i < argType.Length; i++)
            {
                query += (argType[i].AndOr == AndOr.AND) ? " AND " : " OR ";
                query += "WHERE " + argType[i].Column;

                switch (argType[i].ArgsOp)
                {
                    case ArgumentOperator.EQUEL:
                        query += " = '";
                        break;
                    case ArgumentOperator.BIGGER:
                        query += " > '";
                        break;
                    case ArgumentOperator.SMALLER:
                        query += " < '";
                        break;
                    case ArgumentOperator.EQUELBIGGER:
                        query += " >= '";
                        break;
                    case ArgumentOperator.EQUELSMALLER:
                        query += " <= '";
                        break;
                    default:
                        query += " = '";
                        break;
                }

                query += argType[i].Value + "'";
            }

            query += ";";

            try
            {
                result = GetStringArray(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = null;
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
                Console.WriteLine(e.Message);
                result = -1;
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int or '-1' on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameters </param>
        /// <example> GetInt("tbl_Users", "Username", new ArgumentType[] { new ArgumentType("Rights", "1") }); </example>
        public int GetInt(string table, string column, ArgumentType[] argType)
        {
            int result = -1;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType[0].Column + " = '" + argType[0].Value + "'";

            for (int i = 1; i < argType.Length; i++)
            {
                query += (argType[i].AndOr == AndOr.AND) ? " AND " : " OR ";
                query += "WHERE " + argType[i].Column;

                switch (argType[i].ArgsOp)
                {
                    case ArgumentOperator.EQUEL:
                        query += " = '";
                        break;
                    case ArgumentOperator.BIGGER:
                        query += " > '";
                        break;
                    case ArgumentOperator.SMALLER:
                        query += " < '";
                        break;
                    case ArgumentOperator.EQUELBIGGER:
                        query += " >= '";
                        break;
                    case ArgumentOperator.EQUELSMALLER:
                        query += " <= '";
                        break;
                    default:
                        query += " = '";
                        break;
                }

                query += argType[i].Value + "'";
            }

            query += ";";

            try
            {
                result = GetInt(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = -1;
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
                Console.WriteLine(e.Message);
                result = null;
            }

            return result;
        }

        /// <summary> Preforms a query and returns an int array or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. Initializes after 'SELECT' </param>
        /// <param name="argType"> Custom arguments parameters </param>
        /// <example> GetIntArray("tbl_Users", "ID", new ArgumentType[] { new ArgumentType("Rights", "1") }); </example>
        public int[] GetIntArray(string table, string column, ArgumentType[] argType)
        {
            int[] result;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType[0].Column + " = '" + argType[0].Value + "'";

            for (int i = 1; i < argType.Length; i++)
            {
                query += (argType[i].AndOr == AndOr.AND) ? " AND " : " OR ";
                query += "WHERE " + argType[i].Column;

                switch (argType[i].ArgsOp)
                {
                    case ArgumentOperator.EQUEL:
                        query += " = '";
                        break;
                    case ArgumentOperator.BIGGER:
                        query += " > '";
                        break;
                    case ArgumentOperator.SMALLER:
                        query += " < '";
                        break;
                    case ArgumentOperator.EQUELBIGGER:
                        query += " >= '";
                        break;
                    case ArgumentOperator.EQUELSMALLER:
                        query += " <= '";
                        break;
                    default:
                        query += " = '";
                        break;
                }

                query += argType[i].Value + "'";
            }

            query += ";";

            try
            {
                result = GetIntArray(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = null;
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
                Console.WriteLine(e.Message);
                result = -1;
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
                Console.WriteLine(e.Message);
                result = null;
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a DataSet or null on error. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="argType"> Custom arguments parameters </param>
        /// <example> GetDataSet("tbl_Users", new ArgumentType[] { new ArgumentType("Rights", "1") }); </example>
        public DataSet GetDataSet(string table, ArgumentType[] argType)
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM " + table + " WHERE " + argType[0].Column + " = '" + argType[0].Value + "'";

            for (int i = 1; i < argType.Length; i++)
            {
                query += (argType[i].AndOr == AndOr.AND) ? " AND " : " OR ";
                query += "WHERE " + argType[i].Column;

                switch (argType[i].ArgsOp)
                {
                    case ArgumentOperator.EQUEL:
                        query += " = '";
                        break;
                    case ArgumentOperator.BIGGER:
                        query += " > '";
                        break;
                    case ArgumentOperator.SMALLER:
                        query += " < '";
                        break;
                    case ArgumentOperator.EQUELBIGGER:
                        query += " >= '";
                        break;
                    case ArgumentOperator.EQUELSMALLER:
                        query += " <= '";
                        break;
                    default:
                        query += " = '";
                        break;
                }

                query += argType[i].Value + "'";
            }

            query += ";";

            try
            {
                result = GetDataSet(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = null;
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
                Console.WriteLine(e.Message);
                result = null;
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
                Console.WriteLine(e.Message);
                result = false;
            }

            CloseConnection();
            return result;
        }

        /// <summary> Preforms a query and returns a true or false. </summary>
        /// <param name="table"> Table name. </param>
        /// <param name="column"> Column name. </param>
        /// <param name="argType"> Custom arguments parameter </param>
        /// <example> SetValue("tbl_Users", "Username", new ArgumentType[] { new ArgumentType("Rights", "1") }); </example>
        public bool SetValue(string table, string column, ArgumentType[] argType)
        {
            bool result = false;
            string query = "SELECT " + column + " FROM " + table + " WHERE " + argType[0].Column + " = '" + argType[0].Value + "'";

            for (int i = 1; i < argType.Length; i++)
            {
                query += (argType[i].AndOr == AndOr.AND) ? " AND " : " OR ";
                query += "WHERE " + argType[i].Column;

                switch (argType[i].ArgsOp)
                {
                    case ArgumentOperator.EQUEL:
                        query += " = '";
                        break;
                    case ArgumentOperator.BIGGER:
                        query += " > '";
                        break;
                    case ArgumentOperator.SMALLER:
                        query += " < '";
                        break;
                    case ArgumentOperator.EQUELBIGGER:
                        query += " >= '";
                        break;
                    case ArgumentOperator.EQUELSMALLER:
                        query += " <= '";
                        break;
                    default:
                        query += " = '";
                        break;
                }

                query += argType[i].Value + "'";
            }

            query += ";";

            try
            {
                result = SetValue(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }

            return result;
        }
    }

    public enum AndOr { AND, OR }
    public enum ArgumentOperator { EQUEL, BIGGER, SMALLER, EQUELBIGGER, EQUELSMALLER }

    public struct ArgumentType
    {
        /// <summary> All values have a set default </summary>
        private string DefaultColumn { get { return ""; } }
        private string DefaultValue { get { return ""; } }
        private Type DefaultType { get { return typeof(string); } }

        public string Column { get { return Column; } set { Column = DefaultColumn; } }
        public string Value { get { return Value; } set { Value = DefaultValue; } }
        public Type Type { get { return Type; } set { Type = DefaultType; } }
        public AndOr AndOr { get { return AndOr; } set { AndOr = AndOr.OR; } }
        public ArgumentOperator ArgsOp { get { return ArgsOp; } set { ArgsOp = ArgumentOperator.EQUEL; } }

        /// <summary> Custom contructor. Uses the default Type, AndOr and ArgumentOperator. </summary>
        /// <param name="Column"> Parameter Column. </param>
        /// <param name="Value"> Parameter Value. </param>
        /// <example> ArgumentType("Username", "ziggo"); </example>
        public ArgumentType(string Column, string Value)
        {
            this.Column = Column;
            this.Value = Value;
            this.Type = DefaultType;
            AndOr = AndOr.OR;
            ArgsOp = ArgumentOperator.EQUEL;
        }

        /// <summary> Custom contructor. Uses the default AndOr and ArgumentOperator. </summary>
        /// <param name="Column"> Parameter Column. </param>
        /// <param name="Value"> Parameter Value. </param>
        /// <param name="Type"> Parameter Type. </param>
        /// <example> ArgumentType("Username", "ziggo", typeof(string)); </example>
        public ArgumentType(string Column, string Value, Type Type)
        {
            this.Column = Column;
            this.Value = Value;
            this.Type = Type;
            AndOr = AndOr.OR;
            ArgsOp = ArgumentOperator.EQUEL;
        }

        /// <summary> Custom contructor. Uses the default ArgumentOperator. </summary>
        /// <param name="Column"> Parameter Column. </param>
        /// <param name="Value"> Parameter Value. </param>
        /// <param name="Type"> Parameter Type. </param>
        /// <param name="AndOr"> Parameter AndOr. Chooses between AND or OR in your query. </param>
        /// <example> ArgumentType("Username", "ziggo", typeof(string), AndOr.OR); </example>
        public ArgumentType(string Column, string Value, Type Type, AndOr AndOr)
        {
            this.Column = Column;
            this.Value = Value;
            this.Type = Type;
            this.AndOr = AndOr;
            this.ArgsOp = ArgumentOperator.EQUEL;
        }

        /// <summary> Custom contructor. </summary>
        /// <param name="Column"> Parameter Column. </param>
        /// <param name="Value"> Parameter Value. </param>
        /// <param name="Type"> Parameter Type. </param>
        /// <param name="AndOr"> Parameter AndOr. Chooses between AND or OR in your query. </param>
        /// <param name="ArgsOp"> Parameter ArgumentOperator. Chooses different operators in your query. </param>
        /// <example> ArgumentType("Username", "ziggo", typeof(string), AndOr.OR, ArgumentOperator.EQUEL); </example>
        public ArgumentType(string Column, string Value, Type Type, AndOr AndOr, ArgumentOperator ArgsOp)
        {
            this.Column = Column;
            this.Value = Value;
            this.Type = Type;
            this.AndOr = AndOr;
            this.ArgsOp = ArgsOp;
        }
    }
}
