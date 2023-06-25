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
    public partial class simulationForm : Form
    {
        public simulationForm()
        {
            InitializeComponent();

            this.SuspendLayout();

            PictureBox pictureBox2 = new PictureBox();

            pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            pictureBox2.Image = global::Practice.Properties.Resources.ElementaryEntity;
            pictureBox2.Location = new System.Drawing.Point(111, 111);
            pictureBox1.Name = "pictureBox2";
            pictureBox1.Size = new System.Drawing.Size(48, 48);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            this.Controls.Add(pictureBox2);
            this.ResumeLayout(false);

            this.SuspendLayout();
            Button buttonOK = new Button();
            buttonOK.Location = new Point(10, 10);
            buttonOK.Size = new Size(75, 25);
            buttonOK.Text = "OK";

            Button buttonCancel = new Button();
            buttonCancel.Location = new Point(90, 10);
            buttonCancel.Size = new Size(75, 25);
            buttonCancel.Text = "Cancel";

            this.Controls.AddRange(new Control[] { buttonOK, buttonCancel });
            this.ResumeLayout();
        }
    }
}
