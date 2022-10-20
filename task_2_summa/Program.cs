// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
   massiv [i] = rand.Next(-10,10);
   System.Console.Write(massiv[i]+", ");
}
int summa = 0;
for (int i = 0; i < L; i++)
{
   if (i%2!=0)
   summa = summa + massiv[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Сумма чисел массива, стоящих на нечетных позициях  "+summa);
}
}
catch
{
    System.Console.WriteLine("Вы ввели не число");
}