// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();

// int[,] newArray = SortingDesc(array);
// PrintArray(newArray);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SortingDesc(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1)-1; k++)
//             {
//                 if (array[i,k+1]>array[i,k]) 
//                 { 
//                     int temporary = array[i,k];
//                     array[i,k] = array[i,k+1];
//                     array[i,k+1] = temporary;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка.

// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();

// SumMinRow(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumMinRow(int[,] array)
// {
//     int sum = 0;
//     int minSumRow = 0;
//     for(int j = 0, i = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//     int minSum = sum;
//     for(int i = 1; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             minSumRow = i;
//         }
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов - {minSumRow}.");
// }

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Число столбцов матрицы 1 должно равняться числу строк матрицы 2.");
// Console.WriteLine("Введите количество строк первой матрицы: ");
// int rows1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов первой матрицы: ");
// int columns1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество строк второй матрицы: ");
// int rows2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов второй матрицы: ");
// int columns2 = int.Parse(Console.ReadLine()!);

// if (rows1 != columns2)
// {
//     Console.WriteLine("Матрицы перемножить нельзя.");
// }
// else {
// int[,] array1 = GetArray(rows1, columns1, 0, 10);
// PrintArray(array1);
// Console.WriteLine();

// int[,] array2 = GetArray(rows2, columns2, 0, 10);
// PrintArray(array2);
// Console.WriteLine();

// int[,] rez = Result(array1, array2);
// PrintArray(rez);
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Result (int[,] array1, int[,] array2)
// {
//     int[,] resultArray = new int[array1.GetLength(0),array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < array2.GetLength(1); k++)
//             {
//                 result = result + array1[i,k] * array2[k,j];
//             }
//             resultArray[i,j] = result;
//         }
//     }
//     return resultArray;
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите x: ");
// int x = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите y: ");
// int y = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите z: ");
// int z = int.Parse(Console.ReadLine()!);

// int[,,] array = GetArray3D(x, y, z);
// PrintArray(array);
// Console.WriteLine();

// int[,,] GetArray3D(int x, int y, int z)
// {
//     int[] tempArray = new int[x*y*z];
//     int[,,] result = new int[x,y,z];
//     tempArray[0] = new Random().Next(10, 100);
//     for (int a = 1; a < tempArray.Length; a++)
//     {
//         tempArray[a] = new Random().Next(10, 100);
//         while (tempArray[a] == tempArray[a-1])
//         {
//             tempArray[a] = new Random().Next(10, 100);
//         }
//     }
//     int temporary = 0;
//     for(int i = 0; i < x; i++)
//     {
//         for(int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 result[i,j,k] = tempArray[temporary];
//                 temporary++;
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 Console.Write($"{array[i,j,z]} ({i},{j},{z}) ");
//             }
//         Console.WriteLine();
//         }
//     }
// }
