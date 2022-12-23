// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    double[,] array = new double[rows, columns];
    int i = 0, j = 0, k = 0;
    while (i < rows)
    {
        j = 0;
        while (j < columns)
        {
            k = new Random().Next(0, 2);  // Этот коэффициент определяет будет ли получаемый элемент массива целочисленным или нет

            array[i, j] = new Random().Next(-10, 11) + k * Math.Round(rnd.NextDouble(), 1);
            j++;
        }
        i++;
    }
    return array;
}

void PrintArray(double[,] array)
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

Console.Write("Enter the number of rows... ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns... ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("The computer selects the elements of the array... ");
double[,] array = new double[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine("The computer prints the array... ");
Console.WriteLine(" ");
PrintArray(array);