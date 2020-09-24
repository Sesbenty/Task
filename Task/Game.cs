using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Task.Objects;

namespace Task
{
    abstract class Game
    {
        List<GameObject> gameObjects;
        public Size Resolution { get; set; }
        public Game()
        {

        }

        public abstract void Load();
        public abstract void Unload();
        public void Update(TimeSpan gameTime)
        {
            Render.gfx.FillRectangle(new SolidBrush(Color.CornflowerBlue), new Rectangle(0, 0, Resolution.Width, Resolution.Height));
            Time.deltaTime = (float) gameTime.TotalMilliseconds / 1000;
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }
        }
    }
}
