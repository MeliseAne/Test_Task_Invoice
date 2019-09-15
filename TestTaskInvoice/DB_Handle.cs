using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TestTaskInvoice
{
    internal class DB_Handle
    {
        SqlConnection connection { get; set; }

        //private string connectionString { get; set; }

        public DB_Handle(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connection string cant be null or whitespace.", nameof(connectionString));
            }

            this.connection = new SqlConnection(connectionString);
        }

        public DataSet Reader(string query)
        {
            var dataAdapter = new SqlDataAdapter(query, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }

        public bool AddNewRecord(/*Invoice invoice*/)
        {
            //if (invoice == null)
            //{
            //    throw new ArgumentNullException(nameof(invoice));
            //}

            try
            {
                SqlCommand Cmd = new SqlCommand($"INSERT INTO Invoices (Client, [Date], Amount) VALUES " +
                    $"('111', '11.09.2019', 100)", connection);

                connection.Open();
                int RowsAffected = Cmd.ExecuteNonQuery();
                connection.Close();

                return RowsAffected == 1 ? true : false;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //internal DataSet SearchByFIO(string fio)
        //{

        //}
    }
}
