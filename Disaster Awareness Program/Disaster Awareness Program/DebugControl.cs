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
    public partial class DebugControl : Form
    {
        Form1 parent;

       private class screens
        {
            string name;
            int index;
            public screens(string n, int i)
            {
                index = i;
                name = n;
            }
        }
        public DebugControl(Form1 parentTmp)
        {
            InitializeComponent();
            parent = parentTmp;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
       
        }

        private void DebugControl_Load(object sender, EventArgs e)
        {
            int i=0;
            foreach (UserControl u in parent.controlForms)
            {
                bindingSource1.Add(new screens(u.Name,i));
                i++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.showForm(parent.controlForms[listBox1.SelectedIndex]);
        }
    }
}
