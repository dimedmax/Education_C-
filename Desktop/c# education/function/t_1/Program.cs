double Calculate_formula(int a, int b, int c, int d)
{

    double numenator = a * b;
    int denominator = c + d;
    double result = numenator / denominator;
    return result;
}

double result = Calculate_formula(1, 2, 3, 4);
Console.WriteLine(result);