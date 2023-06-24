using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class field
    {
        protected entity[,] entityMatrix = { };
        public entity[,] EntityMatrix
        {
            get => entityMatrix;
        }

        public virtual void DoBeat()
        {
            foreach (entity someEntity in entityMatrix)
                someEntity.BeatAction();
        }
        public virtual void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            entityMatrix[newX, newY] = entityMatrix[oldX, oldY];
            entityMatrix[oldX, oldY] = new emptyEntity();
        }
        public virtual void ClearCell(int x, int y)
        {
            entityMatrix[x, y] = new emptyEntity();
        }
        public virtual void AddEntity(entity newEntity)
        {
            entityMatrix[newEntity.X, newEntity.Y] = newEntity;
        }

    }
}
