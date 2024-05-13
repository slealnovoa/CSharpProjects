using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarNotificationSystem
{
    public partial class Form1 : Form
    {
        delegate void NotifyCustomerDelegate(string message);

        List<string> registeredCustomers = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSendNotification.Enabled = registeredCustomers.Count > 0;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (registeredCustomers.Contains(txtEmail.Text))
            {
                MessageBox.Show("This email address is already registered.");
                return;
            }

            registeredCustomers.Add(txtEmail.Text);

            txtEmail.Text = "";

            MessageBox.Show("Customer Email registered successfully!");

            btnSendNotification.Enabled = true;
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail2.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            if (!registeredCustomers.Contains(txtEmail2.Text))
            {
                MessageBox.Show("This email address is not registered.");
                return;
            }


            registeredCustomers.Remove(txtEmail2.Text);


            txtEmail2.Text = "";


            MessageBox.Show("Customer Email unsubscribed successfully!");


            btnSendNotification.Enabled = registeredCustomers.Count > 0;
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            // Check if all car information is entered
            if (string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtMileage.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please enter all car information.");
                return;
            }

            // Validate car year format
            int carYear;
            if (!int.TryParse(txtYear.Text, out carYear))
            {
                MessageBox.Show("Please enter a valid car year.");
                return;
            }

            // Validate car mileage format
            int carMileage;
            if (!int.TryParse(txtMileage.Text, out carMileage))
            {
                MessageBox.Show("Please enter a valid car mileage.");
                return;
            }

            // Validate car price format
            decimal carPrice;
            if (!decimal.TryParse(txtPrice.Text, out carPrice))
            {
                MessageBox.Show("Please enter a valid car price.");
                return;
            }

            string carModel = txtModel.Text;

            string message = $"New car in stock:\n Model: {carModel}\n Year: {carYear}\n Mileage: {carMileage:N0} km\n Price: ${carPrice:N0}";

            txtModel.Text = "";

            txtPrice.Text = "";

            txtYear.Text = "";

            txtMileage.Text = "";

            NotifyCustomerDelegate notifyDelegate = NotifyCustomer;

            foreach (string customerEmail in registeredCustomers)
            {
                notifyDelegate.BeginInvoke(message, null, null);
            }
            string emails = string.Join(", ", registeredCustomers.ToArray());

            MessageBox.Show($"Sent notification to {emails} with the following information:\n\n{message}");
        }

        private void NotifyCustomer(string message)
        {
            // Send notification to the customer via email (not implemented in this code example)
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
