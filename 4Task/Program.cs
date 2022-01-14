// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Первое уравнение задано следующим выражением: y = k1 * x + b1");
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе уравнение задано следующим выражением: y = k2 * x + b2");
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Две линии пересекутся в точке при равных x и y, поэтому приравняем друг другу правые части уравнений:");
Console.WriteLine($"{k1}x + {b1} = {k2}x + {b2}");
double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;
Console.Write($"Координата точки пересечения двух прямых - ({x},{y})");