/*
Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void FilledNumbers(int num1, int num2)
{
        if (num1 == num2)
        {
            Console.Write(num1 + "\"");
        }
        else if (num1 < num2)
        {
            Console.Write(num1 + ", ");
            FilledNumbers(++num1, num2);
        }
}


Console.WriteLine("Введите число M и N через пробел:");
string[] input = Console.ReadLine().Split();
int M = int.Parse(input[0]);
int N = int.Parse(input[1]);

Console.Write("\"");
if (M >= 0 && N > M)
{
    FilledNumbers(M, N);
}
else if (N < M && N >= 0)
{
    FilledNumbers(N, M);
}
else if (N == M && N >= 0)
{
    FilledNumbers(N, M);
}
else
{
    Console.WriteLine("Осуществлен неверный ввод");
}