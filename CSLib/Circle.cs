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
}
