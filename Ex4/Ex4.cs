// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

void GetArithmeticMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        Console.Write($" {Math.Round(sum/matrix.GetLength(0), 2)} ");
    }   
}

int[,] array = new int [3, 4];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine("Arithmetic Mean:");
GetArithmeticMean(array);


