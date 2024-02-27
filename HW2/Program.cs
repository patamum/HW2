namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью
            int l = 200;
            double r = l / (2 * Math.PI);
            double s = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"Радиус {r}");
            Console.WriteLine($"Площадь круга {s}");

        }
    }
}