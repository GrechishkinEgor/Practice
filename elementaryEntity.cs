using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class elementaryEntity : entity
    {
        //Характеристики сущности
        protected int energy = 100;
        protected int lifeTime = 0;
        protected int maxLifeTime = 0;
        protected int energyForChild = 0;
        protected int reproductionChance = 0;
        protected int visionDistance = 0;
        protected int energyForLife = 0;
        protected int energyForMove = 0;

        //Свойства класса. Наследники могут задавать свои set'ы
        public virtual int Energy
        {
            get => energy;
            set { if (value >= 0) energy = value; }
        }
        public virtual int LifeTime
        {
            get => lifeTime;
            set { if (value >= 0) lifeTime = value; }
        }
        public virtual int MaxLifeTime
        {
            get => maxLifeTime;
            set { if (value >= 0) maxLifeTime = value; }
        }
        public virtual int ReproductionChance
        {
            get => reproductionChance;
            set { if (value >= 0 && value <= 1000) reproductionChance = value; }
        }
        public virtual int VisionDistance
        {
            get => visionDistance;
            set { if (value >= 0) visionDistance = value; }
        }
        public virtual int EnergyForLife
        {
            get => energyForLife;
            set { if (value >= 0) energyForLife = value; }
        }
        public virtual int EnergyForMove
        {
            get => energyForMove;
            set { if (value >= 0) energyForMove = value; }
        }

        //Переопредленное поведение существа
        public override void  BeatAction()
        {
            energy = energy - energyForLife;
            if (energy <= 0)
            {
                energy = 0;
                entityBase.ClearEntity(x, y);
                return;
            }

            //Переменные для обзора поля вокруг сущности
            int leftAngleX = (x - 1 >= 0) ? (x - 1) : x;
            int leftAngleY = (y - 1 >= 0) ? (y - 1) : y;
            int rightAngleX = (x + 1 < entityBase.Width) ? (x + 1) : x;
            int rightAngleY = (y + 1 < entityBase.Height) ? (y + 1) : y;
            //Рандомайзер
            Random chance = new Random();

            //Попытка размножения
            int energyForReproduction = 3 * (energyForLife + energyForMove) + energyForChild;
            if (energyForReproduction > energy)
            {
                
                if (chance.Next(1000) + 1 <= reproductionChance)
                {
                    //Создание дочерней сущности
                    elementaryEntity child = new elementaryEntity(this);
                    child.lifeTime = 0;
                    child.energy = this.energyForChild;
                    this.energy -= this.energyForChild;

                    //Попытка разместить дочернюю сущность на поле
                    for (int i = leftAngleX; i <= rightAngleX; i++)
                        for (int j = leftAngleY; j <= rightAngleY; j++)
                            if (entityBase.EntityMatrix[i,j].Type == "emptyEntity")
                            {
                                //Если успешно, то тактовое действие заканчивается
                                entityBase.AddEntity(child);
                                return;
                            }
                }
            }

            //Употребление еды
            for (int i = leftAngleX; i <= rightAngleX; i++)
                for (int j = leftAngleY; j <= rightAngleY; j++)
                    if (entityBase.EntityMatrix[i, j].Type == "food")
                    {
                        //Если успешно, то тактовое действие заканчивается
                        food dish = (food)entityBase.EntityMatrix[i, j];
                        this.energy += dish.Energy;
                        entityBase.ClearEntity(i, j);
                        return;
                    }

            //Поиск еды и движение
            int vectorX, vectorY;   //Координаты вектора перемещения
            //Делается 10 попыток найти подходящую для перемещения клетку
            for (int i = 0; i < 10; i++)
            {
                vectorX = chance.Next(-1, 1);
                vectorY = chance.Next(-1, 1);
                if (vectorX != 0 && vectorY != 0)
                    if (entityBase.EntityMatrix[x + vectorX, y + vectorY].Type == "emptyEntity")
                    {
                        //Успешное перемещение и завершение тактового действия
                        entityBase.MoveEntity(x, y, x + vectorX, y + vectorY);
                        x += vectorX;
                        y += vectorY;
                        return;
                    }
            }
        }

        public elementaryEntity()
        {
            Type = "elementaryEntity";
        }

        //Создает полную копию сущности
        public elementaryEntity(elementaryEntity obj)
        {
            Type = "elementaryEntity";
            this.x = obj.x;
            this.y = obj.y;
            this.entityBase = obj.entityBase;
            this.energy = obj.energy;
            this.lifeTime = obj.lifeTime;
            this.maxLifeTime = obj.maxLifeTime;
            this.energyForChild = obj.energyForChild;
            this.energyForMove = obj.energyForMove;
            this.energyForLife = obj.energyForLife;
            this.visionDistance = obj.visionDistance;
            this.ReproductionChance = obj.ReproductionChance;
        }
    }
}
