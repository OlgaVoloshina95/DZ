// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
bool flag=false;
int number = Convert.ToInt32(Console.ReadLine());
while (flag==false)
{
    
    if (5==Convert.ToString(number).Length )
        {
            flag=true;
        }
        else
        {
            Console.WriteLine("Введено не пятизначное число, повторите ввод:");
            number = Convert.ToInt32(Console.ReadLine());
        }
}
string str=Convert.ToString(number);
if ((str[0]==str[4])&(str[2]==str[3]))
    {
        Console.WriteLine("Число - палиндром");
    }
    else
    {
        Console.WriteLine("Число - не палиндром");
    }
