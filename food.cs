﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class food : entity
    {
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
