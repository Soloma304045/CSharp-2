using Library;
using NCalc;

class Program
{
    static void Main()
    {
        string input;
        string name;
        int[] userChoice = new int[2];
        int count;
        double upperLimit;
        double lowerLimit;
        double number;
        Func<double, double> func;
        double? result;
        List<Integral> integrals = new List<Integral>();
        Integral integralA = new Integral(x => 1 / (1 + x * x), 2, 7, "1 / (1 + x^2)");
        Integral integralB = new Integral(x => x * x, 2, 7, "x^2");
        integralA.Calculate();
        integralB.Calculate();
        integrals.Add(integralA);
        integrals.Add(integralB);
        bool endIsNear = false;
        while (!endIsNear)
        {
            Console.WriteLine("1. Задать интеграл");
            Console.WriteLine("2. Параметры интегралов");
            Console.WriteLine("3. Суммировать интегралы");
            Console.WriteLine("4. Умножение интеграла");
            Console.WriteLine("5. выход");
            input = Console.ReadLine();
            if (input != null)
            {
                userChoice[0] = int.Parse(input);
                switch (userChoice[0])
                {
                    case 1:
                        {
                            Console.WriteLine("Укажите формулу интеграла: ");
                            input = Console.ReadLine();
                            func = (x) =>
                            {
                                var expr = new Expression(input);
                                expr.Parameters["x"] = x;
                                return (double)expr.Evaluate();
                            };
                            Console.WriteLine("Укажите нижний предел: ");
                            lowerLimit = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Укажите верхний предел: ");
                            upperLimit = Convert.ToDouble(Console.ReadLine());
                            if(upperLimit < lowerLimit)
                            {
                                Console.WriteLine("Error. Wrong data, try again.");
                                break;
                            }
                            Console.WriteLine("Название функции: ");
                            name = Console.ReadLine();
                            integrals.Add(new Integral(func, lowerLimit, upperLimit, name));
                            integrals[integrals.Count-1].Calculate();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Выберите интеграл из списка:");
                            for (count = 1; count <= integrals.Count; count++)
                            {
                                Console.WriteLine($"{count} - {integrals[count-1].GetName()}");
                            }
                            userChoice[0] = int.Parse(Console.ReadLine());
                            integrals[userChoice[0]-1].Print();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Выберите интеграл из списка:");
                            for (count = 1; count <= integrals.Count; count++)
                            {
                                Console.WriteLine($"{count} - {integrals[count-1].GetName()}");
                            }
                            userChoice[0] = int.Parse(Console.ReadLine());
                            if(userChoice[0] > integrals.Count)
                            {
                                Console.WriteLine("Error. Wrong input, try again.");
                                break;
                            }

                            Console.WriteLine("Выберите второй интеграл:");
                            for (count = 1; count <= integrals.Count; count++)
                            {
                                Console.WriteLine($"{count} - {integrals[count-1].GetName()}");
                            }
                            userChoice[1] = int.Parse(Console.ReadLine());
                            if(userChoice[1] > integrals.Count)
                            {
                                Console.WriteLine("Error. Wrong input, try again.");
                                break;
                            }
                            result = integrals[userChoice[0]-1] + integrals[userChoice[1]-1];
                            Console.WriteLine($"Сумма интегралов равна {result}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Выберите интеграл из списка:");
                            for (count = 1; count <= integrals.Count; count++)
                            {
                                Console.WriteLine($"{count} - {integrals[count-1].GetName()}");
                            }
                            input = Console.ReadLine();
                            userChoice[0] = int.Parse(input);
                            if(userChoice[0] > integrals.Count)
                            {
                                Console.WriteLine("Error. Wrong input, try again.");
                                break;
                            }

                            Console.WriteLine("Введите множитель: ");
                            input = Console.ReadLine();
                            if (double.TryParse(input, out number))
                            {
                                result = integrals[userChoice[0]-1] * number;
                                Console.WriteLine($"Произведение интеграла и {userChoice[1]} равна {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error. wrong input, try again.");
                            }
                            break;
                        }
                    case 5:
                        {
                            endIsNear = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error. Wrong input, try again.\n");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Error. Null input, try again.\n");
            }
        }
    }
}
