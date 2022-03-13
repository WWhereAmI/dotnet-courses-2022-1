namespace Task4.Board
{
    internal class River : MapObjects
    {
        public override double Width { get; set; }
        public override double Height { get; set; }
        public River()
        {
            Width = 50;
            Height = 150;
        }
    }
}
