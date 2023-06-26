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
        public int Width { get; } = 0;
        public int Height { get; } = 0;

        public field(int width, int height)
        {
            EntityMatrix = new entity[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    EntityMatrix[i, j] = new emptyEntity();
                    EntityMatrix[i, j].EntityBase = this;
                }
                    
            this.Width = width;
            this.Height = height;
        }

        public virtual void DoBeat()
        {
            foreach (entity someEntity in EntityMatrix)
                someEntity.BeatAction();
        }
        public virtual void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            EntityMatrix[newX, newY] = EntityMatrix[oldX, oldY];
            EntityMatrix[newX, newY].X = newX;
            EntityMatrix[newX, newY].Y = newY;
            EntityMatrix[oldX, oldY] = new emptyEntity();
            EntityMatrix[oldX, oldY].EntityBase = this;
            EntityMatrix[oldX, oldY].X = oldX;
            EntityMatrix[oldX, oldY].Y = oldY;
        }
        public virtual void ClearEntity(int x, int y)
        {
            EntityMatrix[x, y] = new emptyEntity();
            EntityMatrix[x, y].EntityBase = this;
            EntityMatrix[x, y].X = x;
            EntityMatrix[x, y].Y = y;
        }
        public virtual void AddEntity(entity newEntity, int x, int y)
        {
            EntityMatrix[x, y] = newEntity;
            newEntity.EntityBase = this;
            newEntity.X = x;
            newEntity.Y = y;
        }

    }
}
