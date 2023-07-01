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
    public partial class SettingsPredatorSimulation : SettingsElementarySimulation
    {
        public int MaxLifeTimePredator { get; private set; } = 50;
        public int EnergyForChildPredator { get; private set; } = 60;
        public int ReproductionChancePredator { get; private set; } = 1000;
        public int EnergyForLifePredator { get; private set; } = 1;
        public int EnergyForMovePredator { get; private set; } = 5;
        public int StartEnergyPredator { get; private set; } = 250;

        public SettingsPredatorSimulation()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxLifeTimePredatorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newLifeTime = Convert.ToInt32(MaxLifeTimePredatorTextBox.Text);
                if (newLifeTime < 0)
                    throw new Exception();
            }
            catch
            {
                MaxLifeTimePredatorTextBox.Text = Convert.ToString(MaxLifeTimePredator);
            }
        }

        private void EnergyForChildPredatorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForChildPredatorTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                EnergyForChildTextBox.Text = Convert.ToString(EnergyForChildPredator);
            }
        }

        private void ReproductionChancePredatorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newChance = (int)(Convert.ToDouble(ReproductionChancePredatorTextBox.Text) * 10);
                if (newChance < 0 || newChance > 1000)
                    throw new Exception();
                ReproductionChancePredatorTextBox.Text = Convert.ToString(newChance / 10.0);
            }
            catch
            {
                ReproductionChancePredatorTextBox.Text = Convert.ToString(ReproductionChancePredator / 10);
            }
        }

        private void EnergyForLifePredatorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForLifePredatorTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                EnergyForLifePredatorTextBox.Text = Convert.ToString(EnergyForLifePredator);
            }
        }

        private void EnergyForMovePredatorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForMovePredatorTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                EnergyForMovePredatorTextBox.Text = Convert.ToString(EnergyForMovePredator);
            }
        }

        private void StartEnergyPredatorTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(StartEnergyPredatorTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                StartEnergyPredatorTextBox.Text = Convert.ToString(StartEnergyPredator);
            }
        }

        new private void OKButton_Click(object sender, EventArgs e)
        {
            MaxLifeTimePredator = Convert.ToInt32(MaxLifeTimePredatorTextBox.Text);
            EnergyForChildPredator = Convert.ToInt32(EnergyForChildPredatorTextBox.Text);
            ReproductionChancePredator = (int)(Convert.ToDouble(ReproductionChancePredatorTextBox.Text) * 10);
            EnergyForLifePredator = Convert.ToInt32(EnergyForLifePredatorTextBox.Text);
            EnergyForMovePredator = Convert.ToInt32(EnergyForMovePredatorTextBox.Text);
            StartEnergyPredator = Convert.ToInt32(StartEnergyPredatorTextBox.Text);
            base.OKButton_Click(sender, e);
        }

        private void SettingsPredatorSimulation_Load(object sender, EventArgs e)
        {
            MaxLifeTimePredatorTextBox.Text = Convert.ToString(MaxLifeTimePredator);
            EnergyForChildPredatorTextBox.Text = Convert.ToString(EnergyForChildPredator);
            ReproductionChancePredatorTextBox.Text = Convert.ToString(ReproductionChancePredator / 10.0);
            EnergyForLifePredatorTextBox.Text = Convert.ToString(EnergyForLifePredator);
            EnergyForMovePredatorTextBox.Text = Convert.ToString(EnergyForMovePredator);
            StartEnergyPredatorTextBox.Text = Convert.ToString(StartEnergyPredator);
        }
    }
}
