// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8



int namber = new Random().Next(10, 100);
Console.WriteLine(namber);

// if (namber /10 > namber % 10) Console.Writeline(namber /10);
// else Console.Writeline(namber%10);

Console.WriteLine(namber / 10 > namber % 10 ? namber / 10 : namber % 10);
