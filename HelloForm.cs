using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ChosenSimulationBox.Text != null && ChosenSimulationBox.Text != "")
            {
                Program.ChosenSimulation = ChosenSimulationBox.Text;
                this.Hide();
                Program.OpenSimulation();
            }
        }

        private void HelloForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
