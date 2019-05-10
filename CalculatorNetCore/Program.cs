using System;

namespace CalculatorNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.BackgroundColor = ConsoleColor.Green;
  Console.WriteLine("Инструкция приложения калькулятор");
  Console.WriteLine("\tДеление '/'\n" +
                    "\tВычитание '-'\n" +
                     "\tСумма '+'\n" +
                     "\tУмножение '*'\n");


                Console.WriteLine("*****************************\n");


            bool isProgramActive = true;
            int firstNumber, secondNumber;
            string operation;

            do
            {
                Console.Write("Введите число: ");
               // firstNumber = int.Parse(Console.ReadLine());

                while (!Int32.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Введите правильные данные");
                    Console.Write("Введите первое число: ");
                }

                Console.Write("Введите второе число: ");
                // secondNumber = int.Parse(Console.ReadLine());
              
                 while (!Int32.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Введите правильные данные");
                    Console.Write("Введите второе число: ");
                }

                int resultOperation;
                // char operation = Console.ReadLine();
                Console.Write("введите операцию: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Результат: {0} - {1}", firstNumber, secondNumber);
                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                        break;
                    case "-":
                        resultOperation = firstNumber - secondNumber;
                        Console.WriteLine("Результат: {0}", resultOperation);
                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                        break;
                    case "*":
                        resultOperation = firstNumber * secondNumber;
                        Console.WriteLine("Результат: {0}", resultOperation);
                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                        break;
                    case "/":
                        resultOperation = firstNumber / secondNumber;
                        Console.WriteLine("Результат: {0}", resultOperation);
                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                        break;
                    default:
                     //   if(operation != "-" || operation != "+" || operation != "*" || operation!= "/")
                        Console.WriteLine("Введите правильную операцию");

                        break;
                }

                Console.ReadLine();
            }
            while (isProgramActive);

        }

      
    }
}
