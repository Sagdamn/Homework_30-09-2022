/*2. Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число:");
string firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string secondNumber = Console.ReadLine();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);

if (firstNum > secondNum)

    Console.WriteLine($"Число {firstNum} является бОльшим; Число {secondNum} является меньшим");

else if (firstNum < secondNum)

    Console.WriteLine($"Число {secondNum} является бОльшим; Число {firstNum} является меньшим");

else if (firstNum == secondNum)

Console.WriteLine($"Данные числа не соответствуют условию задачи. Замените цифры для корректной работы программы");