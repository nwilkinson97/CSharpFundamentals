namespace CSLib
{




    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // public ShapeType Type { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Drawing...");
        }

    }
}
