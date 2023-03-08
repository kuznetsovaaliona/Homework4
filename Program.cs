// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     double[,] newArray = new double[rows, colums];
//     Random rand = new Random ();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
        
//         {
//             newArray[i, j] = (new Random().Next(minValue, maxValue+1) + Math.Round(rand.Next(minValue, maxValue + 1)*0.1,1));

//         }
//     }

//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);

// Show2DArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//  int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindElement (int[,] array,int row,int column)

// { 
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         { 

//             if (row==i ||column==j)
//             {
//                 return array [i,j];
//             }
//             else
//             { Console.WriteLine("Number of Element Not Find");

//             }
//         }
        
//     }

// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number row of elements");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number column of elements");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array);
// Console.WriteLine(FindElement(array));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void AverageColumn (int[,] array)
// {
//     for (int j=0; j < array.GetLength(1); j++)
//     {
//         int sum =0;
//         for (int i = 0; i<array.GetLength(0);i++)
//         {
//             sum = (array[i, j] + sum);
//         }
//               Console.WriteLine($"{sum/array.GetLength(1)}=average of columns");
//     }
//     Console.ReadLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);

// Show2DArray(array);
// AverageColumn(array);
