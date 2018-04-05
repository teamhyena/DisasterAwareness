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
    public partial class AlertType : UserControl
    {
        Form1 parent;
        public bool realAlert=false;
        public AlertType()
        {
            InitializeComponent();
         
        }

        private void sendTestAlertBtn_Click(object sender, EventArgs e)
        {
            realAlert = false;
            parent.nextForm();
        }

        private void sendRealAlertBtn_Click(object sender, EventArgs e)
        {
            if (overrideCheckBox.Checked)
            {
                realAlert = true;
                parent.nextForm();
            }
        }

        private void AlertType_Load(object sender, EventArgs e)
        {
            parent = (Form1)this.Parent;
        }
    }
}
