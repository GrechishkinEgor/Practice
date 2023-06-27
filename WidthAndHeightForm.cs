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
        private bool IsOKButtonPressed { get; set; } = false;
        public WidthAndHeightForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            IsOKButtonPressed = true;
            this.Close();
        }

        private void WidthAndHeightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsOKButtonPressed)
                try
                {
                    WidthField = Convert.ToInt32(WidthTextBox.Text);
                    HeightField = Convert.ToInt32(HeightTextBox.Text);
                    if (WidthField <= 0 || HeightField <= 0 || WidthField * HeightField > 5000)
                        throw new Exception();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    IsOKButtonPressed = false;
                    WidthTextBox.Text = "";
                    HeightTextBox.Text = "";
                    WidthField = 0;
                    HeightField = 0;
                    MessageBox.Show("Значения ширины или высоты некорректны. \nВаше поле не должно быть больше 5000 клеток.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            else
            {
                Program.OpenHelloForm();
                this.DialogResult = DialogResult.Cancel;
            }
                
            
        }
    }
}
