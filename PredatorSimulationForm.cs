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

        private void SimRunButton_Click(object sender, EventArgs e)
        {
            if (SimRunButton.Text == "Запустить симуляцию")
            {
                SimRunButton.Text = "Остановить симуляцию";
                Beat.Enabled = true;
                EntitySettingsButton.Enabled = false;
                AddHerbivoreButton.Enabled = false;
                AddPredatorButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                DrawingButton.Enabled = false;
            }
            else
            {
                Beat.Enabled = false;
                SimRunButton.Text = "Запустить симуляцию";
                EntitySettingsButton.Enabled = true;
                AddHerbivoreButton.Enabled = true;
                AddPredatorButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
                DrawingButton.Enabled = true;
            }
        }

        private void EntitySettingsButton_Click(object sender, EventArgs e)
        {
            simField.SettingsWin.ShowDialog();
        }

        private void AddHerbivoreButton_Click(object sender, EventArgs e)
        {
            if (AddHerbivoreButton.Text == "Добавить травоядное")
            {
                AddHerbivoreButton.Text = "Завершить добавление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                AddPredatorButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                DrawingButton.Enabled = false;
                simField.IsAdditionalMood = true;
            }
            else
            {
                AddHerbivoreButton.Text = "Добавить травоядное";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddPredatorButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
                DrawingButton.Enabled = true;
                simField.IsAdditionalMood = false;
            }
        }

        private void DeleteEntityButton_Click(object sender, EventArgs e)
        {
            if (DeleteEntityButton.Text == "Удалить сущность")
            {
                DeleteEntityButton.Text = "Завершить удаление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                AddHerbivoreButton.Enabled = false;
                AddPredatorButton.Enabled = false;
                DrawingButton.Enabled = false;
                simField.IsDeletingMood = true;
            }
            else
            {
                DeleteEntityButton.Text = "Удалить сущность";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddHerbivoreButton.Enabled = true;
                AddPredatorButton.Enabled = true;
                DrawingButton.Enabled = true;
                simField.IsDeletingMood = false;
            }
        }

        private void AddPredatorButton_Click(object sender, EventArgs e)
        {
            if (AddPredatorButton.Text == "Добавить хищника")
            {
                AddPredatorButton.Text = "Завершить добавление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                AddHerbivoreButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                DrawingButton.Enabled = false;
                simField.IsAdditionalMood = true;
                simField.IsPredatorAdded = true;
            }
            else
            {
                AddPredatorButton.Text = "Добавить хищника";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddHerbivoreButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
                DrawingButton.Enabled = true;
                simField.IsAdditionalMood = false;
                simField.IsPredatorAdded = false;
            }
        }

        private void Beat_Tick(object sender, EventArgs e)
        {
            simField.DoBeat();
            ElemEntCountLabel.Text = "Всего сущностей: " + Convert.ToString(simField.ElemEntCount);
            HerbivoreCountLabel.Text = "Травоядные: " + Convert.ToString(simField.ElemEntCount - simField.PredatorsCount);
            PredatorsCountLabel.Text = "Хищники: " + Convert.ToString(simField.PredatorsCount);
        }

        private void PredatorSimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CloseApplication();
        }
    }
}
