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
    public partial class Form1 : Form
    {
        private DB_Handle DB_Handle { get; set; }
        public Form1()
        {
            InitializeComponent();
            MainDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ALLBT_Click(object sender, EventArgs e)
        {
            MainDGV.DataSource = DB_Handle.Reader("SELECT * FROM Invoices").Tables[0];
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            MainDGV.DataSource = DB_Handle.Reader(
               $"SELECT * FROM Invoices WHERE Client LIKE '%{Interaction.InputBox("Please input FIO or part of FIO.", "Search by FIO")}%'").Tables[0];
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            Dialogs.InvoiceCreateDialog invoiceCreateDialog = new Dialogs.InvoiceCreateDialog();
            invoiceCreateDialog.ShowInputDialog(ref invoice);
            //DB_Handle.AddNewRecord();
            //AllBT_Click(null, null);
        }

        private void ConnBT_Click(object sender, EventArgs e)
        {
            DB_Handle = new DB_Handle(ConnTB.Text);
            //TODO: Check connection to DB
            ALLBT_Click(null, null);
            ConnTB.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
