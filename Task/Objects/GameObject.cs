using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Geometry;

namespace Task.Objects
{
    class GameObject
    {
        public Vector2 position;
        private List<Component> components;

        public void Update()
        {
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Update();
            }
        }

    }
}
