// ДЗ№4

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;
while (number <= N)
{
    Console.Write($"{number}, ");
    number += 2;
}
