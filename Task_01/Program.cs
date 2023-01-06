// Задайте двумерный массив размером m×n, заполненный случайными вещественными числам

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] CreateArray(int rows, int columns, double minNumber, double maxNumber)
{
    double[,] array = new double[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            array[i,j] = new Random().NextDouble() + new Random().Next(-10, 10);
            array[i,j] = Math.Round(array[i,j],1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

int rows = EnterData("Введите количество строк массива m: ");
int columns = EnterData("Введите количество столбцов массива n: ");
double[,] array = CreateArray(rows, columns, -10, 10);
PrintArray(array);