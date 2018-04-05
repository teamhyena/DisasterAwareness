using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disaster_Awareness_Program
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //[TODO] Validate Response With Login
            Form1 parent = (Form1) this.Parent;
            parent.nextForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var testForm = new InternalSystemTestForm();
            testForm.Show();
        }
    }
}
