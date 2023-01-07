// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            array[i,j] = new Random().Next(minNumber, maxNumber+1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}

void ArrayColumnsAverage(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine("Average:");
    for(int j=0; j<columns; j++)
    {
    double average = 0;
        for(int i=0; i<rows; i++)
        {
            average = average + array[i,j];
        }
    average = average / rows;
    Console.Write("{0:0.0} ", average);
    }
}

int[,] array = CreateArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
ArrayColumnsAverage(array);
