/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/


int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}


Console.WriteLine("Введите число M и N через пробел:");
string[] input = Console.ReadLine().Split();
int M = int.Parse(input[0]);
int N = int.Parse(input[1]);

int res;
res = A(M, N);


Console.WriteLine("m = " + M + ", n = " + N + "-> A(m,n) = " + res);
