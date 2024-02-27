namespace Task2_Perimeter_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).
            // Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.
            int x1 = 3, y1 = 1, x2 = 8, y2 = 4;
            int a = Math.Abs(x2 - x1); // длина
            int b = Math.Abs(y2 - y1); // ширина
            int p = 2 * (a + b);
            int s = a * b;

            Console.WriteLine($"Периметр прямоугольника {p}");
            Console.WriteLine($"Площадь прямоугольника {s}");
        }
    }
}