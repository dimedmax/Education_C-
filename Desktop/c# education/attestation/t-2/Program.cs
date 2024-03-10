// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int m = 2;
int n = 8;

int result = Function (m,n);
Console.WriteLine($"A({m}, {n}) = {result}");

int Function(int m, int n){
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Function(m - 1, 1);
    return Function(m - 1, Function(m, n - 1));
}