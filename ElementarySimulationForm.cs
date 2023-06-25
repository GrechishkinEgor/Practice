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
        private PictureBox[,] pictureMatrix;
        public ElementarySimulationForm()
        {
            InitializeComponent();

            WidthAndHeightForm sizeWin = new WidthAndHeightForm();
            sizeWin.ShowDialog();

            simField = new fieldElementarySimulation(sizeWin.WidthField, sizeWin.HeightField);
            pictureMatrix = new PictureBox[sizeWin.WidthField, sizeWin.HeightField];

            this.SuspendLayout();
            for (int i = 0; i < sizeWin.WidthField; i++)
                for (int j = 0; j < sizeWin.HeightField; j++)
                {
                    PictureBox somePicture = new PictureBox();
                    somePicture.BackColor = System.Drawing.SystemColors.Control;
                    somePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    somePicture.Image = global::Practice.Properties.Resources.EmptyEntity;
                    somePicture.Location = new System.Drawing.Point(200 + i * 35, j * 35);
                    somePicture.Name = "PictureBox[" + Convert.ToString(i) + "][" + Convert.ToString(j) + "]";
                    somePicture.Size = new System.Drawing.Size(34, 34);
                    somePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    somePicture.TabIndex = 0;
                    somePicture.TabStop = false;

                    pictureMatrix[i, j] = somePicture;
                    this.Controls.Add(somePicture);
                }
            this.ResumeLayout(false);
        }

        private void ElementarySimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CloseApplication();
        }
    }
}
