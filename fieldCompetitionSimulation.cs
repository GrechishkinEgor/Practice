﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class fieldCompetitionSimulation : fieldElementarySimulation
    {
        new public SettingsCompetitionSimulation SettingsWin { get; } = new SettingsCompetitionSimulation();
        public bool IsSecondKindAdded { get; set;} = false;
        protected int firstKindCount = 0;
        public int FirstKindCount { get => firstKindCount; }
        protected int secondKindCount = 0;
        public int SecondKindCount { get => secondKindCount; }
        public fieldCompetitionSimulation(int width, int height) : base(width, height)
        {

        }

        public override void ClearEntity(int x, int y)
        {
            if (EntityMatrix[x,y].Type == "Competitor")
            {
                if (((Competitor)EntityMatrix[x, y]).IsSecondKind)
                    secondKindCount--;
                else
                    firstKindCount--;
                ((Competitor)EntityMatrix[x, y]).IsAlive = false;
            }
            EntityMatrix[x, y] = new emptyEntity();
            EntityMatrix[x, y].EntityBase = this;
            EntityMatrix[x, y].X = x;
            EntityMatrix[x, y].Y = y;
            HarmonizeEntityAndPicture(x, y);
        }

        public override void DoBeat()
        {
            //Генерация еды
            Random randomizer = new Random();
            int x, y;
            for (int i = 0; i < SettingsWin.FoodGenerationSpeed; i++)
            {
                //Попытка сгенерировать очередную еду
                for (int j = 0; j < 16; j++)
                {
                    x = randomizer.Next(Width);
                    y = randomizer.Next(Height);
                    if (EntityMatrix[x, y].Type == "emptyEntity")
                    {
                        food newFood = new food();
                        this.AddEntity(newFood, x, y);
                        break;
                    }
                }
            }

            //Обработка тактовых действий сущностей
            int queueLength = beatQueue.Count;
            for (int i = 0; i < queueLength; i++)
            {
                elementaryEntity someEntity = beatQueue.Dequeue();
                if (someEntity.IsAlive)
                {
                    someEntity.BeatAction();
                    if (someEntity.IsAlive)
                        beatQueue.Enqueue(someEntity);
                    else
                        this.ClearEntity(someEntity.X, someEntity.Y);
                }
            }

            if (enabledDrawing)
                fieldBitmapPictureBox.Invalidate();
        }
        public override void AddEntity(entity newEntity, int x, int y)
        {
            if (EntityMatrix[x, y].Type == "Competitor")
                ((Competitor)EntityMatrix[x, y]).IsAlive = false;
            EntityMatrix[x, y] = newEntity;
            newEntity.EntityBase = this;
            newEntity.X = x;
            newEntity.Y = y;
            HarmonizeEntityAndPicture(x, y);
            if (newEntity.Type == "Competitor")
            {
                beatQueue.Enqueue((elementaryEntity)newEntity);
                if (((Competitor)newEntity).IsSecondKind)
                    secondKindCount++;
                else
                    firstKindCount++;
            }
        }
        protected override void HarmonizeEntityAndPicture(int x, int y)
        {
            switch (EntityMatrix[x, y].Type)
            {
                case "Competitor":
                    if (((Competitor)EntityMatrix[x, y]).IsSecondKind)
                        for (int i = x * 10; i < x * 10 + 10; i++)
                            for (int j = y * 10; j < y * 10 + 10; j++)
                                fieldBitmap.SetPixel(i, j, Color.DeepPink);
                    else
                        for (int i = x * 10; i < x * 10 + 10; i++)
                            for (int j = y * 10; j < y * 10 + 10; j++)
                                fieldBitmap.SetPixel(i, j, Color.Orange);
                    break;
                case "food":
                    for (int i = x * 10; i < x * 10 + 10; i++)
                        for (int j = y * 10; j < y * 10 + 10; j++)
                            fieldBitmap.SetPixel(i, j, Color.Green);
                    break;
                case "emptyEntity":
                default:
                    for (int i = x * 10; i < x * 10 + 10; i++)
                        for (int j = y * 10; j < y * 10 + 10; j++)
                            fieldBitmap.SetPixel(i, j, Color.White);
                    break;

            }
        }

        protected override void EntityClick(object sender, MouseEventArgs e)
        {
            try
            {
                PictureBox currentBox = (PictureBox)sender;
                entity currentEntity = EntityMatrix[e.X / 10, e.Y / 10];
                if (isAdditionalMood && currentEntity.Type == "emptyEntity")
                {
                    elementaryEntity ent = new Competitor();
                    if (IsSecondKindAdded)
                    {
                        ent.Energy = SettingsWin.StartEnergySecondKind;
                        ((Competitor)ent).IsSecondKind = true;
                    }
                    else
                    {
                        ent.Energy = SettingsWin.StartEnergy;
                        ((Competitor)ent).IsSecondKind = false;
                    }
                    this.AddEntity(ent, e.X / 10, e.Y / 10);
                    fieldBitmapPictureBox.Invalidate();
                }
                if (isDeletingMood)
                {
                    emptyEntity ent = new emptyEntity();
                    this.AddEntity(ent, e.X / 10, e.Y / 10);
                    fieldBitmapPictureBox.Invalidate();
                }
            }
            catch { }

        }
    }
}
