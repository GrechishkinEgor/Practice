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

        //Переопредленное поведение существа
        public override void  BeatAction()
        {
            SettingsElementarySimulation settings = ((fieldElementarySimulation)entityBase).SettingsWin;
            lifeTime++;
            energy = energy - settings.EnergyForLife;
            if (energy <= 0)
            {
                energy = 0;
                IsAlive = false;
            }
            if (lifeTime > settings.MaxLifeTime)
            {
                IsAlive = false;
            }
            if (!IsAlive)
                return;

            int vectorX, vectorY;               //Координаты вектора
            Random randomizer = new Random();

            //Попытка размножения
            int energyForReproduction = 3 * (settings.EnergyForLife + settings.EnergyForMove) + settings.EnergyForChild;
            if (energy > energyForReproduction &&
                randomizer.Next(1000) + 1 <= settings.ReproductionChance)
            {
                //Создание дочерней сущности
                elementaryEntity child = new elementaryEntity();
                child.energy = settings.EnergyForChild;

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
                            this.energy -= settings.EnergyForChild;
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
                        this.energy += settings.FoodEnergy;
                        entityBase.ClearEntity(this.x + vectorX, this.y + vectorY);
                        return;
                    }
                }
                catch (Exception) { }
            }
            
            //Попытки найти подходящую для перемещения клетку
            for (int i = 0; i < 16 && this.energy - settings.EnergyForMove > 0; i++)
            {
                vectorX = randomizer.Next(-1, 2);
                vectorY = randomizer.Next(-1, 2);
                try
                {
                    if (entityBase.EntityMatrix[x + vectorX, y + vectorY].Type == "emptyEntity")
                    {
                        //Успешное перемещение и завершение тактового действия
                        entityBase.MoveEntity(x, y, x + vectorX, y + vectorY);
                        this.energy -= settings.EnergyForMove;
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
        }
    }
}
