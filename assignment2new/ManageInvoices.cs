using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2new
{
    public partial class ManageInvoices : UserControl
    {
        public Invoice InvoiceManager { get; set; }
        public ManageInvoices()
        {
            InitializeComponent();
        }

        public void RefreshInvoiceList()
        {
            if (InvoiceManager != null)
            {
                List<Invoice> invoices = InvoiceManager.GetListInvoices();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("No");
                dataTable.Columns.Add("Customer Code");
                dataTable.Columns.Add("Customer Name");
                dataTable.Columns.Add("Customer Type");
                dataTable.Columns.Add("Month");
                dataTable.Columns.Add("last Month");
                dataTable.Columns.Add("this Month");
                dataTable.Columns.Add("consumption");
                dataTable.Columns.Add("Total");
                int i = 1;
                foreach (Invoice invoice in invoices)
                {
                    dataTable.Rows.Add(
                        i++,
                        invoice.customerCode,
                        invoice.customerName,
                        invoice.customerType,
                        invoice.month,
                        invoice.lastMonthNumber,
                        invoice.thisMonthNumber,
                        invoice.consumption,
                        invoice.total
                    );
                }

                invoicesDataGridView.DataSource = dataTable;
            }
        }

    }
}
