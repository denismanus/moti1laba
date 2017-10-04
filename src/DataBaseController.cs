using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class DatabaseController
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Database1.mdf") + "; Integrated Security=True";

        private SqlConnection Connect()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch(Exception err)
            {
                Trace.TraceError(err.Message);
                return null;
            }
        }

        public bool Perform(SqlCommand command)
        {
            try
            {
                SqlConnection connection = Connect();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception err)
            {
                Trace.TraceError(err.Message);
                return false;
            }
        }
        
        public bool Perform(SqlCommand query, DataSet data)
        {
            try
            {
                SqlConnection connection = Connect();
                query.Connection = connection;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
                dataAdapter.Fill(data);
                connection.Close();
                return true;
            }
            catch (Exception err)
            {
                Trace.TraceError(err.Message);
                return false;
            }
        }
    }
}
