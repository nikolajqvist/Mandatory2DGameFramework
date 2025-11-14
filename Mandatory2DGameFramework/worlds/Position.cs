using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.worlds
{
    /// <summary>
    /// Position?
    /// </summary>
    public class Position
    {
        public int X {  get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Når man opretter en ny position skal den have X og Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Position(int x, int y)
        {
            Y = y;
            X = x;
        }
        /// <summary>
        /// Operator overload, med gammel position og den nye position og ligger dem sammen.
        /// </summary>
        /// <param name="oldpos"></param>
        /// <param name="newpos"></param>
        /// <returns></returns>
        public static Position operator +(Position oldpos, Position newpos)
        {
            return new Position(oldpos.X + newpos.Y, oldpos.Y + newpos.Y);
        }
        /// <summary>
        /// Operator overload, med gammel position og den nye position og trækker dem fra hinanden.
        /// </summary>
        /// <param name="oldpos"></param>
        /// <param name="newpos"></param>
        /// <returns></returns>
        public static Position operator -(Position oldpos, Position newpos)
        {
            return new Position(oldpos.X - newpos.Y, oldpos.Y - newpos.Y);
        }
    }
}
