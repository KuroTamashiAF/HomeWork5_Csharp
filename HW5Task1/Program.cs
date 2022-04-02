//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы



Console.Write("Введите K1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают, точки пересечения нет");
}
float x;
float y;
x = (b1 - b2) / (k2 - k1);
y = k1 * x + b1;
Console.WriteLine("Координаты точки пересечения " + '(' + x + ',' + y + ')');
 