using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepino_A_Star
{
    /// <summary>
    /// @author Eduardo Fernandes nº12927
    /// @author Damien Fialho nº11243
    /// 
    /// @date 06/06/1024
    /// @code https://code.google.com/p/eda1314-11243-12927/
    /// 
    /// Vector2 class created by us.
    /// </summary>
    /// 

    public class Vector2
    {

        public int X;
        public int Y;

        /// <summary>
        /// Constructor
        /// </summary>
        public Vector2()
        {
            this.SetPos(0, 0);
        }

        /// <summary>
        /// Constructor with a given x and y
        /// </summary>
        /// <param name="X">X Pos</param>
        /// <param name="Y">Y Pos</param>
        public Vector2(int X, int Y)
        {
            this.SetPos(X,Y);
        }

        /// <summary>
        /// Constructor with a given vector2
        /// </summary>
        /// <param name="_st">Vector2 object</param>
        public Vector2(Vector2 _st)
        {
            this.SetPos(_st.X, _st.Y);
        }

        /// <summary>
        /// Prints the Location
        /// </summary>
        /// <returns>Location</returns>
        public override string ToString()
        {
            return "{"+this.X+";"+this.Y+"}";
        }

        /// <summary>
        /// Sets the Vector2 Location
        /// </summary>
        /// <param name="X">X Position</param>
        /// <param name="Y">Y Position</param>

        public void SetPos(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
        /// <summary>
        /// Gets the X Position
        /// </summary>
        /// <returns>X Position</returns>
        public int GetX()
        {
            return this.X;
        }

        /// <summary>
        /// Gets the Y Position
        /// </summary>
        /// <returns>Y Position</returns>
        public int GetY()
        {
            return this.Y;
        }

    }
}
