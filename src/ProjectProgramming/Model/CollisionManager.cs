using Programming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProgramming.Model
{
    class CollisionManager
    {
        static public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double halfLength = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;
            double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfWidth = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            return differenceX < halfWidth && differenceY < halfLength ;
        }

        static public bool IsCollision(Ring Ring1, Ring Ring2)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(Ring1.Center.X - Ring2.Center.X), 2) + Math.Pow(Math.Abs(Ring1.Center.Y - Ring2.Center.Y), 2));
            double sumOfExternalRad = Ring1.Intoradius + Ring2.Intoradius;
            return hypotenuse < sumOfExternalRad;
        }
    }
}
