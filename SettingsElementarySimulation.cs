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
    public partial class SettingsElementarySimulation : Form
    {
        public SettingsElementarySimulation()
        {
            InitializeComponent();

            MaxLifeTimeTextBox.Text = Convert.ToString(MaxLifeTime);
            EnergyForChildTextBox.Text = Convert.ToString(EnergyForChild);
            ReproductionChanceTextBox.Text = Convert.ToString(ReproductionChance / 10);
            EnergyForLifeTextBox.Text = Convert.ToString(EnergyForLife);
            EnergyForMoveTextBox.Text = Convert.ToString(EnergyForMove);
            StartEnergyTextBox.Text = Convert.ToString(StartEnergy);
            FoodEnergyTextBox.Text = Convert.ToString(FoodEnergy);
            FoodGenerationSpeedTextBox.Text = Convert.ToString(FoodGenerationSpeed);
        }

        public int MaxLifeTime { get; private set; } = 50;
        public int EnergyForChild { get; private set; } = 60;
        public int ReproductionChance { get; private set; } = 1000;
        public int EnergyForLife { get; private set; } = 1;
        public int EnergyForMove { get; private set; } = 5;
        public int StartEnergy { get; private set; } = 250;
        public int FoodEnergy { get; private set; } = 90;
        public int FoodGenerationSpeed { get; private set; } = 30;

        private void MaxLifeTimeTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newLifeTime = Convert.ToInt32(MaxLifeTimeTextBox.Text);
                if (newLifeTime < 0)
                    throw new Exception();
                //MaxLifeTime = newLifeTime;
            }
            catch
            {
                MaxLifeTimeTextBox.Text = Convert.ToString(MaxLifeTime);
            }
        }

        private void SettingsElementarySimulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void EnergyForChildTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForChildTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
                //EnergyForChild = newEnergy;
            }
            catch
            {
                EnergyForChildTextBox.Text = Convert.ToString(EnergyForChild);
            }
        }

        private void ReproductionChanceTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newChance = (int)(Convert.ToDouble(ReproductionChanceTextBox.Text) * 10);
                if (newChance < 0 || newChance > 1000)
                    throw new Exception();
                //ReproductionChance = newChance;
                ReproductionChanceTextBox.Text = Convert.ToString(newChance / 10.0);
            }
            catch
            {
                ReproductionChanceTextBox.Text = Convert.ToString(ReproductionChance / 10);
            }
        }

        private void EnergyForLifeTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForLifeTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
                //EnergyForLife = newEnergy;
            }
            catch
            {
                EnergyForLifeTextBox.Text = Convert.ToString(EnergyForLife);
            }
        }

        private void EnergyForMoveTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(EnergyForMoveTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
                //EnergyForMove = newEnergy;
            }
            catch
            {
                EnergyForMoveTextBox.Text = Convert.ToString(EnergyForMove);
            }
        }

        private void StartEnergyTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(StartEnergyTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
                //StartEnergy = newEnergy;
            }
            catch
            {
                StartEnergyTextBox.Text = Convert.ToString(StartEnergy);
            }
        }

        private void FoodEnergyTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newEnergy = Convert.ToInt32(FoodEnergyTextBox.Text);
                if (newEnergy < 0)
                    throw new Exception();
                //FoodEnergy = newEnergy;
            }
            catch
            {
                FoodEnergyTextBox.Text = Convert.ToString(FoodEnergy);
            }
        }

        private void FoodGenerationSpeedTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int newSpeed = Convert.ToInt32(FoodGenerationSpeedTextBox.Text);
                if (newSpeed < 0)
                    throw new Exception();
                //FoodGenerationSpeed = newSpeed;
            }
            catch
            {
                FoodGenerationSpeedTextBox.Text = Convert.ToString(FoodGenerationSpeed);
            }
        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MaxLifeTime = Convert.ToInt32(MaxLifeTimeTextBox.Text);
            EnergyForChild = Convert.ToInt32(EnergyForChildTextBox.Text);
            ReproductionChance = (int)(Convert.ToDouble(ReproductionChanceTextBox.Text) * 10);
            EnergyForLife = Convert.ToInt32(EnergyForLifeTextBox.Text);
            EnergyForMove = Convert.ToInt32(EnergyForMoveTextBox.Text);
            StartEnergy = Convert.ToInt32(StartEnergyTextBox.Text);
            FoodEnergy = Convert.ToInt32(FoodEnergyTextBox.Text);
            FoodGenerationSpeed = Convert.ToInt32(FoodGenerationSpeedTextBox.Text);
            this.Close();
        }

        private void SettingsElementarySimulation_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            MaxLifeTimeTextBox.Text = Convert.ToString(MaxLifeTime);
            EnergyForChildTextBox.Text = Convert.ToString(EnergyForChild);
            ReproductionChanceTextBox.Text = Convert.ToString(ReproductionChance / 10);
            EnergyForLifeTextBox.Text = Convert.ToString(EnergyForLife);
            EnergyForMoveTextBox.Text = Convert.ToString(EnergyForMove);
            StartEnergyTextBox.Text = Convert.ToString(StartEnergy);
            FoodEnergyTextBox.Text = Convert.ToString(FoodEnergy);
            FoodGenerationSpeedTextBox.Text = Convert.ToString(FoodGenerationSpeed);
        }
    }
}
