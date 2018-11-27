using System;

namespace CSLib
{

    public class Circle : Shape
    {
        // Keyboard Shortcut 
        // -- type:  override {SPACE_BAR} d {ENTER}
        public override void Draw()
        {
            // base.Draw();  //  Used to call the Draw Method of the base class in our case there is nothing in the Draw Method
            Console.WriteLine("Draw a cricle");
        }

    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Draw a traingale");
        }
    }




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
