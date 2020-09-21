using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;

namespace Task
{
    class Sprite
    {
        public Bitmap sprite;
        public float x, y;
        public float height, width;
        public int velocity;

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(sprite, new RectangleF(x, y, width, height));
        }

    }
}
