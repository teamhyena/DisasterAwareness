using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disaster_Awareness_Program
{
    public partial class InternalSystemTestForm : Form
    {
        public InternalSystemTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var testDelivery = new ContentSummary();
            // test text
            if (testDelivery.SendText("7146846341", "Internal System Test:Text Message"))
            {
                lblTextMessageResult.ForeColor = Color.Green;
                lblTextMessageResult.Text = "Success";
            }
            else
            {
                lblTextMessageResult.ForeColor = Color.Salmon;
                lblTextMessageResult.Text = "Failed";
            }

            // test email
            string from = "teamhyenatest@gmail.com";
            string password = "ics414Test";

            if (testDelivery.SendEmail(password, "Internal System Test:Email", "Internal System Test", from, "nlababid@hawaii.edu") != 0)
            {
                lblEmailResult.ForeColor = Color.Green;
                lblEmailResult.Text = "Success";
            }
            else
            {
                lblEmailResult.ForeColor = Color.Salmon;
                lblEmailResult.Text = "Failed";
            }
        }
    }
}
