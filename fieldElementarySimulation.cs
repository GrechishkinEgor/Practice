﻿using System;
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
        private bool enabledDrawing = true;
        //Очередь на обработку тактового действия
        protected Queue<entity> beatQueue = new Queue<entity>();
        public bool EnabledDrawing 
        {
            get => enabledDrawing;
            set
            {
                if (value == false)
                    foreach(PictureBox image in PictureMatrix)
                    {
                        image.Enabled = false;
                        image.Visible = false;
                    }
                else
                    foreach (PictureBox image in PictureMatrix)
                    {
                        image.Enabled = true;
                        image.Visible = true;
                    }
                enabledDrawing = value;
            }
        }

        //Согласовать изображение c сущностью по координатам (х, у)
        private void HarmonizeEntityAndPicture(int x, int y)
        {
            switch(EntityMatrix[x,y].Type)
            {
                case "elementaryEntity":
                    PictureMatrix[x, y].BackColor = Color.Green;
                    break;
                case "food":
                    PictureMatrix[x, y].BackColor = Color.Orange;
                    break;
                case "emptyEntity":
                default:
                    PictureMatrix[x, y].BackColor = Color.White;
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
                    somePicture.Location = new System.Drawing.Point(200 + i * 10, j * 10);
                    somePicture.BackColor = Color.White;
                    somePicture.Name = "PictureBox[" + Convert.ToString(i) + "][" + Convert.ToString(j) + "]";
                    somePicture.Size = new System.Drawing.Size(10, 10);
                    somePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    somePicture.TabIndex = 0;
                    somePicture.TabStop = false;

                    PictureMatrix[i, j] = somePicture;
                }
        }

        public override void AddEntity(entity newEntity, int x, int y)
        {
            base.AddEntity(newEntity, x, y);
            HarmonizeEntityAndPicture(x, y); 
        }
        public override void ClearEntity(int x, int y)
        {
            base.ClearEntity(x, y);
            HarmonizeEntityAndPicture(x, y);
        }
        public override void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            base.MoveEntity(oldX, oldY, newX, newY);
            HarmonizeEntityAndPicture(oldX, oldY);
            HarmonizeEntityAndPicture(newX, newY);
        }
    }
}
