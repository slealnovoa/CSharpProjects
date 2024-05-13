using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
    public partial class NotificationForm : Form
    {
        private List<ISubscriber> subscribers;
        public NotificationForm(List<ISubscriber> subscribers)
        {
            InitializeComponent();
            this.subscribers = subscribers;
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            string message = messageTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message to send.");
                return;
            }

            List<string> emails = new List<string>();
            List<string> mobileNumbers = new List<string>();

            foreach (ISubscriber subscriber in subscribers)
            {
                if (subscriber is SendViaEmail)
                {
                    emails.Add(((SendViaEmail)subscriber).Email);
                }

                if (subscriber is SendViaMobile)
                {
                    mobileNumbers.Add(((SendViaMobile)subscriber).MobileNumber);
                }
            }

            if (emails.Count == 0 && mobileNumbers.Count == 0)
            {
                MessageBox.Show("There are no subscribers to send the notification to.");
                return;
            }

            string recipients = "";

            if (emails.Count > 0)
            {
                recipients += "Emails: " + string.Join(", ", emails) + "\n";
            }

            if (mobileNumbers.Count > 0)
            {
                recipients += "Mobile Numbers: " + string.Join(", ", mobileNumbers) + "\n";
            }

            DialogResult result = MessageBox.Show($"Confirm sending the following notification to the subscribers:\n\n{message}\n\nRecipients:\n{recipients}", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (ISubscriber subscriber in subscribers)
                {
                    subscriber.ReceiveNotification(message);
                }

                MessageBox.Show("Notification sent successfully.");
                Close();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
