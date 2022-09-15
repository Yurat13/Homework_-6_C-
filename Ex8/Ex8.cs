// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

void FindSimMinRows (int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        sumRow = matrix[i, j] + sumRow;
        }
        Console.WriteLine($"Sum of {i+1}-row = {sumRow} ");
               
    }   
   
}


int[,] array = new int [3,4];
FillArray(array, 1, 10);
PrintArray(array);
FindSimMinRows(array);
