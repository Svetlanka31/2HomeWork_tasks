// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Является ли день выходным? Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1: Console.WriteLine("нет");
    break;

    case 2: Console.WriteLine("нет");
    break;

    case 3: Console.WriteLine("нет");
    break;

    case 4: Console.WriteLine("нет");
    break;

    case 5: Console.WriteLine("нет");
    break;

    case 6: Console.WriteLine("да");
    break;


    case 7: Console.WriteLine("да");
    break;
    
    default: Console.WriteLine("Такого дня нет");
    break;
}
