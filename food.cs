using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class food : entity
    {
        protected int energy = 100;
        public virtual int Energy
        {
            get => energy;
            set { if (value >= 0) energy = value; }   
        }

        public override void BeatAction()
        {
            //Еда ничего не делает
        }

        public food()
        {
            Type = "food";
        }
    }
}
