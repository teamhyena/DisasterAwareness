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
    public partial class DeliveryType : UserControl
    {
        public DeliveryType()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Picture of the email icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string from = "name@gmail.com";
            string password = "password";
            string to = "to@gmail.com";
            string subject = "subject";
            string body = "body "; 
            
            SendEmail(password, subject, body, from, to);
        }

        protected void SendEmail(string _password, string _subject, string _body, string _from, string _to)
        {
            //string Text = "";
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
                Console.WriteLine("email was not sent successfully"); 
            }
        }
    }
}
