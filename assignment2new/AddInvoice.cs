using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2new
{
    public partial class AddInvoice : UserControl
    {
        public Invoice InvoiceManager { get; set; }

        public AddInvoice()
        {
            InitializeComponent();
            customerTypeCombobox.SelectedItem = "Household customer";
            string currentMonth = DateTime.Now.Month.ToString();
            currentMonthCombobox.SelectedItem = currentMonth;
            numberOfPeopleInput.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string messages = "";
            bool isValid = true;
            if (lastMonthNumberInput.Text == "")
            {
                isValid = false;
                messages += "Pls enter last month number!\n";
            }

            if (thisMonthNumberInput.Text == "")
            {
                isValid = false;
                messages += "Pls enter this month number!\n";
            }

            if (customerCodeInput.Text == "")
            {
                isValid = false;
                messages += "Pls enter customer code!\n";
            }

            if (customerNameInput.Text == "")
            {
                isValid = false;
                messages += "Pls enter customer name!\n";
            }

            if (!lastMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "PLs enter valid last month number!\n";
            }
            if (!thisMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "PLs enter valid this month number!\n";
            }
            if (!numberOfPeopleInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "PLs enter valid number of people input!\n";
            }
            if (isValid == false)
            {
                MessageBox.Show(messages);
                return;
            }


            string customerCode = customerCodeInput.Text;
            string customerName = customerNameInput.Text;
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            int numberOfPeople = Convert.ToInt32(numberOfPeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(lastMonthNumberInput.Text);
            int thisMonthNumber = Convert.ToInt32(thisMonthNumberInput.Text);
            int currentMonth = Convert.ToInt32(currentMonthCombobox.SelectedItem);

            int consumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double envFee = 0;


            if (lastMonthNumber < 0)
            {
                MessageBox.Show("Pls enter valid last month number");
                return;
            }

            if (thisMonthNumber < lastMonthNumber)
            {
                MessageBox.Show("Your value water is invalid.");
                return;
            }
            if (thisMonthNumber == lastMonthNumber)
            {
                MessageBox.Show("Customer don't use water.");
                return;
            }

            if (customerType == "Household customer")
            {
                if (numberOfPeople <= 0)
                {
                    MessageBox.Show("Pls enter valid number of People");
                    return;
                }
                decimal consumptionPerPeople = consumption / numberOfPeople;
                if (consumptionPerPeople < 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                else if (consumption < 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                else if (consumption <= 30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                else
                {
                    price = 15929;
                    envFee = 1592.9;
                }
            }
            else if (customerType == "Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;
            }
            else if (customerType == "Production units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            else
            {
                price = 22068;
                envFee = 2206.8;
            }
            double subTotal = price * consumption;
            double VATFee = (subTotal + envFee) * 0.1;
            double total = subTotal + envFee + VATFee;

            consumptionLabel.Text = consumption.ToString();
            priceLabel.Text = price.ToString();
            subtotalLabel.Text = Math.Round(subTotal, 2).ToString();
            envFeeLabel.Text = envFee.ToString();
            VATLabel.Text = Math.Round(VATFee).ToString();
            totalLabel.Text = Math.Round(total, 2).ToString();

            InvoiceManager.AddInvoice(customerCode, customerName, customerType, numberOfPeople, lastMonthNumber, thisMonthNumber, consumption, currentMonth,
                subTotal, envFee, VATFee, total);

        }

        private void customerTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            if (customerType == "Household customer")
                numberOfPeopleInput.Enabled = true;
            else
                numberOfPeopleInput.Enabled = false;
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
