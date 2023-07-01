namespace Practice
{
    partial class SettingsElementarySimulation
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
            this.ElementaryEntityGroupBox = new System.Windows.Forms.GroupBox();
            this.StartEnergyTextBox = new System.Windows.Forms.TextBox();
            this.StartEnergyLabel = new System.Windows.Forms.Label();
            this.EnergyForMoveTextBox = new System.Windows.Forms.TextBox();
            this.EnergyForMoveLabel = new System.Windows.Forms.Label();
            this.EnergyForLifeTextBox = new System.Windows.Forms.TextBox();
            this.EnergyForLifeLabel = new System.Windows.Forms.Label();
            this.ReproductionChanceTextBox = new System.Windows.Forms.TextBox();
            this.ReproductionChanceLabel = new System.Windows.Forms.Label();
            this.EnergyForChildTextBox = new System.Windows.Forms.TextBox();
            this.EnergyForChildLabel = new System.Windows.Forms.Label();
            this.MaxLifeTimeTextBox = new System.Windows.Forms.TextBox();
            this.MaxLifeTimeLabel = new System.Windows.Forms.Label();
            this.FoodGroupBox = new System.Windows.Forms.GroupBox();
            this.FoodGenerationSpeedTextBox = new System.Windows.Forms.TextBox();
            this.GenerationSpeedLabel = new System.Windows.Forms.Label();
            this.FoodEnergyTextBox = new System.Windows.Forms.TextBox();
            this.FoodEnergyLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ElementaryEntityGroupBox.SuspendLayout();
            this.FoodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElementaryEntityGroupBox
            // 
            this.ElementaryEntityGroupBox.Controls.Add(this.StartEnergyTextBox);
            this.ElementaryEntityGroupBox.Controls.Add(this.StartEnergyLabel);
            this.ElementaryEntityGroupBox.Controls.Add(this.EnergyForMoveTextBox);
            this.ElementaryEntityGroupBox.Controls.Add(this.EnergyForMoveLabel);
            this.ElementaryEntityGroupBox.Controls.Add(this.EnergyForLifeTextBox);
            this.ElementaryEntityGroupBox.Controls.Add(this.EnergyForLifeLabel);
            this.ElementaryEntityGroupBox.Controls.Add(this.ReproductionChanceTextBox);
            this.ElementaryEntityGroupBox.Controls.Add(this.ReproductionChanceLabel);
            this.ElementaryEntityGroupBox.Controls.Add(this.EnergyForChildTextBox);
            this.ElementaryEntityGroupBox.Controls.Add(this.EnergyForChildLabel);
            this.ElementaryEntityGroupBox.Controls.Add(this.MaxLifeTimeTextBox);
            this.ElementaryEntityGroupBox.Controls.Add(this.MaxLifeTimeLabel);
            this.ElementaryEntityGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ElementaryEntityGroupBox.Name = "ElementaryEntityGroupBox";
            this.ElementaryEntityGroupBox.Size = new System.Drawing.Size(336, 232);
            this.ElementaryEntityGroupBox.TabIndex = 0;
            this.ElementaryEntityGroupBox.TabStop = false;
            this.ElementaryEntityGroupBox.Text = "Элементарные существа";
            // 
            // StartEnergyTextBox
            // 
            this.StartEnergyTextBox.Location = new System.Drawing.Point(200, 177);
            this.StartEnergyTextBox.MaxLength = 10;
            this.StartEnergyTextBox.Name = "StartEnergyTextBox";
            this.StartEnergyTextBox.Size = new System.Drawing.Size(130, 23);
            this.StartEnergyTextBox.TabIndex = 11;
            this.StartEnergyTextBox.Leave += new System.EventHandler(this.StartEnergyTextBox_Leave);
            // 
            // StartEnergyLabel
            // 
            this.StartEnergyLabel.AutoSize = true;
            this.StartEnergyLabel.Location = new System.Drawing.Point(7, 180);
            this.StartEnergyLabel.Name = "StartEnergyLabel";
            this.StartEnergyLabel.Size = new System.Drawing.Size(133, 15);
            this.StartEnergyLabel.TabIndex = 10;
            this.StartEnergyLabel.Text = "Энергия при создании:";
            // 
            // EnergyForMoveTextBox
            // 
            this.EnergyForMoveTextBox.Location = new System.Drawing.Point(200, 148);
            this.EnergyForMoveTextBox.MaxLength = 10;
            this.EnergyForMoveTextBox.Name = "EnergyForMoveTextBox";
            this.EnergyForMoveTextBox.Size = new System.Drawing.Size(130, 23);
            this.EnergyForMoveTextBox.TabIndex = 9;
            this.EnergyForMoveTextBox.Leave += new System.EventHandler(this.EnergyForMoveTextBox_Leave);
            // 
            // EnergyForMoveLabel
            // 
            this.EnergyForMoveLabel.AutoSize = true;
            this.EnergyForMoveLabel.Location = new System.Drawing.Point(6, 151);
            this.EnergyForMoveLabel.Name = "EnergyForMoveLabel";
            this.EnergyForMoveLabel.Size = new System.Drawing.Size(134, 15);
            this.EnergyForMoveLabel.TabIndex = 8;
            this.EnergyForMoveLabel.Text = "Энергия для движения:";
            // 
            // EnergyForLifeTextBox
            // 
            this.EnergyForLifeTextBox.Location = new System.Drawing.Point(200, 119);
            this.EnergyForLifeTextBox.MaxLength = 10;
            this.EnergyForLifeTextBox.Name = "EnergyForLifeTextBox";
            this.EnergyForLifeTextBox.Size = new System.Drawing.Size(130, 23);
            this.EnergyForLifeTextBox.TabIndex = 7;
            this.EnergyForLifeTextBox.Leave += new System.EventHandler(this.EnergyForLifeTextBox_Leave);
            // 
            // EnergyForLifeLabel
            // 
            this.EnergyForLifeLabel.AutoSize = true;
            this.EnergyForLifeLabel.Location = new System.Drawing.Point(6, 122);
            this.EnergyForLifeLabel.Name = "EnergyForLifeLabel";
            this.EnergyForLifeLabel.Size = new System.Drawing.Size(188, 15);
            this.EnergyForLifeLabel.TabIndex = 6;
            this.EnergyForLifeLabel.Text = "Энергия для жизнедеятельности:";
            // 
            // ReproductionChanceTextBox
            // 
            this.ReproductionChanceTextBox.Location = new System.Drawing.Point(200, 88);
            this.ReproductionChanceTextBox.MaxLength = 5;
            this.ReproductionChanceTextBox.Name = "ReproductionChanceTextBox";
            this.ReproductionChanceTextBox.Size = new System.Drawing.Size(130, 23);
            this.ReproductionChanceTextBox.TabIndex = 5;
            this.ReproductionChanceTextBox.Leave += new System.EventHandler(this.ReproductionChanceTextBox_Leave);
            // 
            // ReproductionChanceLabel
            // 
            this.ReproductionChanceLabel.AutoSize = true;
            this.ReproductionChanceLabel.Location = new System.Drawing.Point(6, 91);
            this.ReproductionChanceLabel.Name = "ReproductionChanceLabel";
            this.ReproductionChanceLabel.Size = new System.Drawing.Size(152, 15);
            this.ReproductionChanceLabel.TabIndex = 4;
            this.ReproductionChanceLabel.Text = "Шанс размножения (в %): ";
            // 
            // EnergyForChildTextBox
            // 
            this.EnergyForChildTextBox.Location = new System.Drawing.Point(200, 58);
            this.EnergyForChildTextBox.MaxLength = 10;
            this.EnergyForChildTextBox.Name = "EnergyForChildTextBox";
            this.EnergyForChildTextBox.Size = new System.Drawing.Size(130, 23);
            this.EnergyForChildTextBox.TabIndex = 3;
            this.EnergyForChildTextBox.Leave += new System.EventHandler(this.EnergyForChildTextBox_Leave);
            // 
            // EnergyForChildLabel
            // 
            this.EnergyForChildLabel.AutoSize = true;
            this.EnergyForChildLabel.Location = new System.Drawing.Point(6, 61);
            this.EnergyForChildLabel.Name = "EnergyForChildLabel";
            this.EnergyForChildLabel.Size = new System.Drawing.Size(112, 15);
            this.EnergyForChildLabel.TabIndex = 2;
            this.EnergyForChildLabel.Text = "Энергия потомков:";
            // 
            // MaxLifeTimeTextBox
            // 
            this.MaxLifeTimeTextBox.Location = new System.Drawing.Point(200, 29);
            this.MaxLifeTimeTextBox.MaxLength = 10;
            this.MaxLifeTimeTextBox.Name = "MaxLifeTimeTextBox";
            this.MaxLifeTimeTextBox.Size = new System.Drawing.Size(130, 23);
            this.MaxLifeTimeTextBox.TabIndex = 1;
            this.MaxLifeTimeTextBox.Leave += new System.EventHandler(this.MaxLifeTimeTextBox_Leave);
            // 
            // MaxLifeTimeLabel
            // 
            this.MaxLifeTimeLabel.AutoSize = true;
            this.MaxLifeTimeLabel.Location = new System.Drawing.Point(6, 32);
            this.MaxLifeTimeLabel.Name = "MaxLifeTimeLabel";
            this.MaxLifeTimeLabel.Size = new System.Drawing.Size(168, 15);
            this.MaxLifeTimeLabel.TabIndex = 0;
            this.MaxLifeTimeLabel.Text = "Макс время жизни (в тактах):";
            // 
            // FoodGroupBox
            // 
            this.FoodGroupBox.Controls.Add(this.FoodGenerationSpeedTextBox);
            this.FoodGroupBox.Controls.Add(this.GenerationSpeedLabel);
            this.FoodGroupBox.Controls.Add(this.FoodEnergyTextBox);
            this.FoodGroupBox.Controls.Add(this.FoodEnergyLabel);
            this.FoodGroupBox.Location = new System.Drawing.Point(354, 12);
            this.FoodGroupBox.Name = "FoodGroupBox";
            this.FoodGroupBox.Size = new System.Drawing.Size(351, 232);
            this.FoodGroupBox.TabIndex = 1;
            this.FoodGroupBox.TabStop = false;
            this.FoodGroupBox.Text = "Еда";
            // 
            // FoodGenerationSpeedTextBox
            // 
            this.FoodGenerationSpeedTextBox.Location = new System.Drawing.Point(215, 58);
            this.FoodGenerationSpeedTextBox.MaxLength = 3;
            this.FoodGenerationSpeedTextBox.Name = "FoodGenerationSpeedTextBox";
            this.FoodGenerationSpeedTextBox.Size = new System.Drawing.Size(130, 23);
            this.FoodGenerationSpeedTextBox.TabIndex = 14;
            this.FoodGenerationSpeedTextBox.Leave += new System.EventHandler(this.FoodGenerationSpeedTextBox_Leave);
            // 
            // GenerationSpeedLabel
            // 
            this.GenerationSpeedLabel.AutoSize = true;
            this.GenerationSpeedLabel.Location = new System.Drawing.Point(6, 61);
            this.GenerationSpeedLabel.Name = "GenerationSpeedLabel";
            this.GenerationSpeedLabel.Size = new System.Drawing.Size(190, 15);
            this.GenerationSpeedLabel.TabIndex = 13;
            this.GenerationSpeedLabel.Text = "Скорость появления (штук/такт):";
            // 
            // FoodEnergyTextBox
            // 
            this.FoodEnergyTextBox.Location = new System.Drawing.Point(215, 29);
            this.FoodEnergyTextBox.MaxLength = 10;
            this.FoodEnergyTextBox.Name = "FoodEnergyTextBox";
            this.FoodEnergyTextBox.Size = new System.Drawing.Size(130, 23);
            this.FoodEnergyTextBox.TabIndex = 12;
            this.FoodEnergyTextBox.Leave += new System.EventHandler(this.FoodEnergyTextBox_Leave);
            // 
            // FoodEnergyLabel
            // 
            this.FoodEnergyLabel.AutoSize = true;
            this.FoodEnergyLabel.Location = new System.Drawing.Point(6, 32);
            this.FoodEnergyLabel.Name = "FoodEnergyLabel";
            this.FoodEnergyLabel.Size = new System.Drawing.Size(55, 15);
            this.FoodEnergyLabel.TabIndex = 0;
            this.FoodEnergyLabel.Text = "Энергия:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(200, 254);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(297, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Применить";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SettingsElementarySimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 289);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FoodGroupBox);
            this.Controls.Add(this.ElementaryEntityGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsElementarySimulation";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsElementarySimulation_FormClosing);
            this.Load += new System.EventHandler(this.SettingsElementarySimulation_Load);
            this.ElementaryEntityGroupBox.ResumeLayout(false);
            this.ElementaryEntityGroupBox.PerformLayout();
            this.FoodGroupBox.ResumeLayout(false);
            this.FoodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected GroupBox ElementaryEntityGroupBox;
        protected Label MaxLifeTimeLabel;
        protected TextBox StartEnergyTextBox;
        protected Label StartEnergyLabel;
        protected TextBox EnergyForMoveTextBox;
        protected Label EnergyForMoveLabel;
        protected TextBox EnergyForLifeTextBox;
        protected Label EnergyForLifeLabel;
        protected TextBox ReproductionChanceTextBox;
        protected Label ReproductionChanceLabel;
        protected TextBox EnergyForChildTextBox;
        protected Label EnergyForChildLabel;
        protected TextBox MaxLifeTimeTextBox;
        protected GroupBox FoodGroupBox;
        protected TextBox FoodGenerationSpeedTextBox;
        protected Label GenerationSpeedLabel;
        protected TextBox FoodEnergyTextBox;
        protected Label FoodEnergyLabel;
        protected Button OKButton;
    }
}