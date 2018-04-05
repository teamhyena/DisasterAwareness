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
    public partial class Form1 : Form
    {
        public List<UserControl> controlForms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlForms = new List<UserControl>();
            controlForms.Add(login1);
            controlForms.Add(alertType1);
            controlForms.Add(disasterType1);
            controlForms.Add(deliveryType1);
            controlForms.Add(islandType1);
            controlForms.Add(contentSummary1);
            foreach (UserControl form in controlForms)
            {
                hideForm(form);
            }
            showForm(login1);


            //Debug
            DebugControl debug = new DebugControl(this);
            debug.Show();
        }


        private void hideForm(UserControl form)
        {
            form.Visible = false;
            form.Enabled = false;
        }

        public void showForm(UserControl form)
        {
            foreach (UserControl form2 in controlForms)
            {
                hideForm(form2);
            }
            form.Visible = true;
            form.Enabled = true;
        }
        private void alertType1_Load(object sender, EventArgs e)
        {

        }

        private void contentSummary1_Load(object sender, EventArgs e)
        {

        }
    }
}
