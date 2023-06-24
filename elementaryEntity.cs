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

        //Переопредленное поведение существа
        public override void  BeatAction()
        {
            energy = energy - energyForLife;
        }

        public elementaryEntity()
        {
            Type = "elementaryEntity";
        }
    }
}
