/*8. Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число N:");
int Number = int.Parse(Console.ReadLine());

for (int i = 1; i < Number; i++)
{
    Console.Write($"{i}");
}
