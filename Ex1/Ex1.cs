// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintArray (float[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (float[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(-100, 100);
        }
    }
}

float[,] array = new float [3, 4];
FillArray(array);
PrintArray(array);