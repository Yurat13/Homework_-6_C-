// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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

void SortArray (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        int maxPosition = j;
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, k] > matrix[i, maxPosition]) maxPosition = k;
        }
        int temporary = matrix[i, j];
        matrix[i, j] = matrix[i, maxPosition];
        matrix[i, maxPosition] = temporary;
        }
    }
}

int[,] array = new int [3, 4];
FillArray(array, 1, 9);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
