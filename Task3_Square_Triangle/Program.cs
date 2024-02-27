namespace Task3_Square_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
            //Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости. Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: ,  где  — полупериметр.
           
            int x1 = 3, y1 = 1, x2 = 8, y2 = 4, x3 = 5, y3 = 6;
            double a = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double pp = (a + b + c) / 2;
            double p = pp * 2;
            double s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));

            Console.WriteLine($"Периметр треугольника {p}");
            Console.WriteLine($"Площадь треугольника {s}");
        }
    }
}