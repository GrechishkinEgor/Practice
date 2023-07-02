namespace Practice
{
    partial class HelloForm
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
            this.ChosenSimulationBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChosenSimulationBox
            // 
            this.ChosenSimulationBox.FormattingEnabled = true;
            this.ChosenSimulationBox.Items.AddRange(new object[] {
            "Симуляция хищников",
            "Симуляция конкуренции"});
            this.ChosenSimulationBox.Location = new System.Drawing.Point(12, 141);
            this.ChosenSimulationBox.Name = "ChosenSimulationBox";
            this.ChosenSimulationBox.Size = new System.Drawing.Size(251, 23);
            this.ChosenSimulationBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(87, 190);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(102, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(71, 123);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(129, 15);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Выберите симуляцию";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(13, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(250, 37);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "БИО Симулякрум";
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 237);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ChosenSimulationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelloForm";
            this.Text = "БИО Симулякрум";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelloForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ChosenSimulationBox;
        private Button OKButton;
        private Label InfoLabel;
        private Label NameLabel;
    }
}