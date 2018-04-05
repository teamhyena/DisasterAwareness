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
    public partial class DisasterType : UserControl
    {
        public enum disasterType { Tornado, Flood, Hurricane, Tsunami, Earthquake, Nuclear };
        public disasterType currentDisasterType;
        Form1 parent;
        public DisasterType()
        {
            InitializeComponent();
        }
    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void overrideCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendRealAlertBtn_Click(object sender, EventArgs e)
        {

        }

        private void sendTestAlertBtn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentDisasterType = disasterType.Tornado;
            parent.nextForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentDisasterType = disasterType.Flood;
            parent.nextForm();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DisasterType_Load(object sender, EventArgs e)
        {
            parent = (Form1)this.Parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentDisasterType = disasterType.Hurricane;
            parent.nextForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentDisasterType = disasterType.Tsunami;
            parent.nextForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentDisasterType = disasterType.Earthquake;
            parent.nextForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentDisasterType = disasterType.Nuclear;
            parent.nextForm();
        }
    }
}
