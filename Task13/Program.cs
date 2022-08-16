// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs (number);

if (number<100)
{
Console.WriteLine("В числе нет третьей цифры");
}
else
{
   while (number >= 1000)
   {
    number /= 10;
   }
   int digit3 = number % 10;
    Console.WriteLine(digit3);
}
