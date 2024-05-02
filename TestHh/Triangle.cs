namespace TestHh
{
    public class Triangle : Shape
    {
        public double ab { get; private set; }

        public double bc { get; private set; }

        public double ac { get; private set; }

        public bool IsRectangular => CheckRectangular();

        public Triangle(string figureName, double ab, double bc, double ac) : base(figureName)
        {
            if (ab < 0 || bc < 0 || ac < 0) throw new ArgumentException($"Error: Side can not be less than 0");
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) throw new ArgumentException($"Error: Your side greater than summary of two another sides");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }

        public override double CalcSquare()
        {
            double p = (ab + bc + ac) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1);
            return result;
        }

        private bool CheckRectangular()
        {
            bool check = ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2))
                         || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2))
                         || ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2));
            return check;
        }
    }
}
