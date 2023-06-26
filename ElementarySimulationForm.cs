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
    public partial class ElementarySimulationForm : Form
    {
        private fieldElementarySimulation simField;
        public ElementarySimulationForm()
        {
            InitializeComponent();

            WidthAndHeightForm sizeWin = new WidthAndHeightForm();
            sizeWin.ShowDialog();

            simField = new fieldElementarySimulation(sizeWin.WidthField, sizeWin.HeightField);
            foreach (PictureBox pictureBox in simField.PictureMatrix)
                this.Controls.Add(pictureBox);

            elementaryEntity ent = new elementaryEntity();
            ent.ReproductionChance = 1000;
            ent.Energy = 20000;
            ent.EnergyForChild = 100;
            ent.MaxLifeTime = 30;
            simField.AddEntity(ent, 4, 4);
        }

        private void ElementarySimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CloseApplication();
        }

        private void SomeActionButton_Click(object sender, EventArgs e)
        {
            //simField.EnabledDrawing = false;
            Beat.Enabled = Beat.Enabled == true ? false : true;
            //simField.DoBeat();
        }

        private void Beat_Tick(object sender, EventArgs e)
        {
            simField.DoBeat();
        }
    }
}
