 //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// первый вариант решения
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbera = number / 10 % 10 ;
    Console.WriteLine($"Вторая цифра числа {number} это {numbera}");

