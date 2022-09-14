// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] massiv, int minimum, int maximum)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(minimum, maximum);
        }
    }
}

int[,] ReplaceRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int value = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = value;
    }
    return matrix;
}

int[,] array = new int [5,6];
FillArray(array, 1, 10);
PrintArray(array);
ReplaceRow(array);
Console.WriteLine("Changed rows in Array:");
PrintArray(array);