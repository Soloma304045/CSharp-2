using Library;
using NCalc;

class Program
{
    static void Main()
    {
        List<Integral> integrals = new List<Integral>();
        Integral integralA = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        Integral integralB = new Integral(x => x * x, 2, 7, "x^2");
        Integral integralC = new Integral(x => 1 / (x * x - 3 * x + 2), 3, 4, "1 / (x^2 - 3x + 2)");
        Integral integralD = new Integral(x => x * x * x * x * x / (x + 2), -1, 1, "x^5 / (x + 2)");
        Integral integralE = new Integral(x => Math.Sin(x) * Math.Sin(x) * Math.Sin(x), 0, Math.PI, "Sin^3(x)");
        integralA.Calculate();
        integralB.Calculate();
        integralC.Calculate();
        integralD.Calculate();
        integralE.Calculate();
        integrals.Add(integralA);
        integrals.Add(integralB);
        integrals.Add(integralC);
        integrals.Add(integralD);
        integrals.Add(integralE);
        integrals[0].Print();
        Console.WriteLine("\n");
        integrals[1].Print();
        Console.WriteLine("\n");
        integrals[2].Print();
        Console.WriteLine("\n");
        integrals[3].Print();
        Console.WriteLine("\n");
        integrals[4].Print();
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[1].GetName()} и {integrals[3].GetName()} = {Calculate.Sum(integrals[1], integrals[3])}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[2].GetName()} и {integrals[4].GetName()} = {Calculate.Sum(integrals[2], integrals[4])}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[0].GetName()} и {integrals[1].GetName()} = {integrals[0] + integrals[1]}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[3].GetName()} и {integrals[4].GetName()} = {integrals[3] + integrals[4]}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[0].GetName()} и {integrals[2].GetName()} = {integrals[0] + integrals[2]}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[1].GetName()} и {integrals[4].GetName()} = {integrals[1] + integrals[4]}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[2].GetName()} и {integrals[3].GetName()} = {integrals[2] + integrals[3]}");
        Console.WriteLine("\n");
        Console.WriteLine($"Сумма интегралов {integrals[0].GetName()} и {integrals[4].GetName()} = {integrals[0] + integrals[4]}");
        Console.WriteLine("\n");
        Console.WriteLine($"умножение интеграла {integrals[2].GetName()} на 4 = {integrals[2] * 4}");
        Console.WriteLine("\n");
        Console.WriteLine($"умножение интеграла {integrals[1].GetName()} на 7.5 = {integrals[2] * 7.5}");
        Console.WriteLine("\n");
        Console.WriteLine($"умножение интеграла {integrals[0].GetName()} на 0 = {integrals[2] * 0}");
        Console.WriteLine("\n");
        Console.WriteLine($"умножение интеграла {integrals[3].GetName()} на 12.7 = {integrals[2] * 12.7}");
        Console.WriteLine("\n");
        Console.WriteLine($"умножение интеграла {integrals[4].GetName()} на 0.15 = {integrals[2] * 0.15}");
    }
}
