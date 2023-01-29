// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;

class Program {
  public static void Main (string[] args) {

Console.Write("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
GetArray(array);
PrintArray(array);

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-999, 999)/ 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
  }
}