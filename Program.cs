
using Task_2.Classes;

namespace Task_2
{
    internal class Program
    {
        static int input_int(string p_prompt) //Method to input integers. For this program, this is only here to provide function to the range restricted overload of this method.
        {
            //Variables
            int num;

            //Logic
            Console.Write(p_prompt); //Prompt user.
            while (!int.TryParse(Console.ReadLine(), out num)) //Takes input, loops if not a double..
            {
                Console.Clear();
                Console.WriteLine("Please input an integer."); //Error.
                Console.Write(p_prompt); //Reprompt user.
            }

            return num;
        }
        static int input_int(string p_prompt, int p_min, int p_max) //An overload of the input_int method that reprompts if the input is not in a certain range.
        {
            //Variables
            int num;

            //Logic
            do
            {
                num = input_int(p_prompt); //Calls the input_int method defined prior and passes the prompt in.
                if (num < p_min || num > p_max)
                {
                    Console.Clear();
                    Console.WriteLine($"Please input a number in the given range ({p_min} - {p_max}).");
                }
            } while (num < p_min || num > p_max); //Check if number is in the given range.

            return num;
        }
        static double input_double(string p_prompt) //Method to input doubles, this exists as a method of abstracting this logic from the main function.
        {
            //Variables
            double num;

            //Logic
            Console.Write(p_prompt); //Prompt user.
            while (!double.TryParse(Console.ReadLine(), out num)) //Takes input, loops if not a double..
            {
                Console.Clear();
                Console.WriteLine("Please input a decimal number or integer."); //Error.
                Console.Write(p_prompt); //Reprompt user.
            }

            return num;
        }
        static void summary(double p_start_temp, double p_end_temp, string p_start_measurement, string p_end_measurement) //Method to output a summary of the temperature change, this is here to make repetition easier.
        {
            if (p_start_measurement == p_end_measurement)
            {
                Console.WriteLine($"Your temperature of {p_start_temp:0.00} {p_start_measurement} is already in {p_end_measurement}, thus not needing to be converted.");
            }
            else
            {
                Console.WriteLine($"Your temperature of {p_start_temp:0.00} {p_start_measurement} translates to {p_end_temp} {p_end_measurement}.");
            }
        }
        static void Main(string[] args)
        {
            //MOD008904 010-2 Task_2 - Temperature Converter
            //Variables
            int convert_from; //Variable to store the user's menu choice to convert from (not initialised as it does not need to be).
            int convert_to; //Variable to store the user's menu choice to convert to (not initialised as it does not need to be).
            double temperature_in; //Variable to store the temperature when its inputted.

            //Logic
            convert_from = input_int("What type of temperature are you trying to convert from?\n1. Celsius\n2. Fahrenheit\n3. Kelvin\nChoice: ", 1, 3);
            Console.Clear();

            temperature_in = input_double("Temperature to convert: ");
            Console.Clear();

            convert_to = input_int("What type of temperature are you trying to convert to?\n1. Celsius\n2. Fahrenheit\n3. Kelvin\nChoice: ", 1, 3);
            Console.Clear();

            switch (convert_from) //Check which input the user gave.
            {
                case 1: //Celsius
                    Celsius celsius = new Celsius(temperature_in); //Create object to convert the temperature, with its respective type.
                    switch (convert_to)
                    {
                        case 1:
                            summary(celsius.as_celsius(), celsius.as_celsius(), celsius.Unit, "Celsius");
                            break;
                        case 2:
                            summary(celsius.as_celsius(), celsius.as_fahrenheit(), celsius.Unit, "Fahrenheit");
                            break;
                        case 3:
                            summary(celsius.as_celsius(), celsius.as_kelvin(), celsius.Unit, "Kelvin");
                            break;
                        default: //While theoretically impossible to recieve an input that isn't 1, 2, or 3, this is here to catch if one gets through the error handling on input_int().
                            Console.WriteLine("Error invalid input.");
                            break;
                    }
                    break;

                case 2: //Fahrenheit
                    Fahrenheit fahrenheit = new Fahrenheit(temperature_in); //Create object to convert the temperature, with its respective type.
                    switch (convert_to)
                    {
                        case 1:
                            summary(fahrenheit.as_fahrenheit(), fahrenheit.as_celsius(), fahrenheit.Unit, "Celsius");
                            break;
                        case 2:
                            summary(fahrenheit.as_fahrenheit(), fahrenheit.as_fahrenheit(), fahrenheit.Unit, "Fahrenheit");
                            break;
                        case 3:
                            summary(fahrenheit.as_fahrenheit(), fahrenheit.as_kelvin(), fahrenheit.Unit, "Kelvin");
                            break;
                        default: //While theoretically impossible to recieve an input that isn't 1, 2, or 3, this is here to catch if one gets through the error handling on input_int().
                            Console.WriteLine("Error invalid input.");
                            break;
                    }
                    break;

                case 3: //Kelvin
                    Kelvin kelvin = new Kelvin(temperature_in); //Create object to convert the temperature, with its respective type.
                    switch (convert_to)
                    {
                        case 1:
                            summary(kelvin.as_kelvin(), kelvin.as_celsius(), kelvin.Unit, "Celsius");
                            break;
                        case 2:
                            summary(kelvin.as_kelvin(), kelvin.as_fahrenheit(), kelvin.Unit, "Fahrenheit");
                            break;
                        case 3:
                            summary(kelvin.as_kelvin(), kelvin.as_kelvin(), kelvin.Unit, "Kelvin");
                            break;
                        default: //While theoretically impossible to recieve an input that isn't 1, 2, or 3, this is here to catch if one gets through the error handling on input_int().
                            Console.WriteLine("Error invalid input.");
                            break;
                    }
                    break;

                default: //While theoretically impossible to recieve an input that isn't 1, 2, or 3, this is here to catch if one gets through the error handling on input_int().
                    Console.WriteLine("Error, invalid input.");
                    break;
            }
        }
    }
}
