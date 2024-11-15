namespace Tests;
using Xunit;
using System;
using Library;

public class CalcTests_5
{
    private readonly Calculate calc = new Calculate();
    private readonly Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
    private readonly Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
    private readonly Integral integralC = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
    public CalcTests_5()
    {
        integralA.Solve();
        integralB.Solve();
        integralC.Solve();
    }
    [Fact]
    public void Test_1()
    {
        double result = Calculate.Sum(integralA, double.PositiveInfinity);
        Assert.Equal(double.PositiveInfinity, Math.Round(result, 2));
    }
    [Fact]
    public void Test_2()
    {
        double result = Calculate.Mul(integralA, double.NegativeInfinity);
        Assert.Equal(double.NegativeInfinity, Math.Round(result, 2));
    }
    [Fact]
    public void Test_3()
    {
        double number = -1;
        double result = Calculate.Mul(integralB, number);
        Assert.Equal(-596.25, Math.Round(result, 2));
    }
}