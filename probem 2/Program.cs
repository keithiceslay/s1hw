/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите числа");
string a1 = Console.ReadLine();
string b1 = Console.ReadLine();
string c1 = Console.ReadLine();
int a = int.Parse(a1);
int b = int.Parse(b1);
int c = int.Parse(c1);
if (a>=b && b>=c)
{
    Console.WriteLine(a);
}
if (b>=a && b>=c)
{
    Console.WriteLine(b);
}
if (c>=a && c>=b)
{
    Console.WriteLine(c);
}