using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskInvoice.Dialogs
{
    public partial class EditInvoiceDialog : Form
    {
        internal Invoice Invoice { get; set; }

        internal EditInvoiceDialog(Invoice invoice)
        {
            InitializeComponent();
            AmountTB.Text = invoice.Amount.ToString();
            ClientTB.Text = invoice.Client;
            DatePicker.Value = DateTime.Parse(invoice.Date);
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            Invoice = new Invoice(DatePicker.Value, ClientTB.Text, Convert.ToDecimal(AmountTB.Text));
        }
    }
}
