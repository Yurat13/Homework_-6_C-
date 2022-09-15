// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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

void ChangeArrayColumnsOnRows (int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temporary;
        }
    }
}

int[,] array = new int [4,4];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
if (array.GetLength(0) == array.GetLength(1))
{
    ChangeArrayColumnsOnRows(array);
    PrintArray(array);
}
else Console.WriteLine("There is no solution");
