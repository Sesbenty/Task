using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Geometry
{
<<<<<<< HEAD
    class Matrix4x4
    {
=======
    struct Matrix4x4
    {
        float[,] vs;

        public Matrix4x4()
        {
            vs = new float[4, 4];
        }

        public float this[int x, int y]
        {
            get { return vs[x, y]; }
            set { vs[x, y] = value; }
        }
>>>>>>> a54467378063af02b70c5af5407fe64773ee6a2b
    }
}
