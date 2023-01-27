// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


// создание массива и заполнение случайными числами: 
// int[,] CreateArray(int row, int col, int minValue, int maxValue)
// {
//     int[,] Array = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             Array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return Array;
// }

// // Вывод массива в консоль: 
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// void Replace(int[,] array)
// {
// int temp;
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     temp = array[0,i];
//     array[0,i] = array[array.GetLength(0)-1,i];
//     array[array.GetLength(0)-1,i] = temp;
// }
// }

// int rows = 3;
// int columns = 3;
// int[,] array = CreateArray(rows, columns, 1, 10);
// PrintArray(array);
// Replace(array);
// Console.WriteLine();
// PrintArray(array);



// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] ChangeRowsOnColumns(int[,] array)
// {
//     int rows = array.GetLength(0), columns = array.GetLength(1);
//     if (rows != columns)
//     {
//         Console.WriteLine("Заммена не возможна");
//         return array;
//     }
//     else
//     {
//         int[,] newArray = new int[rows, columns];
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 newArray[i, j] = array[j, i];
//             }
//         }
//         return newArray;
//     }
// }

// int[,] Change(int[,] array, int colum, int row)
// {
//     int[,] newArray = new int[colum, row];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             newArray[j, i] = array[i, j];
//         }
//     }
//     return newArray;
// }

// int rows = 4, columns = 4, randomMinValue = 0, randomMaxValue = 100;
// int[,] array = CreateRandomArray(rows, columns, randomMinValue, randomMaxValue);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(ChangeRowsOnColumns(array));
// array = ChangeRowsOnColumns(array);
// PrintArray(array);



// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.


// int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// static int FindValueInArray(int[,] array, int value)
// {
// int count = 0;
// foreach (int item in array)
// if (item == value) count++;
// return count;
// }

// static int[] Create1DArray(int[,] array)
// {
// List<int> list = new List<int>();
// foreach (var item in array)
// {
// if(!list.Contains(item)) list.Add(item);
// }
// return list.ToArray();
// }

// Console.Clear();
// int rows = 4, columns = 4, randomMinValue = 0, randomMaxValue = 10;
// int[,] array = CreateRandomArray(rows, columns, randomMinValue, randomMaxValue);
// int[] newArray = Create1DArray(array);
// PrintArray(array);
// Console.WriteLine();
// foreach (int item in newArray)
// {
// Console.WriteLine($"{item} => {FindValueInArray(array, item)}");
// }





// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший 
// элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
