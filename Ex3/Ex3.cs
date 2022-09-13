// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10) Console.Write($" {matr[i, j]} ");
            else Console.Write($"{matr[i, j]} ");
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

int[,] ChangedArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i%2 == 0 && j%2 == 0) matr[i, j] = matr[i, j] * matr[i, j];
            else matr[i, j] = matr [i, j];
        }
    }
    return matr;
}
int[,] array = new int [6, 8];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Changed Array:");
int[,] changedArray = ChangedArray(array);
PrintArray(changedArray);

