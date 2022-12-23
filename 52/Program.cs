// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// method to create an array

int[,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] array = new int[rows, columns];
    int i = 0, j = 0;
    while (i < rows)
    {
        j = 0;
        while (j < columns)
        {
            array[i, j] = new Random().Next(0, 11);
            j++;
        }
        i++;
    }
    return array;
}

// method to print an array

void PrintArray(int[,] array)
{
    int i = 0, j = 0;
    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            Console.Write("{0}\t", array[i, j]);
            j++;
        }
        Console.WriteLine(" ");
        i++;
    }
}

// request to enter initial data

Console.Write("Enter the number of rows... ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns... ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("The computer selects the elements of the array... ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine("The computer prints the array... ");
Console.WriteLine(" ");
PrintArray(array);

// search for average in each column

void AverageInColumn(int[,] array)
{
    int i = 0, j = 0;
    double average = 0.0;
    while (j < columns)
    {
        i = 0;
        double sum = 0;
        while (i < rows)
        {
            sum += array[i, j];
            i++;
        }
        average = Math.Round((sum / i), 2);
        Console.WriteLine($"The average of the elements of the {j} column is {average}");
        j++;
    }
}
AverageInColumn(array);