// задача 15, второй способ
Console.WriteLine("Введите число, обозначающий день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

void CheckingDayOfWeek (int dayOfWeek)
{
  if (dayOfWeek > 0 && dayOfWeek <= 5)
  {
    Console.WriteLine("Этот день не выходной, нет");
  }
   else if (dayOfWeek == 6  || dayOfWeek == 7)
 {
    Console.WriteLine("Этот день выходной, Да");
 }
 else
{
    Console.WriteLine("Такого дня нет");
}
}
 CheckingDayOfWeek (dayOfWeek);
