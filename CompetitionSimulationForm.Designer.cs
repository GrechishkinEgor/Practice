namespace Practice
{
    partial class CompetitionSimulationForm
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
            this.SecondKindCountLabel = new System.Windows.Forms.Label();
            this.FirstKindCountLabel = new System.Windows.Forms.Label();
            this.ElemEntCountLabel = new System.Windows.Forms.Label();
            this.DeleteEntityButton = new System.Windows.Forms.Button();
            this.AddSecondKindButton = new System.Windows.Forms.Button();
            this.AddFirstKindButton = new System.Windows.Forms.Button();
            this.EntitySettingsButton = new System.Windows.Forms.Button();
            this.SimRunButton = new System.Windows.Forms.Button();
            this.FieldPanel = new System.Windows.Forms.Panel();
            this.Beat = new System.Windows.Forms.Timer(this.components);
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SettingsPanel.Controls.Add(this.SecondKindCountLabel);
            this.SettingsPanel.Controls.Add(this.FirstKindCountLabel);
            this.SettingsPanel.Controls.Add(this.ElemEntCountLabel);
            this.SettingsPanel.Controls.Add(this.DeleteEntityButton);
            this.SettingsPanel.Controls.Add(this.AddSecondKindButton);
            this.SettingsPanel.Controls.Add(this.AddFirstKindButton);
            this.SettingsPanel.Controls.Add(this.EntitySettingsButton);
            this.SettingsPanel.Controls.Add(this.SimRunButton);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(200, 359);
            this.SettingsPanel.TabIndex = 1;
            // 
            // SecondKindCountLabel
            // 
            this.SecondKindCountLabel.AutoSize = true;
            this.SecondKindCountLabel.Location = new System.Drawing.Point(12, 242);
            this.SecondKindCountLabel.Name = "SecondKindCountLabel";
            this.SecondKindCountLabel.Size = new System.Drawing.Size(72, 15);
            this.SecondKindCountLabel.TabIndex = 9;
            this.SecondKindCountLabel.Text = "Второй вид:";
            // 
            // FirstKindCountLabel
            // 
            this.FirstKindCountLabel.AutoSize = true;
            this.FirstKindCountLabel.Location = new System.Drawing.Point(12, 218);
            this.FirstKindCountLabel.Name = "FirstKindCountLabel";
            this.FirstKindCountLabel.Size = new System.Drawing.Size(76, 15);
            this.FirstKindCountLabel.TabIndex = 8;
            this.FirstKindCountLabel.Text = "Первый вид:";
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
            // AddSecondKindButton
            // 
            this.AddSecondKindButton.Location = new System.Drawing.Point(12, 99);
            this.AddSecondKindButton.Name = "AddSecondKindButton";
            this.AddSecondKindButton.Size = new System.Drawing.Size(173, 23);
            this.AddSecondKindButton.TabIndex = 5;
            this.AddSecondKindButton.Text = "Добавить второй вид";
            this.AddSecondKindButton.UseVisualStyleBackColor = true;
            this.AddSecondKindButton.Click += new System.EventHandler(this.AddSecondKindButton_Click);
            // 
            // AddFirstKindButton
            // 
            this.AddFirstKindButton.Location = new System.Drawing.Point(12, 70);
            this.AddFirstKindButton.Name = "AddFirstKindButton";
            this.AddFirstKindButton.Size = new System.Drawing.Size(173, 23);
            this.AddFirstKindButton.TabIndex = 4;
            this.AddFirstKindButton.Text = "Добавить первый вид";
            this.AddFirstKindButton.UseVisualStyleBackColor = true;
            this.AddFirstKindButton.Click += new System.EventHandler(this.AddFirstKindButton_Click);
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
            this.FieldPanel.Size = new System.Drawing.Size(498, 359);
            this.FieldPanel.TabIndex = 2;
            // 
            // Beat
            // 
            this.Beat.Interval = 500;
            this.Beat.Tick += new System.EventHandler(this.Beat_Tick);
            // 
            // CompetitionSimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(698, 359);
            this.Controls.Add(this.FieldPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "CompetitionSimulationForm";
            this.Text = "Симуляция конкуренции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompetitionSimulationForm_FormClosed);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SettingsPanel;
        private Label SecondKindCountLabel;
        private Label FirstKindCountLabel;
        private Label ElemEntCountLabel;
        private Button DeleteEntityButton;
        private Button AddSecondKindButton;
        private Button AddFirstKindButton;
        private Button EntitySettingsButton;
        private Button SimRunButton;
        private Panel FieldPanel;
        private System.Windows.Forms.Timer Beat;
    }
}