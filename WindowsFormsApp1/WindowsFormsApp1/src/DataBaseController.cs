using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DataBaseController
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
                MessageBox.Show(err.Message);
                return null;
            }
        }

        public bool Perform(string query)
        {
            try
            {
                SqlConnection connection = Connect();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Добавлено");
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
        
        public bool Perform(string query, DataSet data)
        {
            try
            {
                SqlConnection connection = Connect();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(data);
                connection.Close();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
    }
}
