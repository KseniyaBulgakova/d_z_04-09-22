// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Введите первое число :");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int N = int.Parse(Console.ReadLine());

void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма чисел: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

GapNumberSum(M, N, 0);
