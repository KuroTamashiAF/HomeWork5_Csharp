// Написать программу масштабирования фигуры
void Fillarray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)                               
    {
        Console.Write($"Enter to coordinates X vertices number {i + 1} ");
        arr[i, 0] = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter to coordinates Y vertices number {i + 1} ");
        arr[i, 1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}
void Printarray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Scaling(int[,] arr, int ScalCoof)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] *= ScalCoof;
        }
    }
}
Console.Write("Enter number of vertices: ");
int NumberVertices = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[NumberVertices, 2];
Fillarray(array);
Printarray(array);
Console.Write("Enter Scaling Cooficeint ");
int ScalingCooficeint = Convert.ToInt32(Console.ReadLine());
Scaling(array, ScalingCooficeint);
Printarray(array);