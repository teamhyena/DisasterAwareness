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
    public partial class IslandType : UserControl
    {
        Form1 parent;
        public List<String> islandsToContact;
        public IslandType()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hawaiiCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void televisionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mauiCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IslandType_Load(object sender, EventArgs e)
        {
            parent = (Form1)this.Parent;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            islandsToContact = new List<String>();
            if (hawaiiCheckBox.Checked)
            {
                islandsToContact.Add("Hawaii");
            }
            if (mauiCheckBox.Checked)
            {
                islandsToContact.Add("Maui");
            }
            if (molokaiCheckBox.Checked)
            {
                islandsToContact.Add("Molokai");
            }
            if (kahoolaweCheckBox.Checked)
            {
                islandsToContact.Add("Kahoolawe");
            }
            if (oahuCheckBox.Checked)
            {
                islandsToContact.Add("Oahu");
            }
            if (lanaiCheckBox.Checked)
            {
                islandsToContact.Add("Oahu");
            }
            if (kauaiCheckBox.Checked)
            {
                islandsToContact.Add("kauai");
            }
            parent.nextForm();
        }


    }
}
