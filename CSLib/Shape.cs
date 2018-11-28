namespace CSLib
{
    public class Octagon : Shape
    {

    }

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // public ShapeType Type { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shape to Clipboard");
        }

        public void Select()
        {
            System.Console.WriteLine("Select the shape");
        }


    }
}
