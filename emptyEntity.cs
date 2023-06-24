using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class emptyEntity : entity
    {
        public override void BeatAction()
        {
            //Ничего не делает
        }

        public emptyEntity()
        {
            Type = "emptyEntity";
        }
    }
}
