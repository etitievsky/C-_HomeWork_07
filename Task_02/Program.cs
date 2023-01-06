// Программа на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

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

void ShowArrayElement(int[,] array, int row, int column)
{
    int m = row-1;
    int n = column-1;
    if(m >= array.GetLength(0) || n >= array.GetLength(1))
    {
        Console.WriteLine($"A({row},{column}) - нет такого элемента");
    }
    else Console.WriteLine($"A({row},{column}) = {array[m,n]}");
}

int[,] array = CreateArray(4, 4, -10, 10);
int m = EnterData("Введите номер строки элемента массива - m: ");
int n = EnterData("Введите номер столбца элемента массива - n: ");
PrintArray(array);
Console.WriteLine();
ShowArrayElement(array, m, n);