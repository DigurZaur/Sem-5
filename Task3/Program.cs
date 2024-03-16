// Задайте двумерный массив из целых чисел. Сформируйте новый 
// одномерный массив, состоящих из средних арифметических
// значений по строкам двумерного массива.

int[,] array = new int[4,5];
double[] arraynew = new double[array.GetLength(0)];

void FillinArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,15);
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

void FillinArrayNew()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        arraynew[i] = sum / array.GetLength(1);
    }
}

void PrintArrayNew()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write(arraynew[i] + " ");
    }
}

FillinArray();
PrintArray();
FillinArrayNew();
System.Console.WriteLine();
PrintArrayNew();