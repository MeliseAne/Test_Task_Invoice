using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskInvoice
{
    public partial class MainForm : Form
    {
        private DB_Handle DB_Handle { get; set; }
        private bool ConnStatus { get; set; } = false;
        internal MainForm()
        {
            InitializeComponent();
            
        }

        private void ChangeBT_click(object sender, EventArgs e)
        {
            if (ConnStatus == true)
            {
                int selectedId = Convert.ToInt16(MainDGV.Rows[MainDGV.CurrentCell.RowIndex].
                                                                  Cells[0].Value);
                Invoice invoiceToChage = DB_Handle.GetInvoice(selectedId);
                using (Dialogs.EditInvoiceDialog dialog = new Dialogs.EditInvoiceDialog(invoiceToChage))
                {
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        invoiceToChage = dialog.Invoice;
                        invoiceToChage.ID = selectedId;
                        DB_Handle.InvoiceUpdate(invoiceToChage);
                        ALLBT_Click(null, null);
                    }
                }
            }
            else
                MessageBox.Show("DB connection not establised.");
        }

        private void ALLBT_Click(object sender, EventArgs e)
        {
            if (ConnStatus == true)
                MainDGV.DataSource = DB_Handle.Reader("SELECT * FROM Invoices").Tables[0];
            else
                MessageBox.Show("DB connection not establised.");
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            if (ConnStatus == true)
            {
                MainDGV.DataSource = DB_Handle.Reader(
               $"SELECT * FROM Invoices WHERE Client LIKE " +
               $"'%{Interaction.InputBox("Please input FIO or part of FIO.", "Search by FIO")}%'").Tables[0];
            }
            else
                MessageBox.Show("DB connection not establised.");
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            if (ConnStatus == true)
            {
                Invoice invoice = new Invoice();

                using (Dialogs.CreatingInvoiceDialog dialog = new Dialogs.CreatingInvoiceDialog())
                {
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        invoice = dialog.Invoice;
                        DB_Handle.AddNewRecord(invoice);
                        ALLBT_Click(null, null);
                    }
                }
            }
            else
                MessageBox.Show("DB connection not establised.");
        }

        private void ConnBT_Click(object sender, EventArgs e)
        {
            DB_Handle = new DB_Handle(ConnTB.Text);
            //TODO: Check connection to DB
            ConnStatus = true;
            ALLBT_Click(null, null);
            ConnTB.Enabled = false;

        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (ConnStatus == true)
            {
                //TODO: Check id existance
                int selectedId = Convert.ToInt16(MainDGV.Rows[MainDGV.CurrentCell.RowIndex].
                                                                  Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show($"Do you really want to delete record with ID = {selectedId}?", "Deleting invoice", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DB_Handle.RemoveInvoice(selectedId);
                    ALLBT_Click(null, null);
                }
            }
            else
                MessageBox.Show("DB connection not establised.");
        }

        private void TotAmoBT_Click(object sender, EventArgs e)
        {
            if (ConnStatus == true)
            {
                MainDGV.DataSource = DB_Handle.Reader(
                       "SELECT " +
                       "CONCAT((SELECT MIN(date) FROM TestTaskInvoiceDB.dbo.Invoices), ' - '," +
                       "(SELECT MAX(date) FROM TestTaskInvoiceDB.dbo.Invoices)) AS 'Period'," +
                       "SUM(Invoice_amount) AS 'Total Amount'" +
                       "FROM TestTaskInvoiceDB.dbo.Invoices"
                                                      ).Tables[0];
                MainDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else
                MessageBox.Show("DB connection not establised.");
        }
    }
}
