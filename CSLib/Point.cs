namespace CSLib
{
    public class Point
    {
        /// <summary>
        /// Defines the X Position of the cursor (HORIZONTAL)
        /// </summary>
        public int X;
        /// <summary>
        /// Defines the Y Position of the cursor (VERTICAL)
        /// </summary>
        public int Y;

        /// <summary>
        /// Defines te point object boject
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Moves teh point object to a designated location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Override for the Method allowing you to pass a new Point on the grid
        /// </summary>
        /// <param name="newLocation"></param>
        public void Move(Point newLocation)
        {
            // Call the existing move method and provide information.
            // Prevent duplication of codehere.
            Move(newLocation.X, newLocation.Y);
        }

    }
}
