// Вычисление факториала

double Factorial(int n) // для больших чисел используют double
{
    if (n==1) return 1;
    else return n* Factorial(n-1);
}
Console.WriteLine(Factorial(5));
