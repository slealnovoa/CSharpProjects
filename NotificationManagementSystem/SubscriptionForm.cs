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

namespace NotificationManagementSystem
{
    public partial class SubscriptionForm : Form
    {
        private List<ISubscriber> subscribers;
        private bool isEmailChecked;
        private bool isMobileChecked;

        public List<ISubscriber> Subscribers { get; internal set; }

        public SubscriptionForm(List<ISubscriber> subscribers)
        {
            InitializeComponent();
            this.subscribers = subscribers;
            isEmailChecked = false;
            isMobileChecked = false;
            emailTxtBox.Enabled = false;
            mobileTxtBox.Enabled = false;
            Subscribers = subscribers;
        }

        private void SubscriptionForm_Load(object sender, EventArgs e)
        {

        }

        private void emailCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            emailTxtBox.Enabled = emailCheckbox.Checked;
            isEmailChecked = emailCheckbox.Checked;
        }

        private void smsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            mobileTxtBox.Enabled = smsCheckbox.Checked;
            isMobileChecked = smsCheckbox.Checked;
        }

        private void subscribeBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text.Trim();
            string mobile = mobileTxtBox.Text.Trim();

            if (!isEmailChecked && !isMobileChecked)
            {
                MessageBox.Show("Please select at least one subscription method.");
            }
            else
            {
                if (isEmailChecked && !IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email address. Please enter a valid email.");
                    return;
                }

                if (isMobileChecked && !IsValidMobileNumber(mobile))
                {
                    MessageBox.Show("Invalid mobile number. Please enter a valid mobile number.");
                    return;
                }

                bool emailSubscribed = false;
                bool mobileSubscribed = false;
                foreach (ISubscriber subscriber in subscribers)
                {
                    if (subscriber is SendViaEmail && ((SendViaEmail)subscriber).Email == email)
                    {
                        emailSubscribed = true;
                    }

                    if (subscriber is SendViaMobile && ((SendViaMobile)subscriber).MobileNumber == mobile)
                    {
                        mobileSubscribed = true;
                    }
                }

                if (emailSubscribed && isEmailChecked)
                {
                    MessageBox.Show("This email is already subscribed.");
                    return;
                }

                if (mobileSubscribed && isMobileChecked)
                {
                    MessageBox.Show("This mobile number is already subscribed.");
                    return;
                }

                if (isEmailChecked)
                {
                    subscribers.Add(new SendViaEmail(email));
                }

                if (isMobileChecked)
                {
                    subscribers.Add(new SendViaMobile(mobile));
                }

                MessageBox.Show("Subscription successful.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void unsubscribeBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text.Trim();
            string mobile = mobileTxtBox.Text.Trim();

            if (!isEmailChecked && !isMobileChecked)
            {
                MessageBox.Show("Please select at least one subscription method.");
            }
            else
            {
                bool found = false;
                foreach (ISubscriber subscriber in subscribers)
                {
                    if (subscriber is SendViaEmail && ((SendViaEmail)subscriber).Email == email)
                    {
                        subscribers.Remove(subscriber);
                        found = true;
                        MessageBox.Show("Unsubscription successful.");
                        DialogResult = DialogResult.OK;
                        Close();
                        break;
                    }

                    if (subscriber is SendViaMobile && ((SendViaMobile)subscriber).MobileNumber == mobile)
                    {
                        subscribers.Remove(subscriber);
                        found = true;
                        MessageBox.Show("Unsubscription successful.");
                        DialogResult = DialogResult.OK;
                        Close();
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("The email or mobile number is not subscribed.");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidMobileNumber(string mobile)
        {
            return Regex.Match(mobile, @"^[0-9]{10}$").Success;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    public interface ISubscriber
    {
        void ReceiveNotification(string message);
    }

    public class SendViaEmail : ISubscriber
    {
        public string Email { get; set; }

        public SendViaEmail(string email)
        {
            Email = email;
        }

        public void ReceiveNotification(string message)
        {
            // Code to send notification via email
            Console.WriteLine("Sending notification to " + Email + " via email: " + message);
        }
    }

    public class SendViaMobile : ISubscriber
    {
        public string MobileNumber { get; set; }

        public SendViaMobile(string mobileNumber)
        {
            MobileNumber = mobileNumber;
        }

        public void ReceiveNotification(string message)
        {
            // Code to send notification via mobile
            Console.WriteLine("Sending notification to " + MobileNumber + " via SMS: " + message);
        }
    }
}
