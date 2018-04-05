using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Specialized;

namespace Disaster_Awareness_Program
{
    public partial class ContentSummary : UserControl
    {
        //Empty for Security Reasons
        private string webClientTextKey = "";
        Form1 parent;
        public ContentSummary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Send Alert Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {

            SendTexts();

            if (parent.deliveryType1.email)
            {
                SendEmails();
            }
        }


        /// <summary>
        /// Loads the email contents and parameters and calls SendEmail repeatedly to send them 
        /// 0 - no errors >0 - indicates errors 
        /// </summary>
        /// <returns></returns>
        public int SendEmails()
        {
            string from = "teamhyenatest@gmail.com";
            string password = "ics414Test";
            string subject = GetEmailSubject();
            string body = GetEmailBody();

            IList<string> emails = new List<string>();
            emails = AddEmailstoSend(emails);

            int ret = 0;
            foreach (var email in emails)
            {
                ret += SendEmail(password, subject, body, from, email);
            }
            return ret;
        }

        private String GetEmailSubject()
        {
            String message = "";
            String currentDisasterName = Enum.GetName(typeof(DisasterType.disasterType), parent.disasterType1.currentDisasterType);

            if (!parent.alertType1.realAlert)
            {
                message += "--Hawaii State Emergency Alert Service: This Is a Test-- ";
                message += currentDisasterName + " Alert";
            }
            else
            {
                message += "--Hawaii State Emergency Alert Service: " + currentDisasterName + " Alert ";
                message += "This is NOT a Drill--";

            }
            return message;
        }
        private String GetEmailBody()
        {
            return generateTextBody();
        }

        /// <summary>
        /// Loads all the emails to send the warning to 
        /// </summary>
        /// <param name="emails"></param>
        /// <returns></returns>
        private IList<String> AddEmailstoSend(IList<String> emails)
        {
            emails.Add("teamhyenatest@gmail.com");
            return emails;
        }


        /// <summary>
        /// Sends the email with the given parameters 
        /// 0 - no errors >0 - indicates errors 
        /// </summary>
        /// <param name="_password"></param>
        /// <param name="_subject"></param>
        /// <param name="_body"></param>
        /// <param name="_from"></param>
        /// <param name="_to"></param>
        public int SendEmail(string _password, string _subject, string _body, string _from, string _to)
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new NetworkCredential(_from, _password);
            try
            {
                mailClient.Send(_from, _to, _subject, _body);
                Console.WriteLine("email sent successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("email was not sent successfully" + e);
                return 1;
            }
            return 0;
        }

        public bool SendText(string _phoneNumber, string _body)
        {
            try
            {
                WebClient wClient = new WebClient();
                byte[] response = wClient.UploadValues("http://textbelt.com/text", new NameValueCollection() {
              { "phone", _phoneNumber},
              { "message",_body},
              { "key", webClientTextKey } });
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void SendTexts()
        {
            foreach (DataRow dr in userDataBase1.Tables[0].Rows)
            {
                SendText(dr["number"].ToString(), generateTextBody());
            }

        }

        public string generateTextBody()
        {
            String message = "";
            String currentDisasterName = Enum.GetName(typeof(DisasterType.disasterType), parent.disasterType1.currentDisasterType);

            if (!parent.alertType1.realAlert)
            {
                message += "--This is a test of the Hawaii State Emergency Alert Service--\n";
            }
            message += currentDisasterName + " Alert for the islands of:";
            foreach (String island in parent.islandType1.islandsToContact)
            {
                message += island + " ";
            }
            return message;
        }
        private void ContentSummary_Load(object sender, EventArgs e)
        {
            parent = (Form1)this.Parent;
        }
    }
}
