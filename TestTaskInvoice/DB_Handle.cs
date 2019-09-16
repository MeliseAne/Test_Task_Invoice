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
        private SqlConnection _connection { get; set; }

        /// <summary>
        /// Initialize SqlConnection from connection string.
        /// </summary>
        /// <param name="connectionString">Connection string.</param>
        internal DB_Handle(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connection string cant be null or whitespace.", nameof(connectionString));
            }
            _connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// This method return DataSet for DataGridView.
        /// </summary>
        /// <param name="query">SQL querry.</param>
        /// <returns></returns>
        internal DataSet Reader(string query)
        {
            var dataAdapter = new SqlDataAdapter(query, _connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }

        /// <summary>
        /// This method return invoice by ID.
        /// </summary>
        /// <param name="id">ID from invoices table.</param>
        /// <returns></returns>
        internal Invoice GetInvoice(int id)
        {
            Invoice invoice = new Invoice();
            using (SqlCommand command = new SqlCommand($"SELECT * FROM TestTaskInvoiceDB.dbo.Invoices WHERE Id = {id}", _connection))
            {
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        invoice.ID = id;
                        invoice.Date = reader["date"].ToString();
                        invoice.Client = reader["Client"].ToString();
                        invoice.Amount = Decimal.Parse(reader["Invoice_amount"].ToString());
                    }
                }
                _connection.Close();
            }
            return invoice;
        }

        /// <summary>
        /// This method update invoice in SQL DB.
        /// </summary>
        /// <param name="invoice"> Must countain initialized ID field.</param>
        /// <returns></returns>
        internal bool InvoiceUpdate(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException(nameof(invoice));
            }

            try
            {
                SqlCommand Cmd = new SqlCommand($"UPDATE Invoices SET " +
                    $"Client = '{invoice.Client}', " +
                    $"[Date] = FORMAT (getdate(), '{invoice.Date}'), " +
                    $"[Invoice_amount] = {(int)invoice.Amount} " +
                    $"WHERE id = {invoice.ID}", _connection);


                _connection.Open();
                int RowsAffected = Cmd.ExecuteNonQuery();
                _connection.Close();

                return RowsAffected == 1 ? true : false;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Method add new record to DB.
        /// </summary>
        /// <param name="invoice">Initialized invoice instance.</param>
        /// <returns></returns>
        internal void AddNewRecord(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException(nameof(invoice));
            }

            try
            {
                SqlCommand Cmd = new SqlCommand($"INSERT INTO Invoices (Client, [Date], Invoice_amount) VALUES " +
                    $"('{invoice.Client}', FORMAT (getdate(), '{invoice.Date}'), {invoice.Amount})", _connection);

                _connection.Open();
                int RowsAffected = Cmd.ExecuteNonQuery();
                _connection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Invoice removing from DB.
        /// </summary>
        /// <param name="id">ID from Invoice table.</param>
        internal void RemoveInvoice(int id)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand($"DELETE FROM TestTaskInvoiceDB.dbo.Invoices WHERE Id = {id}", _connection);

                _connection.Open();
                int RowsAffected = Cmd.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
