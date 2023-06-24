using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class fieldDataGrid : field
    {
        public fieldDataGrid(int width, int height) : base(width, height)
        {

        }

        public override void AddEntity(entity newEntity)
        {
            base.AddEntity(newEntity);
        }
        public override void ClearEntity(int x, int y)
        {
            base.ClearEntity(x, y);
        }
        public override void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            base.MoveEntity(oldX, oldY, newX, newY);
        }
    }
}
