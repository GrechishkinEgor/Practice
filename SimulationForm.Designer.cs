namespace Practice
{
    partial class simulationForm
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
            this.managmentPanel = new System.Windows.Forms.Panel();
            this.fieldDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // managmentPanel
            // 
            this.managmentPanel.BackColor = System.Drawing.SystemColors.Info;
            this.managmentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.managmentPanel.Location = new System.Drawing.Point(563, 0);
            this.managmentPanel.Name = "managmentPanel";
            this.managmentPanel.Size = new System.Drawing.Size(237, 450);
            this.managmentPanel.TabIndex = 0;
            // 
            // fieldDataGrid
            // 
            this.fieldDataGrid.AllowUserToAddRows = false;
            this.fieldDataGrid.AllowUserToDeleteRows = false;
            this.fieldDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldDataGrid.Location = new System.Drawing.Point(0, 0);
            this.fieldDataGrid.Name = "fieldDataGrid";
            this.fieldDataGrid.ReadOnly = true;
            this.fieldDataGrid.RowTemplate.Height = 25;
            this.fieldDataGrid.Size = new System.Drawing.Size(563, 450);
            this.fieldDataGrid.TabIndex = 1;
            // 
            // simulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fieldDataGrid);
            this.Controls.Add(this.managmentPanel);
            this.Name = "simulationForm";
            this.Text = "Симуляция";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fieldDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel managmentPanel;
        private DataGridView fieldDataGrid;
    }
}