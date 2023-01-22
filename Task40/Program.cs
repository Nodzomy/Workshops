
// // Задача 39: Напишите программу, которая перевернёт одномерный массив 
// // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int[] array = GetArray(8);
// Console.WriteLine($" [ {String.Join(", ", array)} ] ");
// ChangeArray(array);
// Console.WriteLine($" [ {String.Join(", ", array)} ] ");

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 999);
//     }

//     return result;
// }

// // for (int i = array.Length - 1; i >= 0; i--)
// // {
// //     System.Console.Write(array[i] + " ");
// // }


// // for (int i = 0; i <= array.Length/2; i++)
// // {
// //     int c = array[i];
// //     arr[i] = array[^(i+1)];
// //     arr[^(i+1)] = c;
// // }
// // PrintArr(ref array);

// // void ChangeArray(int[] array)
// //     {
// //         int temp = 0;
// //         for (int i = 0; i < array.Length / 2; i++)
// //         {
// //             temp = array[i];
// //             array[i] = array[array.Length - 1 - i];
// //             array[array.Length - 1 - i] = temp;
// //         }
// //     }


//     Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//     может ли существовать треугольник с сторонами такой длины

// bool CheckTriangle(int[] array)
// {
//     bool flag = (array[0] < array[1] + array[2]) && (array[1] < array[0]+ array[2]) && (array[2] < array[0] + array[1]) ? true : false;
//     return flag;
// }

// Console.WriteLine(CheckTriangle(arr));




//     Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int x = CheckNumberInt("Введите число в десятичной системе:   ");
// string y = "";

// while ( x > 0 )
// {
//     string x1 = (x % 2).ToString();
//     y += x1;
//     x = x/2;
// }
// Console.WriteLine(y);

// string DecimalToBinary(int number)
// {
//     string res = "";
//     while ( number > 0 )
//     {
//     string x1 = (number % 2).ToString();
//     res += x1;
//     number = number/2;
//     }
//     char[] strChar = res.ToCharArray();
//     Array.Reverse(strChar);
//     res = String.Join("", strChar);
//     return res;
// }

// int x = CheckNumberInt("Введите число в десятичной системе:   ");
// Console.WriteLine(DecimalToBinary(x));


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8







//  Задача 45: Напишите программу, которая будет создавать копию заданного массива 
//  с помощью поэлементного копирования.

// int[] arr = RandomIntArr(10, 10, 100);
// Console.Write("Исходный массив:   ");
// PrintArr(arr);

// int[] arrCopy  = new int[arr.Length];
// int[] CopyArray(int[] array)
// {
//     int[] copArr = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//     copArr[i] = array[i];
//     }
//     return copArr;
// }

// int[] copyArray = CopyArray(arr);
// Console.Write("Копия массива:   ");
// PrintArr(copyArray);