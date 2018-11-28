namespace CSLib
{
    public class ShapeText : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            // After making the Shape Class where Shape is the Base Class
            // we are now required to implement the Draw method
            // by using the keyboard shortcut {CTRL} + {PERIOD} it will 
            //  automatically implement the abastract class methods
            throw new System.NotImplementedException();
        }
    }
}
