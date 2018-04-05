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
        public bool email = false;
        public bool siren = false;
        public bool text = false;
        public bool television = false;


        public DeliveryType()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Next button, will move to the next page and set the booleans based on checkboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            email = emailCheckBox.Checked;
            siren = sirenCheckBox.Checked;
            text = textCheckBox.Checked;
            television = televisionCheckBox.Checked;
        }
    }
}
