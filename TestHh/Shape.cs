namespace TestHh
{
    public abstract class Shape
    {
        public string FigureName { get; private set; }

        public Shape(string figureName)
        {
            FigureName = figureName;
        }

        public abstract double CalcSquare();
    }
}
