Console.Write("Введите целое число N (>2): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 2)
{
    Console.WriteLine("N должно быть больше 2!");
    return;
}
Console.Write("Введите значение A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение B: ");
double B = Convert.ToDouble(Console.ReadLine());
if (A >= B)
{
    Console.WriteLine("A должно быть меньше B");
    return;
}
double H = (B - A) / (N - 1);
Console.WriteLine($"Значения функции F в {N} точках:");
for (int i = 0; i < N; i++)
{
    double X = A + i * H;
    double F_X = 1 - Math.Sin(X);
    Console.WriteLine($"F({X}) = {F_X}");
}