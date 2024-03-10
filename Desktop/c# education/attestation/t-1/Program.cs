// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int M = 1;
int N = 5;

Print_numbers(M,N);

void Print_numbers (int start, int end){
    if (start > end)
        return;

    Console.Write(start);

    if (start != end)
        Console.Write(", ");

    Print_numbers(start + 1, end);
    
}