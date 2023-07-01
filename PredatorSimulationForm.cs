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
    public partial class PredatorSimulationForm : Form
    {
        private fieldPredator simField;
        public PredatorSimulationForm()
        {
            InitializeComponent();

            WidthAndHeightForm sizeWin = new WidthAndHeightForm();
            if (sizeWin.ShowDialog() == DialogResult.OK)
            {
                simField = new fieldPredator(sizeWin.WidthField, sizeWin.HeightField);
                this.Controls.Add(simField.GetPicture);
                FieldPanel.SendToBack();
                this.Show();
            }
            else
                this.Close();
        }
    }
}
