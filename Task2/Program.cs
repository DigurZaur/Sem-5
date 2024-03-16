// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали

int[,] array = new int[5,5];

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,16);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int result()
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if( i == j )
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

FillingArray();
PrintArray();
System.Console.WriteLine(result());