// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
try
{
int L = int.Parse (Console.ReadLine ());
if (L<=0) 
{
Console.WriteLine("Вы ввели отрицательное число или 0 ");
}
else
{
int [] massiv = new int [L];
Random rand = new Random();
for (int i = 0; i < L; i++)
{
   massiv [i] = rand.Next(99,1000);
   System.Console.Write(massiv[i]+", ");
}
int count = 0;
for (int i = 0; i < L; i++)
{
   if (massiv [i]%2==0)
   count++;
}
System.Console.WriteLine();
System.Console.WriteLine("Количество четных чисел в массиве  "+count);
}
}
catch
{
    System.Console.WriteLine("Вы ввели не число");
}