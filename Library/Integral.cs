namespace Library
{
    /// <summary>
    /// Представляет определенный интеграл функции.
    /// </summary>
    public class Integral
    {
        private string _funcName;
        private Func<double, double> _function;
        private double _lowerLimit;
        private double _upperLimit;
        private double? _computedValue;

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        /// <param name="function">Функция, которую нужно интегрировать.</param>
        /// <param name="lowerLimit">Нижний предел интегрирования.</param>
        /// <param name="upperLimit">Верхний предел интегрирования.</param>
        /// <param name="funcName">Название функции.</param>
        public Integral(Func<double, double> function, double lowerLimit, double upperLimit, string funcName = "unknown function")
        {
            _funcName = funcName;
            _function = function;
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
            _computedValue = null;
        }

        /// <summary>
        /// Получает название функции.
        /// </summary>
        /// <returns>Название функции.</returns>
        public string GetName()
        {
            return _funcName;
        }

        /// <summary>
        /// Получает значение функции.
        /// </summary>
        /// <returns>Значение функции.</returns>
        public double? GetValue()
        {
            return _computedValue;
        }

        /// <summary>
        /// Вычисляет значение определенного интеграла.
        /// </summary>
        /// <returns>Значение интеграла или <c>null</c>, если интеграл не вычислен.</returns>
        public double? Calculate()
        {
            double stepSize = (_upperLimit - _lowerLimit) / 1000;
            double sum = 0.0;

            for (int i = 0; i < 1000; i++)
            {
                double x = _lowerLimit + (i + 0.5) * stepSize;
                sum += _function(x);
            }
            _computedValue = sum * stepSize;
            return _computedValue;
        }

        /// <summary>
        /// Выводит информацию о функции и ее значении на консоль.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Функция: {_funcName}");
            Console.WriteLine($"Нижний предел: {_lowerLimit}");
            Console.WriteLine($"Верхний предел: {_upperLimit}");
            if (_computedValue != null)
            {
                Console.WriteLine($"Значение: {_computedValue}\n");
            }
        }
    }
}
