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
    public partial class SettingsCompetitionSimulation : SettingsElementarySimulation
    {
        public int MaxLifeTimeSecondKind { get; private set; } = 50;
        public int EnergyForChildSecondKind { get; private set; } = 60;
        public int ReproductionChanceSecondKind { get; private set; } = 1000;
        public int EnergyForLifeSecondKind { get; private set; } = 1;
        public int EnergyForMoveSecondKind { get; private set; } = 5;
        public int StartEnergySecondKind { get; private set; } = 250;
        public SettingsCompetitionSimulation()
        {
            InitializeComponent();
        }

        private void SettingsCompetitionSimulation_Load(object sender, EventArgs e)
        {
            MaxLifeTimeSecondKindTextBox.Text = Convert.ToString(MaxLifeTimeSecondKind);
            EnergyForChildSecondKindTextBox.Text = Convert.ToString(EnergyForChildSecondKind);
            ReproductionChanceSecondKindTextBox.Text = Convert.ToString(ReproductionChanceSecondKind / 10.0);
            EnergyForLifeSecondKindTextBox.Text = Convert.ToString(EnergyForLifeSecondKind);
            EnergyForMoveSecondKindTextBox.Text = Convert.ToString(EnergyForMoveSecondKind);
            StartEnergySecondKindTextBox.Text = Convert.ToString(StartEnergySecondKind);
        }

        private void MaxLifeTimeSecondKindTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newLifeTime = Convert.ToInt32(MaxLifeTimeSecondKindTextBox.Text);
                if (newLifeTime < 0)
                    throw new Exception();
            }
            catch
            {
                MaxLifeTimeSecondKindTextBox.Text = Convert.ToString(MaxLifeTimeSecondKind);
            }
        }

        private void EnergyForChildSecondKindTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForChildSecondKindTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                EnergyForChildTextBox.Text = Convert.ToString(EnergyForChildSecondKind);
            }
        }

        private void ReproductionChanceSecondKindTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newChance = (int)(Convert.ToDouble(ReproductionChanceSecondKindTextBox.Text) * 10);
                if (newChance < 0 || newChance > 1000)
                    throw new Exception();
                ReproductionChanceSecondKindTextBox.Text = Convert.ToString(newChance / 10.0);
            }
            catch
            {
                ReproductionChanceSecondKindTextBox.Text = Convert.ToString(ReproductionChanceSecondKind / 10);
            }
        }

        private void EnergyForLifeSecondKindTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForLifeSecondKindTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                EnergyForLifeSecondKindTextBox.Text = Convert.ToString(EnergyForLifeSecondKind);
            }
        }

        private void EnergyForMoveSecondKindTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForMoveSecondKindTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                EnergyForMoveSecondKindTextBox.Text = Convert.ToString(EnergyForMoveSecondKind);
            }
        }

        private void StartEnergySecondKindTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(StartEnergySecondKindTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
            }
            catch
            {
                StartEnergySecondKindTextBox.Text = Convert.ToString(StartEnergySecondKind);
            }
        }

        private void OKButton_Click_1(object sender, EventArgs e)
        {
            MaxLifeTimeSecondKind = Convert.ToInt32(MaxLifeTimeSecondKindTextBox.Text);
            EnergyForChildSecondKind = Convert.ToInt32(EnergyForChildSecondKindTextBox.Text);
            ReproductionChanceSecondKind = (int)(Convert.ToDouble(ReproductionChanceSecondKindTextBox.Text) * 10);
            EnergyForLifeSecondKind = Convert.ToInt32(EnergyForLifeSecondKindTextBox.Text);
            EnergyForMoveSecondKind = Convert.ToInt32(EnergyForMoveSecondKindTextBox.Text);
            StartEnergySecondKind = Convert.ToInt32(StartEnergySecondKindTextBox.Text);
            base.OKButton_Click(sender, e);
        }
    }
}
