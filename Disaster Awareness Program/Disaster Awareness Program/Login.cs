using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Disaster_Awareness_Program
{
    public partial class Login : UserControl
    {
        Int64 currentUserID;

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            userDataBase1.ReadXml("userDataBase.xml");
            //[TODO] Validate Response With Login
            Form1 parent = (Form1)this.Parent;
            var l = (from DataRow dr in userDataBase1.Tables["users"].Rows
                      where (string)dr["username"] == usernameTxtBox.Text && (string)dr["password"] == passwordTxtBox.Text
                      select (Int64)dr["userID"]);
            
         
            if (l.ToArray<Int64>().Length >0)   //Success
            {
                currentUserID = l.ToArray<Int64>()[0];
                logLogin(currentUserID);
                parent.nextForm();
            }
            else //Fail
            {
                //Ideally Remove for security in real application
                DataRow newUser = userDataBase1.Tables["users"].NewRow();
                newUser["username"] = usernameTxtBox.Text;
                newUser["password"] = passwordTxtBox.Text;
                newUser["userID"] =(Int64)( new Random().NextDouble());
                userDataBase1.Tables["users"].Rows.Add(newUser);
                logRegister(currentUserID);
                logLogin(currentUserID);
                parent.nextForm();
            }
            userDataBase1.WriteXml("userDataBase.xml");
        }
           
        private void logLogin(Int64 user)
        {
            DataRow newUser = userDataBase1.Tables["actionsPerformed"].NewRow();
            newUser["userID"] = user;
            newUser["date"] = DateTime.Now;
            newUser["actionPerformed"] = "Logged In";
            userDataBase1.Tables["actionsPerformed"].Rows.Add(newUser);
        }
        private void logRegister(Int64 user)
        {
            DataRow newUser = userDataBase1.Tables["actionsPerformed"].NewRow();
            newUser["userID"] = user;
            newUser["date"] = DateTime.Now;
            newUser["actionPerformed"] = "Registered New Account";
            userDataBase1.Tables["actionsPerformed"].Rows.Add(newUser);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var testForm = new InternalSystemTestForm();
            testForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!File.Exists("userDataBase.xml"))
            {
                MessageBox.Show("stating Program for the First Time. Performing Database Setup");
                userDataBase1.WriteXml("userDataBase.xml");
            }
        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
