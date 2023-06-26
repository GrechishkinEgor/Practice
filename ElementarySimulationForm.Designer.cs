namespace Practice
{
    partial class ElementarySimulationForm
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
            this.SomeActionButton = new System.Windows.Forms.Button();
            this.Beat = new System.Windows.Forms.Timer(this.components);
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SettingsPanel.Controls.Add(this.SomeActionButton);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(200, 362);
            this.SettingsPanel.TabIndex = 0;
            // 
            // SomeActionButton
            // 
            this.SomeActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SomeActionButton.Location = new System.Drawing.Point(12, 327);
            this.SomeActionButton.Name = "SomeActionButton";
            this.SomeActionButton.Size = new System.Drawing.Size(173, 23);
            this.SomeActionButton.TabIndex = 0;
            this.SomeActionButton.Text = "Сделать что-нибудь";
            this.SomeActionButton.UseVisualStyleBackColor = true;
            this.SomeActionButton.Click += new System.EventHandler(this.SomeActionButton_Click);
            // 
            // Beat
            // 
            this.Beat.Interval = 500;
            this.Beat.Tick += new System.EventHandler(this.Beat_Tick);
            // 
            // ElementarySimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 362);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "ElementarySimulationForm";
            this.Text = "БИО Симулякрум. Элементарная симуляция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ElementarySimulationForm_FormClosed);
            this.SettingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SettingsPanel;
        private Button SomeActionButton;
        private System.Windows.Forms.Timer Beat;
    }
}