namespace Tests;
using Xunit;
using System;
using Library;

public class CalcTests_1
{
    private readonly Calculate calc = new Calculate();
    private readonly Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
    private readonly Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
    private readonly Integral integralC = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
    public CalcTests_1()
    {
        integralA.Solve();
        integralB.Solve();
        integralC.Solve();
    }
    [Fact]
    public void Test_1()
    {
        double number = -5.13;
        double result = Calculate.Sum(integralA, number);
        Assert.Equal(106.54, Math.Round(result, 2));
    }
    [Fact]
    public void Test_2()
    {
        double number = 7.28; 
        double result = Calculate.Sum(integralB, number);
        Assert.Equal(603.53, Math.Round(result, 2));
    }
    [Fact]
    public void Test_3()
    {
        double number = 0; 
        double result = Calculate.Sum(integralC, number);
        Assert.Equal(0.32, Math.Round(result, 2));
    }
}