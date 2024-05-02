namespace TestHh
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(string figureName, double radius) : base(figureName)
        {
            Radius = radius;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
