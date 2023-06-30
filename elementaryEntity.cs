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
        protected int maxLifeTime = 10;
        protected int energyForChild = 0;
        protected int reproductionChance = 0;
        protected int energyForLife = 0;
        protected int energyForMove = 0;
        public bool IsAlive { get; set; } = true;

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
        public virtual int EnergyForChild
        {
            get => energyForChild;
            set { if (value >= 0) energyForChild = value; }
        }

        //Переопредленное поведение существа
        public override void  BeatAction()
        {
            lifeTime++;
            energy = energy - energyForLife;
            if (energy <= 0)
            {
                energy = 0;
                IsAlive = false;
            }
            if (lifeTime > maxLifeTime)
            {
                IsAlive = false;
            }
            if (!IsAlive)
                return;

            int vectorX, vectorY;               //Координаты вектора
            Random randomizer = new Random();

            //Попытка размножения
            int energyForReproduction = 3 * (energyForLife + energyForMove) + energyForChild;
            if (energy > energyForReproduction &&
                randomizer.Next(1000) + 1 <= reproductionChance)
            {
                //Создание дочерней сущности
                elementaryEntity child = new elementaryEntity();
                SettingsElementarySimulation settings = ((fieldElementarySimulation)entityBase).SettingsWin;
                child.maxLifeTime = settings.MaxLifeTime;
                child.energyForChild = settings.EnergyForChild;
                child.reproductionChance = settings.ReproductionChance;
                child.energyForLife = settings.EnergyForLife;
                child.energyForMove = settings.EnergyForMove;
                child.energy = this.energyForChild;

                //Попытки разместить дочернюю сущность на симуляционном поле
                for (int i = 0; i < 16; i++)
                {
                    vectorX = randomizer.Next(-1, 2);
                    vectorY = randomizer.Next(-1, 2);
                    try
                    {
                        if (vectorX != 0 && vectorY != 0 &&
                            entityBase.EntityMatrix[this.x + vectorX, this.y + vectorY].Type == "emptyEntity")
                        {
                            //Успешная попытка. Завершить тактовое действие
                            entityBase.AddEntity(child, this.x + vectorX, this.y + vectorY);
                            this.energy -= this.energyForChild;
                            return;
                        }
                    }
                    catch (Exception) { }
                }

            }

            //Попытки употребления еды
            for (int i = 0; i < 16; i++)
            {
                vectorX = randomizer.Next(-1, 2);
                vectorY = randomizer.Next(-1, 2);
                try
                {
                    if (entityBase.EntityMatrix[this.x + vectorX, this.y + vectorY].Type == "food")
                    {
                        //Успешная попытка. Завершить тактовое действие
                        food someFood = (food)entityBase.EntityMatrix[this.x + vectorX, this.y + vectorY];
                        this.energy += someFood.Energy;
                        entityBase.ClearEntity(this.x + vectorX, this.y + vectorY);
                        return;
                    }
                }
                catch (Exception) { }
            }
            
            //Попытки найти подходящую для перемещения клетку
            for (int i = 0; i < 16 && this.energy - this.energyForMove > 0; i++)
            {
                vectorX = randomizer.Next(-1, 2);
                vectorY = randomizer.Next(-1, 2);
                try
                {
                    if (entityBase.EntityMatrix[x + vectorX, y + vectorY].Type == "emptyEntity")
                    {
                        //Успешное перемещение и завершение тактового действия
                        entityBase.MoveEntity(x, y, x + vectorX, y + vectorY);
                        this.energy -= this.energyForMove;
                        return;
                    }
                }
                catch (Exception) { }
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
            this.ReproductionChance = obj.ReproductionChance;
        }
    }
}
