﻿using System;
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
    public partial class ElementarySimulationForm : Form
    {
        public ElementarySimulationForm()
        {
            InitializeComponent();
        }

        private void ElementarySimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CloseApplication();
        }
    }
}
