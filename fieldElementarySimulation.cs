using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class fieldElementarySimulation : field
    {
        //Определяет, работает ли отрисовка сущностей на экране
        protected bool enabledDrawing = true;
        //Очередь на обработку тактового действия
        protected Queue<elementaryEntity> beatQueue = new Queue<elementaryEntity>();
        //Количество элементарных сущностей на поле
        public int ElemEntCount { get => beatQueue.Count; }
        //Включен ли режим добавления новых сущностей
        protected bool isAdditionalMood = false;
        //Включен ли режим удаления сущностей
        protected bool isDeletingMood = false;
        //Окно параметров сущностей
        public SettingsElementarySimulation SettingsWin { get; } = new SettingsElementarySimulation();

        //Изображение симуляционного поля
        protected Bitmap fieldBitmap;
        protected PictureBox fieldBitmapPictureBox;
        public PictureBox GetPicture { get => fieldBitmapPictureBox; }

        public bool IsDeletingMood
        {
            get => isDeletingMood;
            set => isDeletingMood = value;
        }
        public bool IsAdditionalMood
        {
            get => isAdditionalMood;
            set => isAdditionalMood = value;
        }

        //Работает или нет отрисовка сущностей
        public bool EnabledDrawing 
        {
            get => enabledDrawing;
            set
            {
                if (value == false)
                    fieldBitmapPictureBox.Visible = false;
                else
                {
                    fieldBitmapPictureBox.Invalidate();
                    fieldBitmapPictureBox.Visible = true;
                } 
                enabledDrawing = value;
            }
        }

        public override void DoBeat()
        {
            //Генерация еды
            Random randomizer = new Random();
            int x, y;
            for (int i = 0; i < SettingsWin.FoodGenerationSpeed; i++)
            {
                //Попытка сгенерировать очередную еду
                for (int j = 0; j < 16; j++)
                {
                    x = randomizer.Next(Width);
                    y = randomizer.Next(Height);
                    if (EntityMatrix[x,y].Type == "emptyEntity")
                    {
                        food newFood = new food();
                        this.AddEntity(newFood, x, y);
                        break;
                    }
                }
            }
            
            //Обработка тактовых действий сущностей
            int queueLength = beatQueue.Count;
            for (int i = 0; i < queueLength; i++)
            {
                elementaryEntity someEntity = beatQueue.Dequeue();
                if (someEntity.IsAlive)
                {
                    someEntity.BeatAction();
                    if (someEntity.IsAlive)
                        beatQueue.Enqueue(someEntity);
                    else
                        this.ClearEntity(someEntity.X, someEntity.Y);
                }
            }

            if (enabledDrawing)
                fieldBitmapPictureBox.Invalidate();
        }

        //Согласовать изображение c сущностью по координатам (х, у)
        protected virtual void HarmonizeEntityAndPicture(int x, int y)
        {
            switch(EntityMatrix[x,y].Type)
            {
                case "elementaryEntity":
                    for (int i = x * 10; i < x * 10 + 10; i++)
                        for (int j = y * 10; j < y * 10 + 10; j++)
                            fieldBitmap.SetPixel(i, j, Color.Orange);
                    break;
                case "food":
                    for (int i = x * 10; i < x * 10 + 10; i++)
                        for (int j = y * 10; j < y * 10 + 10; j++)
                            fieldBitmap.SetPixel(i, j, Color.Green);
                    break;
                case "emptyEntity":
                default:
                    for (int i = x * 10; i < x * 10 + 10; i++)
                        for (int j = y * 10; j < y * 10 + 10; j++)
                            fieldBitmap.SetPixel(i, j, Color.White);
                    break;
                    
            }
        }
        
        public fieldElementarySimulation(int width, int height) : base(width, height)
        {
            fieldBitmap = new Bitmap(width * 10, height * 10);
            fieldBitmapPictureBox = new PictureBox();

            fieldBitmapPictureBox.Image = fieldBitmap;
            fieldBitmapPictureBox.BackColor = System.Drawing.SystemColors.Control;
            fieldBitmapPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            fieldBitmapPictureBox.Location = new System.Drawing.Point(200, 0);
            fieldBitmapPictureBox.BackColor = Color.White;
            fieldBitmapPictureBox.Name = "BitmapPictureBox";
            fieldBitmapPictureBox.Size = new System.Drawing.Size(width * 10, height * 10);
            fieldBitmapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            fieldBitmapPictureBox.TabIndex = 0;
            fieldBitmapPictureBox.TabStop = false;
            fieldBitmapPictureBox.MouseClick += this.EntityClick;
        }

        //Обработчик события нажатия на сущность
        protected virtual void EntityClick(object sender, MouseEventArgs e)
        {
            try
            {
                PictureBox currentBox = (PictureBox)sender;
                entity currentEntity = EntityMatrix[e.X / 10, e.Y / 10];
                if (isAdditionalMood)
                {
                    elementaryEntity ent = new elementaryEntity();
                    ent.Energy = SettingsWin.StartEnergy;
                    this.AddEntity(ent, e.X / 10, e.Y / 10);
                    fieldBitmapPictureBox.Invalidate();
                }
                if (isDeletingMood)
                {
                    emptyEntity ent = new emptyEntity();
                    this.AddEntity(ent, e.X / 10, e.Y / 10);
                    fieldBitmapPictureBox.Invalidate();
                }
            }
            catch { }

        }

        public override void AddEntity(entity newEntity, int x, int y)
        {
            if (EntityMatrix[x, y].Type == "elementaryEntity")
                ((elementaryEntity)EntityMatrix[x, y]).IsAlive = false;
            EntityMatrix[x, y] = newEntity;
            newEntity.EntityBase = this;
            newEntity.X = x;
            newEntity.Y = y;
            HarmonizeEntityAndPicture(x, y);
            if (newEntity.Type == "elementaryEntity")
                beatQueue.Enqueue((elementaryEntity)newEntity);
        }
        public override void ClearEntity(int x, int y)
        {
            if (EntityMatrix[x, y].Type == "elementaryEntity")
                ((elementaryEntity)EntityMatrix[x, y]).IsAlive = false;
            EntityMatrix[x, y] = new emptyEntity();
            EntityMatrix[x, y].EntityBase = this;
            EntityMatrix[x, y].X = x;
            EntityMatrix[x, y].Y = y;
            HarmonizeEntityAndPicture(x, y);
        }
        public override void MoveEntity(int oldX, int oldY, int newX, int newY)
        {
            EntityMatrix[newX, newY] = EntityMatrix[oldX, oldY];
            EntityMatrix[newX, newY].X = newX;
            EntityMatrix[newX, newY].Y = newY;
            EntityMatrix[oldX, oldY] = new emptyEntity();
            EntityMatrix[oldX, oldY].EntityBase = this;
            EntityMatrix[oldX, oldY].X = oldX;
            EntityMatrix[oldX, oldY].Y = oldY;
            HarmonizeEntityAndPicture(oldX, oldY);
            HarmonizeEntityAndPicture(newX, newY);
        }
    }
}
