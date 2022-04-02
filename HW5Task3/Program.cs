// Написать программу масштабирования фигуры
void FillSquare(int[,] sq)
{
    for (int i = 0; i < sq.GetLength(0); i++)
    {
        for (int j = 0; j < sq.GetLength(1); j++)
        {
            sq[i, j] = 0;
        }
    }
}
void PrintSquare(int[,] sq)
{
    for (int i = 0; i < sq.GetLength(0); i++)
    {
        for (int j = 0; j < sq.GetLength(1); j++)
        {
            Console.Write(sq[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SpecifyingFigure(int [,]sq)
{
    for (int i = 1; i < sq.GetLength(0); i++)
    {
        for (int j = 1; j < sq.GetLength(1); j++)
        {
            if (sq[i+1,j+1]==0)
            {
                sq[i,j] = 5;
            }
        }
    }
}







int[,] square = new int[10, 10];
FillSquare(square);
PrintSquare(square);
SpecifyingFigure(square);
PrintSquare(square);