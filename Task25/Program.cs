// Задача пример


// void GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     } 
//     Console.WriteLine($"Cумма цифр от 1 до введенного числа: {sum}");

// }

// Console.Clear();

// GetSumNums(-5);
// GetSumNums(58);
// GetSumNums(25);
// GetSumNums(16);

// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int Length(int number)
// {
//  int count = 1;
//     while(number / 10 != 0)
//     {
//         number = number / 10;
//         count += 1;
//     }
//     return count;

// }
// int result = Length(345);
// Console.WriteLine(result);






// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число ");
// int chis = Convert.ToInt32(Console.ReadLine());
// int proizv = 1;
// for (int i = 1; i < chis+1; i++)
// {
//     proizv = proizv * i;
//     Console.WriteLine(proizv);
// }
// Console.WriteLine(proizv);

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


// int GetMultiply(int number)
// {
//     int result = 1;
//     for (int i = 2; i <= number; i++)
//     {
//         result *= i;
//     }
//     return result;
// }




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//  нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] myArray = new int[8];
//             Random rand= new Random();
//             for (int i = 0; i < myArray.Length; i++)
//             {
//                 myArray[i] = rand.Next(2);
//                 Console.WriteLine(myArray[i]);
//             }



int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}

