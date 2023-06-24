using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal abstract class field
    {
        public entity[,] EntityMatrix { get; } = { };

        public field(int width, int height)
        {
            EntityMatrix = new entity[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    EntityMatrix[i, j] = new emptyEntity();
        }

        public virtual void DoBeat()
        {
            foreach (entity someEntity in EntityMatrix)
                someEntity.BeatAction();
        }
        public virtual void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            EntityMatrix[newX, newY] = EntityMatrix[oldX, oldY];
            EntityMatrix[oldX, oldY] = new emptyEntity();
        }
        public virtual void ClearEntity(int x, int y)
        {
            EntityMatrix[x, y] = new emptyEntity();
        }
        public virtual void AddEntity(entity newEntity)
        {
            EntityMatrix[newEntity.X, newEntity.Y] = newEntity;
        }

    }
}
