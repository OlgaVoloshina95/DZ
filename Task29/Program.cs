// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Ниже массив из случайных чисел");
Random rnd=new Random();
int[] array=new int[1];
for (int i=0;i<array.Length;i++)
{
    array[i]=rnd.Next();
    Console.WriteLine(array[i]); 
}
