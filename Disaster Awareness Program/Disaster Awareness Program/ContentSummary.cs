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

namespace Disaster_Awareness_Program
{
    public partial class ContentSummary : UserControl
    {
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
            
            SendEmails(); 
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
            string subject = "subject";
            string body = "body baby";

            IList<string> emails = new List<string>();
            emails = AddEmailstoSend(emails);
            
            int ret = 0; 
            foreach (var email in emails)
            {
                ret += SendEmail(password, subject, body, from, email);
            }

            return ret; 
        }

        /// <summary>
        /// Loads all the emails to send the warning to 
        /// </summary>
        /// <param name="emails"></param>
        /// <returns></returns>
        private IList<String> AddEmailstoSend(IList<String> emails)
        {
            emails.Add("ark.mymail@gmail.com");
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
                MessageBox.Show("email sent successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("email was not sent successfully");
                return 1; 
            }
            return 0;
        }
    }
}
