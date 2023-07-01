namespace Practice
{
    partial class PredatorSimulationForm
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
            this.components = new System.ComponentModel.Container();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ElemEntCountLabel = new System.Windows.Forms.Label();
            this.DrawingButton = new System.Windows.Forms.Button();
            this.DeleteEntityButton = new System.Windows.Forms.Button();
            this.AddPredatorButton = new System.Windows.Forms.Button();
            this.AddHerbivoreButton = new System.Windows.Forms.Button();
            this.EntitySettingsButton = new System.Windows.Forms.Button();
            this.SimRunButton = new System.Windows.Forms.Button();
            this.FieldPanel = new System.Windows.Forms.Panel();
            this.Beat = new System.Windows.Forms.Timer(this.components);
            this.PredatorsCountLabel = new System.Windows.Forms.Label();
            this.HerbivoreCountLabel = new System.Windows.Forms.Label();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SettingsPanel.Controls.Add(this.HerbivoreCountLabel);
            this.SettingsPanel.Controls.Add(this.PredatorsCountLabel);
            this.SettingsPanel.Controls.Add(this.ElemEntCountLabel);
            this.SettingsPanel.Controls.Add(this.DrawingButton);
            this.SettingsPanel.Controls.Add(this.DeleteEntityButton);
            this.SettingsPanel.Controls.Add(this.AddPredatorButton);
            this.SettingsPanel.Controls.Add(this.AddHerbivoreButton);
            this.SettingsPanel.Controls.Add(this.EntitySettingsButton);
            this.SettingsPanel.Controls.Add(this.SimRunButton);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(200, 370);
            this.SettingsPanel.TabIndex = 0;
            // 
            // ElemEntCountLabel
            // 
            this.ElemEntCountLabel.AutoSize = true;
            this.ElemEntCountLabel.Location = new System.Drawing.Point(12, 193);
            this.ElemEntCountLabel.Name = "ElemEntCountLabel";
            this.ElemEntCountLabel.Size = new System.Drawing.Size(105, 15);
            this.ElemEntCountLabel.TabIndex = 4;
            this.ElemEntCountLabel.Text = "Всего сущностей:";
            // 
            // DrawingButton
            // 
            this.DrawingButton.Location = new System.Drawing.Point(12, 157);
            this.DrawingButton.Name = "DrawingButton";
            this.DrawingButton.Size = new System.Drawing.Size(173, 23);
            this.DrawingButton.TabIndex = 7;
            this.DrawingButton.Text = "Выключить отрисовку";
            this.DrawingButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEntityButton
            // 
            this.DeleteEntityButton.Location = new System.Drawing.Point(12, 128);
            this.DeleteEntityButton.Name = "DeleteEntityButton";
            this.DeleteEntityButton.Size = new System.Drawing.Size(173, 23);
            this.DeleteEntityButton.TabIndex = 6;
            this.DeleteEntityButton.Text = "Удалить сущность";
            this.DeleteEntityButton.UseVisualStyleBackColor = true;
            this.DeleteEntityButton.Click += new System.EventHandler(this.DeleteEntityButton_Click);
            // 
            // AddPredatorButton
            // 
            this.AddPredatorButton.Location = new System.Drawing.Point(12, 99);
            this.AddPredatorButton.Name = "AddPredatorButton";
            this.AddPredatorButton.Size = new System.Drawing.Size(173, 23);
            this.AddPredatorButton.TabIndex = 5;
            this.AddPredatorButton.Text = "Добавить хищника";
            this.AddPredatorButton.UseVisualStyleBackColor = true;
            this.AddPredatorButton.Click += new System.EventHandler(this.AddPredatorButton_Click);
            // 
            // AddHerbivoreButton
            // 
            this.AddHerbivoreButton.Location = new System.Drawing.Point(12, 70);
            this.AddHerbivoreButton.Name = "AddHerbivoreButton";
            this.AddHerbivoreButton.Size = new System.Drawing.Size(173, 23);
            this.AddHerbivoreButton.TabIndex = 4;
            this.AddHerbivoreButton.Text = "Добавить травоядное";
            this.AddHerbivoreButton.UseVisualStyleBackColor = true;
            this.AddHerbivoreButton.Click += new System.EventHandler(this.AddHerbivoreButton_Click);
            // 
            // EntitySettingsButton
            // 
            this.EntitySettingsButton.Location = new System.Drawing.Point(12, 41);
            this.EntitySettingsButton.Name = "EntitySettingsButton";
            this.EntitySettingsButton.Size = new System.Drawing.Size(173, 23);
            this.EntitySettingsButton.TabIndex = 3;
            this.EntitySettingsButton.Text = "Параметры сущностей";
            this.EntitySettingsButton.UseVisualStyleBackColor = true;
            this.EntitySettingsButton.Click += new System.EventHandler(this.EntitySettingsButton_Click);
            // 
            // SimRunButton
            // 
            this.SimRunButton.Location = new System.Drawing.Point(12, 12);
            this.SimRunButton.Name = "SimRunButton";
            this.SimRunButton.Size = new System.Drawing.Size(173, 23);
            this.SimRunButton.TabIndex = 2;
            this.SimRunButton.Text = "Запустить симуляцию";
            this.SimRunButton.UseVisualStyleBackColor = true;
            this.SimRunButton.Click += new System.EventHandler(this.SimRunButton_Click);
            // 
            // FieldPanel
            // 
            this.FieldPanel.BackColor = System.Drawing.SystemColors.Info;
            this.FieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldPanel.Location = new System.Drawing.Point(200, 0);
            this.FieldPanel.Name = "FieldPanel";
            this.FieldPanel.Size = new System.Drawing.Size(398, 370);
            this.FieldPanel.TabIndex = 1;
            // 
            // Beat
            // 
            this.Beat.Interval = 500;
            this.Beat.Tick += new System.EventHandler(this.Beat_Tick);
            // 
            // PredatorsCountLabel
            // 
            this.PredatorsCountLabel.AutoSize = true;
            this.PredatorsCountLabel.Location = new System.Drawing.Point(12, 218);
            this.PredatorsCountLabel.Name = "PredatorsCountLabel";
            this.PredatorsCountLabel.Size = new System.Drawing.Size(62, 15);
            this.PredatorsCountLabel.TabIndex = 8;
            this.PredatorsCountLabel.Text = "Хищники:";
            // 
            // HerbivoreCountLabel
            // 
            this.HerbivoreCountLabel.AutoSize = true;
            this.HerbivoreCountLabel.Location = new System.Drawing.Point(12, 242);
            this.HerbivoreCountLabel.Name = "HerbivoreCountLabel";
            this.HerbivoreCountLabel.Size = new System.Drawing.Size(76, 15);
            this.HerbivoreCountLabel.TabIndex = 9;
            this.HerbivoreCountLabel.Text = "Травоядные:";
            // 
            // PredatorSimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 370);
            this.Controls.Add(this.FieldPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "PredatorSimulationForm";
            this.Text = "Симуляция хищников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PredatorSimulationForm_FormClosed);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SettingsPanel;
        private Panel FieldPanel;
        private System.Windows.Forms.Timer Beat;
        private Button SimRunButton;
        private Button EntitySettingsButton;
        private Button AddHerbivoreButton;
        private Button AddPredatorButton;
        private Button DeleteEntityButton;
        private Button DrawingButton;
        private Label ElemEntCountLabel;
        private Label HerbivoreCountLabel;
        private Label PredatorsCountLabel;
    }
}