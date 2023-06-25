using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class fieldElementarySimulation : field
    {
        //Матрица изображений сущностей
        public PictureBox[,] PictureMatrix { get; }
        //Определяет, работает ли отрисовка сущностей на экране
        public bool EnabledDrawing 
        {
            get => EnabledDrawing;
            set
            {
                if (value == false)
                    foreach(PictureBox image in PictureMatrix)
                    {
                        image.Enabled = false;
                        image.Visible = false;
                    }
                else
                    for (int i = 0; i < Width; i++)
                        for (int j = 0; j < Height; j++)
                        {
                            HarmonizeEntityAndPicture(i, j);
                            PictureMatrix[i, j].Enabled = true;
                            PictureMatrix[i, j].Visible = true;
                        }
            }
        }

        //Согласовать изображение c сущностью по координатам (х, у)
        private void HarmonizeEntityAndPicture(int x, int y)
        {
            switch(EntityMatrix[x,y].Type)
            {
                case "elementaryEntity":
                    PictureMatrix[x, y].Image = global::Practice.Properties.Resources.ElementaryEntity;
                    break;
                case "food":
                    PictureMatrix[x, y].Image = global::Practice.Properties.Resources.EmptyEntity;
                    break;
                case "emptyEntity":
                default:
                    PictureMatrix[x, y].Image = global::Practice.Properties.Resources.EmptyEntity;
                    break;
            }
        }
        
        public fieldElementarySimulation(int width, int height) : base(width, height)
        {
            PictureMatrix = new PictureBox[width, height];

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    PictureBox somePicture = new PictureBox();
                    somePicture.BackColor = System.Drawing.SystemColors.Control;
                    somePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    somePicture.Image = global::Practice.Properties.Resources.EmptyEntity;
                    somePicture.Location = new System.Drawing.Point(200 + i * 35, j * 35);
                    somePicture.Name = "PictureBox[" + Convert.ToString(i) + "][" + Convert.ToString(j) + "]";
                    somePicture.Size = new System.Drawing.Size(34, 34);
                    somePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    somePicture.TabIndex = 0;
                    somePicture.TabStop = false;

                    PictureMatrix[i, j] = somePicture;
                }
        }

        public override void AddEntity(entity newEntity)
        {
            base.AddEntity(newEntity);
            if (EnabledDrawing)
                HarmonizeEntityAndPicture(newEntity.X, newEntity.Y);
        }
        public override void ClearEntity(int x, int y)
        {
            base.ClearEntity(x, y);
            if (EnabledDrawing)
                HarmonizeEntityAndPicture(x, y);
        }
        public override void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            base.MoveEntity(oldX, oldY, newX, newY);
            if (EnabledDrawing)
            {
                HarmonizeEntityAndPicture(oldX, oldY);
                HarmonizeEntityAndPicture(newX, newY);
            }
                
        }
    }
}
