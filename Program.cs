using System;
using ConvertTemperature;

namespace TemperatureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-------------MENU----------------");
            Console.WriteLine("Fahrenheit to Celsius, Press 1");
            Console.WriteLine("Fahrenheit to Kelvin, Press 2");
            Console.WriteLine("Celsius to Fahrenheit, Press 3");
            Console.WriteLine("Celsius to Kelvin, Press 4");
            Console.WriteLine("Kelvin to Fahrenheit, Press 5");
            Console.WriteLine("Kelvin to Celsius, Press 6");
            Console.Write("What temperature do you wish to convert? ");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                
                Console.Write("You have selected Fahrenheit to Celsius. Please enter amount: ");
                double InputFatoCe = double.Parse(Console.ReadLine());
                Fahrenheit fahrenheit = new Fahrenheit(InputFatoCe, TemperatureScale.Farenheit);
                double result = fahrenheit.ConvertToCelsius();
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();

            }
            else if (input == 2)
            {
                Console.Write("You have selected Fahrenheit to Kelvin. Please enter amount: ");
                double InputFatoKe = double.Parse(Console.ReadLine());
                Fahrenheit fahrenheit = new Fahrenheit(InputFatoKe, TemperatureScale.Farenheit);
                double result = fahrenheit.ConvertToKelvin();
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();
            }
            else if (input == 3)
            {
                Console.Write("You have selected Celsius to Fahrenheit. Please enter amount: ");
                double InputCetoFa = double.Parse(Console.ReadLine());
                Celsius celsius = new Celsius(InputCetoFa, TemperatureScale.Celsius);
                double result = celsius.ConvertToFarenheit();
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();
            }
            else if (input == 4)
            {
                Console.Write("You have selected Celsius to Fahrenheit. Please enter amount: ");
                double InputCetoKe = double.Parse(Console.ReadLine());
                Celsius celsius = new Celsius(InputCetoKe, TemperatureScale.Celsius);
                double result = celsius.ConvertToKelvin();
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();

            }
            else if (input == 5)
            {
                Console.WriteLine("You have selected Kelvin to Fahrenheit. Please enter amount.");
                double InputKetoFa = double.Parse(Console.ReadLine());
                Kelvin kelvin = new Kelvin(InputKetoFa, TemperatureScale.Kelvin);
                double result = kelvin.ConvertToFarenheit();
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();


            }
            else if (input == 6)
            {
                Console.Write("You have selected Kelvin to Celsius. Please enter amount: ");
                int InputKetoCe = int.Parse(Console.ReadLine());
                Kelvin kelvin = new Kelvin(InputKetoCe, TemperatureScale.Kelvin);
                double result = kelvin.ConvertToFarenheit();
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();

            }

            Console.WriteLine("Program end! :)");
        }
    }
}
