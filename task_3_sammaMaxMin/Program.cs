// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
double [] massiv = new double [L];
Random rand = new Random();
for (int i = 0; i < L; i++)
{
   massiv [i] = Convert.ToDouble (rand.Next(-100,100)/10.0);
   System.Console.Write(massiv[i]+", ");
}
double max = massiv[0];
double min = massiv[0];
for (int i = 0; i < L-1; i++)
{
   if (massiv[i+1]>max)
   {
    max = massiv[i+1];
   }
}
for (int i = 0; i < L-1; i++)
{
   if (massiv[i+1]<min)
   {
    min = massiv[i+1];
   }
}
double deff = max-min;
System.Console.WriteLine();
System.Console.WriteLine("max число"+max);
System.Console.WriteLine("min число"+min);
System.Console.WriteLine("Разница max и min чисел массива равна  "+deff);
}
}
catch
{
    System.Console.WriteLine("Вы ввели не число");
}