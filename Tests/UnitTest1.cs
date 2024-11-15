namespace Tests;
using XUnit

public class UnitTest1
{
    [Fact]
    public void SumIntNumTest_1()
    {
        var calculate = new Calculate;
        Integral integral = new Integral(x => x * x, 2, 7, "x^2");
        number = -5.13; 
        double result = calculate.Sum(integral, number);
        Assert.Equal((111 + 2 / 3 - 5.13), result);
    }
    [Fact]
    public void SumIntNumTest_2()
    {
        var calculate = new Calculate;
        Integral integral = new Integral(x => x * x * x, 2, 7, "x^3");
        number = 7.28; 
        double result = calculate.Sum(integral, number);
        Assert.Equal(603.53, result);
    }
    [Fact]
    public void SumIntNumTest_3()
    {
        var calculate = new Calculate;
        Integral integral = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        number = 0; 
        double result = calculate.Sum(integral, number);
        Assert.Equal((Math.Atan(7) - Math.Atan(2)), result);
    }
    [Fact]
    public void SumIntIntTest_1()
    {
        var calculate = new Calculate;
        Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
        Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
        double result = calculate.Sum(integralA, integralB);
        Assert.Equal((111 + 2 / 3 + 596.25), result);
    }
    [Fact]
    public void SumIntIntTest_2()
    {
        var calculate = new Calculate;
        Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
        Integral integralB = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        double result = calculate.Sum(integralA, integralB);
        Assert.Equal((111 + 2 / 3 + Math.Atan(7) - Math.Atan(2)), result);
    }
    [Fact]
    public void SumIntIntTest_3()
    {
        var calculate = new Calculate;
        Integral integralA = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
        double result = calculate.Sum(integralA, integralB);
        Assert.Equal((596.25 + Math.Atan(7) - Math.Atan(2)), result);
    }
    [Fact]
    public void MulIntNumTest_1()
    {
        var calculate = new Calculate;
        Integral integral = new Integral(x => x * x, 2, 7, "x^2");
        number = 0.17; 
        double result = calculate.Mul(integral, number);
        Assert.Equal(((111 + 2 / 3) * 0.17), result);
    }
    [Fact]
    public void MulIntNumTest_2()
    {
        var calculate = new Calculate;
        Integral integral = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        number = -48.32; 
        double result = calculate.Mul(integral, number);
        Assert.Equal(((Math.Atan(7) - Math.Atan(2)) * (-48.32)), result);
    }
    [Fact]
    public void MulIntNumTest_3()
    {
        var calculate = new Calculate;
        Integral integral = new Integral(x => x * x * x, 2, 7, "x^3");
        number = 0; 
        double result = calculate.Mul(integral, number);
        Assert.Equal(0, result);
    }
    [Fact]
    public void MulIntIntTest_1()
    {
        var calculate = new Calculate;
        Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
        Integral integralB = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        double result = calculate.Mul(integralA, integralB);
        Assert.Equal(((111 + 2 / 3) * (Math.Atan(7) - Math.Atan(2))), result);
    }
    [Fact]
    public void MulIntIntTest_2()
    {
        var calculate = new Calculate;
        Integral integralA = new Integral(x => x * x, 2, 7, "x^2");
        Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
        double result = calculate.Mul(integralA, integralB);
        Assert.Equal((596.25 * (111 + 2 / 3)), result);
    }
    [Fact]
    public void MulIntIntTest_3()
    {
        var calculate = new Calculate;
        Integral integralA = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        Integral integralB = new Integral(x => x * x * x, 2, 7, "x^3");
        double result = calculate.Mul(integralA, integralB);
        Assert.Equal((596.25 * (Math.Atan(7) - Math.Atan(2))), result);
    }
}