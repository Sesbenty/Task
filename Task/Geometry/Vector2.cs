using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task.Geometry
{
    public class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void AngleAtCenter(float a, Vector2 center)
        {
            float cosa = (float) Math.Cos(a);
            float sina = (float) Math.Sin(a);

            x = (x - center.x) * cosa - (y - center.y) * sina + center.x;
            y = (x - center.x) * sina + (y - center.y) * cosa + center.y;
        }

        public static float Distance(Vector2 a, Vector2 b)
        {
            return (float)Math.Sqrt(a.x * b.x + a.y * b.y);
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }


    }
}
