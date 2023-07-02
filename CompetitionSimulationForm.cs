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
    public partial class CompetitionSimulationForm : Form
    {
        private fieldCompetitionSimulation simField;
        public CompetitionSimulationForm()
        {
            InitializeComponent();

            WidthAndHeightForm sizeWin = new WidthAndHeightForm();
            if (sizeWin.ShowDialog() == DialogResult.OK)
            {
                simField = new fieldCompetitionSimulation(sizeWin.WidthField, sizeWin.HeightField);
                this.Controls.Add(simField.GetPicture);
                FieldPanel.SendToBack();
                this.Show();
            }
            else
                this.Close();
        }

        private void CompetitionSimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CloseApplication();
        }

        private void Beat_Tick(object sender, EventArgs e)
        {
            simField.DoBeat();
            ElemEntCountLabel.Text = "Всего сущностей: " + Convert.ToString(simField.FirstKindCount + simField.SecondKindCount);
            FirstKindCountLabel.Text = "Первый вид: " + Convert.ToString(simField.FirstKindCount);
            SecondKindCountLabel.Text = "Второй вид: " + Convert.ToString(simField.SecondKindCount);
        }

        private void SimRunButton_Click(object sender, EventArgs e)
        {
            if (SimRunButton.Text == "Запустить симуляцию")
            {
                SimRunButton.Text = "Остановить симуляцию";
                Beat.Enabled = true;
                EntitySettingsButton.Enabled = false;
                AddFirstKindButton.Enabled = false;
                AddSecondKindButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
            }
            else
            {
                Beat.Enabled = false;
                SimRunButton.Text = "Запустить симуляцию";
                EntitySettingsButton.Enabled = true;
                AddFirstKindButton.Enabled = true;
                AddSecondKindButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
            }
        }

        private void EntitySettingsButton_Click(object sender, EventArgs e)
        {
            simField.SettingsWin.ShowDialog();
        }

        private void AddFirstKindButton_Click(object sender, EventArgs e)
        {
            if (AddFirstKindButton.Text == "Добавить первый вид")
            {
                AddFirstKindButton.Text = "Завершить добавление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                AddSecondKindButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                simField.IsAdditionalMood = true;
                simField.IsSecondKindAdded = false;
            }
            else
            {
                AddFirstKindButton.Text = "Добавить первый вид";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddSecondKindButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
                simField.IsAdditionalMood = false;
            }
        }

        private void AddSecondKindButton_Click(object sender, EventArgs e)
        {
            if (AddSecondKindButton.Text == "Добавить второй вид")
            {
                AddSecondKindButton.Text = "Завершить добавление";
                SimRunButton.Enabled = false;
                EntitySettingsButton.Enabled = false;
                AddFirstKindButton.Enabled = false;
                DeleteEntityButton.Enabled = false;
                simField.IsAdditionalMood = true;
                simField.IsSecondKindAdded = true;
            }
            else
            {
                AddSecondKindButton.Text = "Добавить второй вид";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddFirstKindButton.Enabled = true;
                DeleteEntityButton.Enabled = true;
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
                AddFirstKindButton.Enabled = false;
                AddSecondKindButton.Enabled = false;
                simField.IsDeletingMood = true;
            }
            else
            {
                DeleteEntityButton.Text = "Удалить сущность";
                SimRunButton.Enabled = true;
                EntitySettingsButton.Enabled = true;
                AddFirstKindButton.Enabled = true;
                AddSecondKindButton.Enabled = true;
                simField.IsDeletingMood = false;
            }
        }
    }
}
