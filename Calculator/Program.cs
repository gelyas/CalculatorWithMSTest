using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Program
    {

        static void Main(string[] args)
        {
            //TestPlayed tests = new TestPlayed(); //Тест приложения, такой вариант тоже правильный, но муторный.
            //tests.TestStart();

            Program.StartCalc();

            //string GetMessage() => "I"; можно так вернуть значение

            //string GetMessage2() а можно так
            //{
            //    return "Love";
            //}
        }

        internal static void StartCalc()
        {
            string firstNumber;
            string secondNumber;
            string operation;
            float result;


            try
            {
                Console.WriteLine("Введите число 1:");
                firstNumber = Console.ReadLine();

                Console.WriteLine("Какую операцию применим к числам:");
                operation = Console.ReadLine();

                Console.WriteLine("Введите число 2:");
                secondNumber = Console.ReadLine();

                Check check = new Check();
                check.CheckNull(operation, secondNumber);

                Calc calc = new Calc();
                result = calc.CountNum(firstNumber, secondNumber, operation); //высчитывание результата
                Console.WriteLine(result); //вывод результата

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            StartCalc();
        }


    }
}
