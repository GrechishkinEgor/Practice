using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            if (sizeWin.ShowDialog() == DialogResult.OK)
            {
                WaitForm waitWin = new WaitForm();
                waitWin.Show();

                simField = new fieldElementarySimulation(sizeWin.WidthField, sizeWin.HeightField);
                foreach (PictureBox pictureBox in simField.PictureMatrix)
                    this.Controls.Add(pictureBox);
                FieldPanel.SendToBack();

                waitWin.Close();
                this.Show();
            }
            else
                this.Close();
        }

        private void ElementarySimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CloseApplication();
        }

        private void SomeActionButton_Click(object sender, EventArgs e)
        {
            //simField.EnabledDrawing = false;
            //Beat.Enabled = Beat.Enabled == true ? false : true;
            //simField.DoBeat();
        }

        private void Beat_Tick(object sender, EventArgs e)
        {
            simField.DoBeat();
            ElemEntCountLabel.Text = "Сущностей: " + Convert.ToString(simField.ElemEntCount);
        }

        private void SimRunButton_Click(object sender, EventArgs e)
        {
            if (SimRunButton.Text == "Запустить симуляцию")
            {
                SimRunButton.Text = "Остановить симуляцию";
                Beat.Enabled = true;
                EntitySettingsButton.Enabled = false;
                AddEntityButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                DrawingButton.Enabled = false;
            }
            else
            {
                Beat.Enabled = false;
                SimRunButton.Text = "Запустить симуляцию";
                EntitySettingsButton.Enabled = true;
                AddEntityButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
                DrawingButton.Enabled = true;
            }
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            if (AddEntityButton.Text == "Добавить сущность")
            {
                AddEntityButton.Text = "Завершить добавление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                simField.IsAdditionalMood = true;
            }
            else
            {
                AddEntityButton.Text = "Добавить сущность";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
                simField.IsAdditionalMood = false;
            }
        }

        private void FieldPanel_Click(object sender, EventArgs e)
        {
        }

        private void FieldPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FieldPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ElementarySimulationForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DeleteEntityButton_Click(object sender, EventArgs e)
        {
            if (DeleteEntityButton.Text == "Удалить сущность")
            {
                DeleteEntityButton.Text = "Завершить удаление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                AddEntityButton.Enabled = false;
                simField.IsDeletingMood = true;
            }
            else
            {
                DeleteEntityButton.Text = "Удалить сущность";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddEntityButton.Enabled = true;
                simField.IsDeletingMood = false;
            }
        }

        private void ElemEntCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void DrawingButton_Click(object sender, EventArgs e)
        {
            if (DrawingButton.Text == "Выключить отрисовку")
            {
                DrawingButton.Text = "Включить отрисовку";
                simField.EnabledDrawing = false;
            }
            else
            {
                DrawingButton.Text = "Выключить отрисовку";
                simField.EnabledDrawing = true;
            }
        }
    }
}
