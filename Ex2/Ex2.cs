// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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


void FillArray (int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = i + j;
        }
    }
}

int[,] array = new int [5, 6];
FillArray(array);
PrintArray(array);