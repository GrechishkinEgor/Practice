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
    public partial class WidthAndHeightForm : Form
    {
        public int WidthField { get; private set; } = 0;
        public int HeightField { get; private set; } = 0;
        public WidthAndHeightForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WidthAndHeightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                WidthField = Convert.ToInt32(WidthTextBox.Text);
                HeightField = Convert.ToInt32(HeightTextBox.Text);
                if (WidthField <= 0 || HeightField <= 0)
                    throw new Exception();
            }
            catch(Exception)
            {
                WidthTextBox.Text = "";
                HeightTextBox.Text = "";
                WidthField = 0;
                HeightField = 0;
                MessageBox.Show("Значения ширины или высоты некорректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            
        }
    }
}
