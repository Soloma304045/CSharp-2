namespace Library
{
    public class Calculate
    {
        /// <summary>
        /// Метод сложения для интеграла и числа.
        /// </summary>
        /// <param name="integral">Интеграл.</param>
        /// <param name="number">Число.</param>
        /// <returns>Сумма значений интеграла и числа.</returns>
        public static double? Sum(Integral integral, double number)
        {
            return integral.GetValue() + number;
        }

        /// <summary>
        /// Метод сложения для интегралов.
        /// </summary>
        /// <param name="a">Первый интеграл.</param>
        /// <param name="b">Второй интеграл.</param>
        /// <returns>Сумма значений интегралов.</returns>
        public static double? Sum(Integral a, Integral b)
        {
            return a.GetValue() + b.GetValue();
        }

        /// <summary>
        /// Метод умножения для интеграла и числа.
        /// </summary>
        /// <param name="integral">Интеграл.</param>
        /// <param name="number">Число.</param>
        /// <returns>Результат умножения значения интеграла на число.</returns>
        public static double? Mul(Integral integral, double number)
        {
            return integral.GetValue() * number;
        }

        /// <summary>
        /// Метод умножения для интегралов.
        /// </summary>
        /// <param name="a">Первый интеграл.</param>
        /// <param name="b">Второй интеграл.</param>
        /// <returns>Результат умножения значения интегралов.</returns>
        public static double? Mul(Integral a, Integral b)
        {
            return a.GetValue() * b.GetValue();
        }
    }
}