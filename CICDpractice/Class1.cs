namespace CICDpractice
{
    public class GeometricOperations
    {
        public class Circle
        {
            public Circle(double radius)
            {
                if (radius <= 0)
                    throw new ArgumentOutOfRangeException("Значение радиуса окружности не может быть отрицательным числом или нулем");

                Radius = radius;
            }

            public double Radius { get; set; }

            public double GetPerimeter()
            {
                return 2 * Radius * Math.PI;
            }

            public double GetArea()
            {
                return Math.Pow(Radius, 2) * Math.PI;
            }

        }

        public class Rectangle
        {
            public Rectangle(double n)
            {
                if (n <= 0)
                    throw new ArgumentOutOfRangeException("Значение длины квадрата не может быть отрицательным числом или нулем");
                this.n = n;
            }

            public double n { get; set; }

            public double GetPerimeter()
            {
                return 4 * n;
            }

            public double GetArea()
            {
                return Math.Pow(n, 2);
            }

        }

        public class Triangle
        {
            public Triangle(double a, double b, double c)
            {
                if (a <= 0 || b <= 0 || c <= 0)
                    throw new ArgumentOutOfRangeException("Значение длины стороны треугольника не может быть отрицательным числом или нулем");

                if (!isValidTriangle(a, b, c))
                    throw new ArgumentException("Не треугольник");

                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double a { get; set; }
            public double b { get; set; }
            public double c { get; set; }

            private bool isValidTriangle(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }

            public double GetPerimeter()
            {
                return a + b + c;
            }

            public double GetArea()
            {
                double p = GetPerimeter() / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }


    }

}

