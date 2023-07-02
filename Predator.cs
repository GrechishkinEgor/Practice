using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Predator : elementaryEntity
    {

        public Predator()
        {
            Type = "Predator";
        }
        public override void BeatAction()
        {
            SettingsPredatorSimulation settings = ((fieldPredator)entityBase).SettingsWin;
            lifeTime++;
            energy = energy - settings.EnergyForLifePredator;
            if (energy <= 0)
            {
                energy = 0;
                IsAlive = false;
            }
            if (lifeTime > settings.MaxLifeTimePredator)
            {
                IsAlive = false;
            }
            if (!IsAlive)
                return;

            int vectorX, vectorY;               //Координаты вектора
            Random randomizer = new Random();

            //Попытка размножения
            int energyForReproduction = 3 * (settings.EnergyForLifePredator + settings.EnergyForMovePredator) + settings.EnergyForChildPredator;
            if (energy > energyForReproduction &&
                randomizer.Next(1000) + 1 <= settings.ReproductionChancePredator)
            {
                //Создание дочерней сущности
                Predator child = new Predator();
                child.energy = settings.EnergyForChildPredator;

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
                            this.energy -= settings.EnergyForChildPredator;
                            return;
                        }
                    }
                    catch (Exception) { }
                }

            }

            //Попытки съесть другое существо
            for (int i = 0; i < 16; i++)
            {
                vectorX = randomizer.Next(-1, 2);
                vectorY = randomizer.Next(-1, 2);
                try
                {
                    if (entityBase.EntityMatrix[this.x + vectorX, this.y + vectorY].Type == "Herbivore")
                    {
                        //Успешная попытка. Завершить тактовое действие
                        elementaryEntity eaten = (elementaryEntity)entityBase.EntityMatrix[this.x + vectorX, this.y + vectorY];
                        this.energy += eaten.Energy;
                        eaten.IsAlive = false;
                        entityBase.ClearEntity(this.x + vectorX, this.y + vectorY);
                        return;
                    }
                }
                catch (Exception) { }
            }

            //Попытки найти подходящую для перемещения клетку
            for (int i = 0; i < 16 && this.energy - settings.EnergyForMovePredator > 0; i++)
            {
                vectorX = randomizer.Next(-1, 2);
                vectorY = randomizer.Next(-1, 2);
                try
                {
                    if (entityBase.EntityMatrix[x + vectorX, y + vectorY].Type == "emptyEntity")
                    {
                        //Успешное перемещение и завершение тактового действия
                        entityBase.MoveEntity(x, y, x + vectorX, y + vectorY);
                        this.energy -= settings.EnergyForMovePredator;
                        return;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
