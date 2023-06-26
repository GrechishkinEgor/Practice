using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal abstract class entity
    {
        //Координаты сущности
        protected int x = 0;
        protected int y = 0;

        //Свойства класса для изменения координат. Возможно переопределение свойств
        public virtual int X 
        {
            get => x; 
            set  { if (value >= 0)  x = value; }
        }
        public virtual int Y
        {
            get => y;
            set { if (value >= 0) y = value; }
        }

        //Симуляционное поле, которому принадлежит сущность
        protected field entityBase;
        public virtual field EntityBase { get => entityBase; set { entityBase = value; } }

        //Тип сущности. При наследовании необходимо изменить значение
        public string Type { get; protected set; } = "entity";

        //Тактовое действие сущности. Конкретное поведение реализуют наследники
        public abstract void BeatAction();

        public entity()
        {

        }
    }
}
