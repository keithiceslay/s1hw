/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите числа");
Console.Write ("a = ");
string a1 = Console.ReadLine();
Console.Write("b = ");
string b1 = Console.ReadLine();
int a = int.Parse(a1);
int b = int.Parse(b1);
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
if (b > a)
{
    Console.WriteLine($"max = {b}");
}