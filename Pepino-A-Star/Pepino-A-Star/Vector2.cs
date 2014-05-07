using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepino_A_Star
{
    public class Vector2
    {

        public int X;
        public int Y;

        public Vector2()
        {
            this.SetPos(0, 0);
        }

        public Vector2(int X, int Y)
        {
            this.SetPos(X,Y);
        }

        public void SetPos(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int GetX()
        {
            return this.X;
        }

        public int GetY()
        {
            return this.Y;
        }

        public Vector2 GetPos()
        {
            return this;
        }

    }
}
