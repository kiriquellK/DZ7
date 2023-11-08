namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите характеристики сферы:");
            Console.WriteLine("Радиус:");
            bool isInputRadius = int.TryParse(Console.ReadLine(), out int inputRadius);
            if (!isInputRadius || inputRadius < 0)
            {
                Console.WriteLine("Некорректный радиус");
            }
            else
            {
                Console.WriteLine("Координата X");
                bool isinputXCenter = double.TryParse(Console.ReadLine(), out double inputXCenter);
                Console.WriteLine("Координата Y");
                bool isinputYCenter = double.TryParse(Console.ReadLine(), out double inputYCenter);
                Console.WriteLine("Координата Z");
                bool isinputZCenter = double.TryParse(Console.ReadLine(), out double inputZCenter);
                if (!isinputXCenter || !isinputYCenter || !isinputZCenter)
                {
                    Console.WriteLine("Некорректные координаты");
                }
                else
                {
                    Sphere sphere = new Sphere();
                    Console.WriteLine($"Построена сфера с центром в точке {sphere.GetCenter()} и радиусом {sphere.Radius}");
                    Sphere sphere1 = new Sphere(inputRadius, inputXCenter, inputYCenter, inputZCenter);
                    sphere1.Radius = inputRadius;
                    sphere1.SetCenter(inputXCenter, inputYCenter, inputZCenter);
                    Console.WriteLine($"Построена сфера с центром в точке {sphere1.GetCenter()} и радиусом {sphere1.Radius}");
                    Console.WriteLine($"Объем заданной сферы: {sphere1.GetVolume()}");
                    Console.WriteLine($"Площадь поверхности сферы: {sphere1.GetSquare()}");
                    Console.WriteLine($"Принадлежит ли точка с координатами (4,8,1): {sphere1.isPointInside(4, 8, 1)}");
                    Console.WriteLine($"Принадлежит ли точка с координатами (-1,2,1): {sphere1.isPointInside(-1, 2, 1)}");
                    Console.WriteLine("Вторая сфера:");
                    Sphere sphere2 = new Sphere(6, 1, 0.5, 4);
                    Console.WriteLine($"Центр сферы:{sphere2.GetCenter()}");
                    Console.WriteLine($"Радиус сферы:{sphere2.Radius}");
                    Console.WriteLine("Третья сфера");
                    Sphere sphere3 = new Sphere(5.5);
                    Console.WriteLine($"Центр сферы: {sphere3.GetCenter()}");
                    Console.WriteLine($"Радиус сферы: {sphere3.Radius}");
                }
            }
        }
    }
}
