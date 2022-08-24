/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNaturalNumbers(int num1, int num2)
{
    int sum = 0;
    while (num1 <= num2)
    {
        sum += num1;
        num1++;
    }
    return sum;
}

Console.WriteLine("Введите число M и N через пробел:");
string[] input = Console.ReadLine().Split();
int M = int.Parse(input[0]);
int N = int.Parse(input[1]);

int SumNat = 0;

if (M >= 0 && N > M)
{
    SumNat = SumNaturalNumbers(M, N);
}
else if (N < M && N >= 0)
{
    SumNat = SumNaturalNumbers(N, M);
}
else if (N == M && N >= 0)
{
    SumNat = SumNaturalNumbers(N, M);
}
else
{
    Console.WriteLine("Осуществлен неверный ввод");
}

Console.Write("M = " + M + "; " + "N = " + N + " -> " + SumNat);