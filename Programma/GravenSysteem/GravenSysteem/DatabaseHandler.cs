using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DatabaseHandler()
        {
            ConnectionString = DefaultConnectionString;
            Connection = DefaultConnection;
        }

        public DatabaseHandler(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            this.Connection = new SqlConnection(ConnectionString);
        }

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
                DialogResult dialogResult = MessageBox.Show(e.Message, "Error", MessageBoxButtons.AbortRetryIgnore);
                switch (dialogResult)
                {
                    case DialogResult.Abort:
                        result = false;
                        break;
                    case DialogResult.Retry:
                        result = OpenConnection();
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
}
