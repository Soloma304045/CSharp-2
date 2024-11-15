namespace Tests;
using Xunit;
using System;
using Library;

public class CalcTests_3
{
    private readonly Calculate calc = new Calculate();
    private readonly Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
    private readonly Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
    private readonly Integral integralC = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
    public CalcTests_3()
    {
        integralA.Solve();
        integralB.Solve();
        integralC.Solve();
    }
    [Fact]
    public void Test_1()
    {
        double number = 0;
        double result = Calculate.Mul(integralA, number);
        Assert.Equal(0, Math.Round(result, 2));
    }
    [Fact]
    public void Test_2()
    {
        double number = 0.17;
        double result = Calculate.Mul(integralB, number);
        Assert.Equal(101.36, Math.Round(result, 2));
    }
    [Fact]
    public void Test_3()
    {
        double number = -48.53;
        double result = Calculate.Mul(integralC, number);
        Assert.Equal(-15.61, Math.Round(result, 2));
    }
}