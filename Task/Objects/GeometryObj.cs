﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Geometry;
using System.Drawing;

namespace Task.Objects
{
    class GeometryObj:Component
    {
        List<Vector2> points;

        public GeometryObj(GameObject parent,List<Vector2> points) : base(parent)
        {
            this.points = points;
        }
        public GeometryObj(GameObject parent, params Vector2[] vectors) : base(parent)
        {
            points = new List<Vector2>(vectors);
        }

        public override void Draw()
        {
            Pen pen = new Pen(Brushes.Black);
            for (int i = 0; i < points.Count - 1; i++)
            {
                Render.gfx.DrawLine(pen, new Point((int)points[i].x, (int)points[i].y), new Point((int)points[i + 1].x, (int)points[i + 1].y));
            }
        }

        public override void Start()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
