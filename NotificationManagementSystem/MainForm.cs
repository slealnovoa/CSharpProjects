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
    public partial class MainForm : Form
    {
        private List<ISubscriber> subscribers;
        private bool hasSubscribers;
        public MainForm()
        {
            InitializeComponent();
            subscribers = new List<ISubscriber>();
            hasSubscribers = false;
            publishButton.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm(subscribers);
            notificationForm.ShowDialog();
        }

        private void manageSubButton_Click(object sender, EventArgs e)
        {
            SubscriptionForm subscriptionForm = new SubscriptionForm(subscribers);
            DialogResult result = subscriptionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                subscribers = subscriptionForm.Subscribers;
                hasSubscribers = subscribers.Count > 0; // update hasSubscribers based on the number of subscribers
                publishButton.Enabled = hasSubscribers; // enable or disable publishButton based on hasSubscribers
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
