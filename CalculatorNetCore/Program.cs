using System;

namespace CalculatorNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Для выхода наберите Q");
                Console.WriteLine("Деление '\'\n" +
                    "Вычитание '-'\n" +
                     "Сумма '+'\n," +
                     "Умножение '*'");
                Console.WriteLine("*****************************");

            bool isProgramActive = true;
            int firstNumber, secondNumber;
            string operation;

            do
            {
                Console.WriteLine("Введите число: ");
               // firstNumber = int.Parse(Console.ReadLine());

                while (!Int32.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Введите правильные данные");
                }

                Console.WriteLine("Введите второе число: ");
                // secondNumber = int.Parse(Console.ReadLine());
              
                 while (!Int32.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Введите правильные данные");
                }

                int resultOperation;
                // char operation = Console.ReadLine();
                Console.WriteLine("введите операцию: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Результат: {0} - {1}", firstNumber, secondNumber);
                        break;
                    case "-":
                        resultOperation = firstNumber - secondNumber;
                        Console.WriteLine("Результат: {0}", resultOperation);
                        break;
                    case "*":
                        resultOperation = firstNumber * secondNumber;
                        Console.WriteLine("Результат: {0}", resultOperation);
                        break;
                    case "/":
                        resultOperation = firstNumber / secondNumber;
                        Console.WriteLine("Результат: {0}", resultOperation);
                        break;
                    default:
                        Console.WriteLine("Введите правильную операцию");
                        break;
                }

                Console.ReadLine();
            }
            while (isProgramActive);

        }

      
    }
}
