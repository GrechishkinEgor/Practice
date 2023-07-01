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
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.FieldPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(200, 370);
            this.SettingsPanel.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SettingsPanel;
        private Panel FieldPanel;
    }
}