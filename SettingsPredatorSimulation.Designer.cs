namespace Practice
{
    partial class SettingsPredatorSimulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PredatorGroupBox = new System.Windows.Forms.GroupBox();
            this.StartEnergyPredatorTextBox = new System.Windows.Forms.TextBox();
            this.EnergyForMovePredatorTextBox = new System.Windows.Forms.TextBox();
            this.EnergyForLifePredatorTextBox = new System.Windows.Forms.TextBox();
            this.ReproductionChancePredatorTextBox = new System.Windows.Forms.TextBox();
            this.EnergyForChildPredatorTextBox = new System.Windows.Forms.TextBox();
            this.MaxLifeTimePredatorTextBox = new System.Windows.Forms.TextBox();
            this.ElementaryEntityGroupBox.SuspendLayout();
            this.FoodGroupBox.SuspendLayout();
            this.PredatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElementaryEntityGroupBox
            // 
            this.ElementaryEntityGroupBox.Text = "Травоядные существа";
            // 
            // FoodGroupBox
            // 
            this.FoodGroupBox.Location = new System.Drawing.Point(521, 12);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(285, 250);
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PredatorGroupBox
            // 
            this.PredatorGroupBox.Controls.Add(this.StartEnergyPredatorTextBox);
            this.PredatorGroupBox.Controls.Add(this.EnergyForMovePredatorTextBox);
            this.PredatorGroupBox.Controls.Add(this.EnergyForLifePredatorTextBox);
            this.PredatorGroupBox.Controls.Add(this.ReproductionChancePredatorTextBox);
            this.PredatorGroupBox.Controls.Add(this.EnergyForChildPredatorTextBox);
            this.PredatorGroupBox.Controls.Add(this.MaxLifeTimePredatorTextBox);
            this.PredatorGroupBox.Location = new System.Drawing.Point(354, 12);
            this.PredatorGroupBox.Name = "PredatorGroupBox";
            this.PredatorGroupBox.Size = new System.Drawing.Size(161, 232);
            this.PredatorGroupBox.TabIndex = 3;
            this.PredatorGroupBox.TabStop = false;
            this.PredatorGroupBox.Text = "Хищники";
            // 
            // StartEnergyPredatorTextBox
            // 
            this.StartEnergyPredatorTextBox.Location = new System.Drawing.Point(17, 177);
            this.StartEnergyPredatorTextBox.MaxLength = 10;
            this.StartEnergyPredatorTextBox.Name = "StartEnergyPredatorTextBox";
            this.StartEnergyPredatorTextBox.Size = new System.Drawing.Size(130, 23);
            this.StartEnergyPredatorTextBox.TabIndex = 4;
            this.StartEnergyPredatorTextBox.Leave += new System.EventHandler(this.StartEnergyPredatorTextBox_Leave);
            // 
            // EnergyForMovePredatorTextBox
            // 
            this.EnergyForMovePredatorTextBox.Location = new System.Drawing.Point(17, 148);
            this.EnergyForMovePredatorTextBox.MaxLength = 10;
            this.EnergyForMovePredatorTextBox.Name = "EnergyForMovePredatorTextBox";
            this.EnergyForMovePredatorTextBox.Size = new System.Drawing.Size(130, 23);
            this.EnergyForMovePredatorTextBox.TabIndex = 4;
            this.EnergyForMovePredatorTextBox.Leave += new System.EventHandler(this.EnergyForMovePredatorTextBox_Leave);
            // 
            // EnergyForLifePredatorTextBox
            // 
            this.EnergyForLifePredatorTextBox.Location = new System.Drawing.Point(17, 119);
            this.EnergyForLifePredatorTextBox.MaxLength = 10;
            this.EnergyForLifePredatorTextBox.Name = "EnergyForLifePredatorTextBox";
            this.EnergyForLifePredatorTextBox.Size = new System.Drawing.Size(130, 23);
            this.EnergyForLifePredatorTextBox.TabIndex = 3;
            this.EnergyForLifePredatorTextBox.Leave += new System.EventHandler(this.EnergyForLifePredatorTextBox_Leave);
            // 
            // ReproductionChancePredatorTextBox
            // 
            this.ReproductionChancePredatorTextBox.Location = new System.Drawing.Point(17, 88);
            this.ReproductionChancePredatorTextBox.MaxLength = 5;
            this.ReproductionChancePredatorTextBox.Name = "ReproductionChancePredatorTextBox";
            this.ReproductionChancePredatorTextBox.Size = new System.Drawing.Size(130, 23);
            this.ReproductionChancePredatorTextBox.TabIndex = 2;
            this.ReproductionChancePredatorTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.ReproductionChancePredatorTextBox.Leave += new System.EventHandler(this.ReproductionChancePredatorTextBox_Leave);
            // 
            // EnergyForChildPredatorTextBox
            // 
            this.EnergyForChildPredatorTextBox.Location = new System.Drawing.Point(17, 58);
            this.EnergyForChildPredatorTextBox.MaxLength = 10;
            this.EnergyForChildPredatorTextBox.Name = "EnergyForChildPredatorTextBox";
            this.EnergyForChildPredatorTextBox.Size = new System.Drawing.Size(130, 23);
            this.EnergyForChildPredatorTextBox.TabIndex = 1;
            this.EnergyForChildPredatorTextBox.Leave += new System.EventHandler(this.EnergyForChildPredatorTextBox_Leave);
            // 
            // MaxLifeTimePredatorTextBox
            // 
            this.MaxLifeTimePredatorTextBox.Location = new System.Drawing.Point(17, 29);
            this.MaxLifeTimePredatorTextBox.MaxLength = 10;
            this.MaxLifeTimePredatorTextBox.Name = "MaxLifeTimePredatorTextBox";
            this.MaxLifeTimePredatorTextBox.Size = new System.Drawing.Size(130, 23);
            this.MaxLifeTimePredatorTextBox.TabIndex = 0;
            this.MaxLifeTimePredatorTextBox.Leave += new System.EventHandler(this.MaxLifeTimePredatorTextBox_Leave);
            // 
            // SettingsPredatorSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 299);
            this.Controls.Add(this.PredatorGroupBox);
            this.Name = "SettingsPredatorSimulation";
            this.Load += new System.EventHandler(this.SettingsPredatorSimulation_Load);
            this.Controls.SetChildIndex(this.ElementaryEntityGroupBox, 0);
            this.Controls.SetChildIndex(this.FoodGroupBox, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.PredatorGroupBox, 0);
            this.ElementaryEntityGroupBox.ResumeLayout(false);
            this.ElementaryEntityGroupBox.PerformLayout();
            this.FoodGroupBox.ResumeLayout(false);
            this.FoodGroupBox.PerformLayout();
            this.PredatorGroupBox.ResumeLayout(false);
            this.PredatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PredatorGroupBox;
        private TextBox StartEnergyPredatorTextBox;
        private TextBox EnergyForMovePredatorTextBox;
        private TextBox EnergyForLifePredatorTextBox;
        private TextBox ReproductionChancePredatorTextBox;
        private TextBox EnergyForChildPredatorTextBox;
        private TextBox MaxLifeTimePredatorTextBox;
    }
}