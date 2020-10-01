using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;
using Task.Geometry;

namespace Task.Objects
{
    class GeometryObject : Component
    {
        List<Vector2> points;
        List<Point> lines;
        public GeometryObject(GameObject parent, List<Vector2> points, List<Point> lines):base(parent)
        {
            this.points = points;
            this.lines = lines;
        }
        public override void Draw()
        {
            for (int i = 0; i < lines.Count; i++)
            {
                Render.gfx.DrawLine(Pens.Red, points[lines[i].X].x + gameObject.position.x, points[lines[i].X].y + gameObject.position.y,
                    points[lines[i].Y].x + gameObject.position.x, points[lines[i].Y].y + gameObject.position.y);
            }
        }

        public override void Start()
        {
            
        }

        public override void Update()
        {
            gameObject.position.AngleAtCenter(Time.deltaTime, new Vector2(50, 50));
            for (int i = 0; i < points.Count; i++)
            {
                float time = 2 * Time.deltaTime;
                points[i].AngleAtCenter(time, gameObject.position + new Vector2(150,150));
            }
        }
    }
}
