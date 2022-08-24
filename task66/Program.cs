/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void SumNaturalNumbers(int num1, int num2, int sum)
{
    if (num1 < num2)
    {
        sum += num1;
        SumNaturalNumbers(++num1, num2, sum);
    }
    else
    {
        sum += num2;
        Console.WriteLine(sum);
    }
}


Console.WriteLine("Введите число M и N через пробел:");
string[] input = Console.ReadLine().Split();
int M = int.Parse(input[0]);
int N = int.Parse(input[1]);

int SumNat = 0;

Console.Write("M = " + M + "; " + "N = " + N + " -> ");

if (M >= 0 && N > M)
{
    SumNaturalNumbers(M, N, SumNat);
}
else if (N < M && N >= 0)
{
    SumNaturalNumbers(M, N, SumNat);
}
else
{
    Console.WriteLine("Осуществлен неверный ввод");
}