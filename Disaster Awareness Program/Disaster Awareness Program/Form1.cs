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
        UserControl currentForm;
        public List<UserControl> controlForms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlForms = new List<UserControl>();
            controlForms.Add(login1);//0
            controlForms.Add(alertType1);//1
            controlForms.Add(disasterType1);//2
            controlForms.Add(deliveryType1);//3
            controlForms.Add(islandType1);//4
            controlForms.Add(contentSummary1);//5
            foreach (UserControl form in controlForms)
            {
                hideForm(form);
            }
            showForm(login1);


        }


        private void hideForm(UserControl form)
        {
            form.Visible = false;
            form.Enabled = false;
        }

        public void showForm(UserControl form)
        {
            currentForm = form;
            foreach (UserControl form2 in controlForms)
            {
                hideForm(form2);
            }
            form.Visible = true;
            form.Enabled = true;
        }
        public void nextForm()
        {
            showForm(controlForms[controlForms.IndexOf(currentForm) + 1]);
        }
        private void alertType1_Load(object sender, EventArgs e)
        {

        }

        private void contentSummary1_Load(object sender, EventArgs e)
        {

        }
    }
}
