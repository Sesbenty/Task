using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;
using System.Resources;
using Task.Objects;
namespace Task
{
    class Project
    {
        Sprite playerSprite;
        Sprite bear;
        int dx = 1;

        public Size Resolution { get; set; }

        public void Load()
        {
            playerSprite = new Sprite();
            playerSprite.x = 300;
            playerSprite.y = 300;

            playerSprite.width = 500;
            playerSprite.height = 150;

            playerSprite.velocity = 300;

            playerSprite.sprite = Properties.Resources.cat;

            bear = new Sprite();
            bear.x = 100;
            bear.y = 100;

            bear.width = 100;
            bear.height = 100;

            bear.velocity = 200;

            bear.sprite = Properties.Resources.bear;

        }

        public void Unload()
        {
            
        }

        public void Update(TimeSpan gameTime)
        {
            
            double gameTimeElapsed = gameTime.TotalMilliseconds / 1000;
            int moveDistance = (int)(playerSprite.velocity * gameTimeElapsed);

            if ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0)
            {
                playerSprite.x += moveDistance;
            }
            if ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0)
            {
                playerSprite.x -= moveDistance;
            }
            if ((Keyboard.GetKeyStates(Key.Up) & KeyStates.Down) > 0)
            {
                playerSprite.y -= moveDistance;
            }
            if ((Keyboard.GetKeyStates(Key.Down) & KeyStates.Down) > 0)
            {
                playerSprite.y += moveDistance;
            }

            bear.x += (int)(gameTimeElapsed * bear.velocity) * dx;
            if (bear.x > 600 && dx == 1)
            {
                dx = -dx;
            }
            if (bear.x < 0 && dx == -1)
            {
                dx = -dx;
            }
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(Color.CornflowerBlue), new Rectangle(0, 0, Resolution.Width, Resolution.Height));

            playerSprite.Draw(gfx);
            bear.Draw(gfx);
        }
    }
}
