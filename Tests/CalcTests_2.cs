namespace Tests;
using Xunit;
using System;
using Library;

public class CalcTests_2
{
    private readonly Calculate calc = new Calculate();
    private readonly Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
    private readonly Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
    private readonly Integral integralC = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
    public CalcTests_2()
    {
        integralA.Solve();
        integralB.Solve();
        integralC.Solve();
    }
    [Fact]
    public void Test_1()
    {
        double result = Calculate.Sum(integralA, integralB);
        Assert.Equal(707.92, Math.Round(result, 2));
    }
    [Fact]
    public void Test_2()
    {
        double result = Calculate.Sum(integralA, integralC);
        Assert.Equal(111.99, Math.Round(result, 2));
    }
    [Fact]
    public void Test_3()
    {
        double result = Calculate.Sum(integralB, integralC);
        Assert.Equal(596.57, Math.Round(result, 2));
    }
}