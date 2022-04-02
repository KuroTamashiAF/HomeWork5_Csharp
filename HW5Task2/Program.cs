// Показать числа Фибоначчи
int n1 = 0;
int n2 = 1;
int temp;
Console.Write("ВВедите число до которого будут считаться числа Фибоначи  ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(n1 + " " + n2 + " ");
    while (n1 + n2 <= num)
{
    Console.Write((n1) + (n2) + " ");
    temp = n2;
    n2 = n1 + n2;
    n1 = temp;
}



