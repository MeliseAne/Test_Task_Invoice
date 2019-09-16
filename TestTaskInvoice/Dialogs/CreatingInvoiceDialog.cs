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
    public partial class CreatingInvoiceDialog : Form
    {
        internal Invoice Invoice { get; set; }

        internal CreatingInvoiceDialog()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //TODO: Add type from TB check 
            Invoice = new Invoice(DatePicker.Value, CleintNameTB.Text, Convert.ToDecimal(AmountTB.Text));
        }
    }
}
