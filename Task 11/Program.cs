// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98



// int randInt = new Random().Next(100,999);
// Console.WriteLine($"число = {randInt}");
// Console.WriteLine($"{randInt.ToString()[0]}{randInt.ToString()[2]}");

int number = new Random().Next(100,1000);
Console.WriteLine(number);
Console.Write(number/100);
Console.Write(number%100);
