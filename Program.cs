using System.Collections;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unit Converter\nPlease type in your unit.\nmm = Milimetres, cm = Centimetres, m= Metres, km = Kilometres, yrd = Yards, mi = Miles");

            string? firstUnit = Console.ReadLine();

            decimal num1 = 0;

            //Converting from Millimetres to other units
            if (firstUnit == "mm")
            {
                string mm = "Millimetres";
                Console.WriteLine($"You've chosen {mm}.\nPlease select the unit that you would like to convert {mm} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Millimetres:");

                num1 = Convert.ToDecimal(Console.ReadLine());

                switch (secondUnit)
                {
                    case "cm":
                        Console.WriteLine($"{num1} millimetres is equal to {num1 / 10} centimetres");
                        break;
                    case "m":
                        Console.WriteLine($"{num1} millimetres is equal to {num1 / 1000} metres");
                        break;
                    case "km":
                        Console.WriteLine($"{num1} millimetres is equal to {num1 / 1000000} kilometres");
                        break;
                    case "yrd":
                        Console.WriteLine($"{num1} millimetres is equal to {num1 / 914.4m} yards");
                        break;
                    case "mi":
                        Console.WriteLine($"{num1} millimetres is equal to {num1 / 1609350} miles");
                        break;
                }
            }
            // Converting from Centimetres to other units
            else if (firstUnit == "cm")
            {
                string cm = "Centimetres";
                Console.WriteLine($"You've chosen {cm}.\nPlease select the unit that you would like to convert {cm} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Centimetres:");

                num1 = Convert.ToDecimal(Console.ReadLine());

                switch (secondUnit)
                {
                    case "mm":
                        Console.WriteLine($"{num1} centimetres is equal to {num1 * 10} millimetres");
                        break;
                    case "m":
                        Console.WriteLine($"{num1} centimetres is equal to {num1 / 100} metres");
                        break;
                    case "km":
                        Console.WriteLine($"{num1} centimetres is equal to {num1 / 10000} kilometres");
                        break;
                    case "yrd":
                        Console.WriteLine($"{num1} centimetres is equal to {num1 / 91.44m} yards");
                        break;
                    case "mi":
                        Console.WriteLine($"{num1} centimetres is equal to {num1 / 160900} miles");
                        break;
                }
            }
            //Converting from Metres to other units
            else if (firstUnit == "m")
            {
                string m = "Metres";
                Console.WriteLine($"You've chosen {m}.\nPlease select the unit that you would like to convert {m} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Metres:");

                num1 = Convert.ToDecimal(Console.ReadLine());

                switch (secondUnit)
                {
                    case "mm":
                        Console.WriteLine($"{num1} metres is equal to {num1 * 1000} millimetres");
                        break;
                    case "cm":
                        Console.WriteLine($"{num1} metres is equal to {num1 * 100} centimetres");
                        break;
                    case "km":
                        Console.WriteLine($"{num1} metres is equal to {num1 / 1000} kilometres");
                        break;
                    case "yrd":
                        Console.WriteLine($"{num1} metres is equal to {num1 * 1.094m} yards");
                        break;
                    case "mi":
                        Console.WriteLine($"{num1} metres is equal to {num1 / 1609m} miles");
                        break;
                }
            }
            // Converting from Kilometres to other units
            else if (firstUnit == "km")
            {
                string km = "Kilometres";
                Console.WriteLine($"You've chosen {km}.\nPlease select the unit that you would like to convert {km} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Kilometres:");

                num1 = Convert.ToDecimal(Console.ReadLine());

                switch (secondUnit)
                {
                    case "mm":
                        Console.WriteLine($"{num1} kilometres is equal to {num1 * 1000000} millimetres");
                        break;
                    case "cm":
                        Console.WriteLine($"{num1} kilometres is equal to {num1 * 100000} centimetres");
                        break;
                    case "m":
                        Console.WriteLine($"{num1} kilometres is equal to {num1 * 1000} metres");
                        break;
                    case "yrd":
                        Console.WriteLine($"{num1} kilometres is equal to {num1 * 1093.61m} yards");
                        break;
                    case "mi":
                        Console.WriteLine($"{num1} kilometres is equal to {num1 / 1.609m} miles");
                        break;
                }
            }
            // Converting from Yards to other units
            else if (firstUnit == "yrd")
            {
                string yrds = "Yards";
                Console.WriteLine($"You've chosen {yrds}.\nPlease select the unit that you would like to convert {yrds} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Yards:");

                num1 = Convert.ToDecimal(Console.ReadLine());

                switch (secondUnit)
                {
                    case "mm":
                        Console.WriteLine($"{num1} yards is equal to {num1 * 914.4m} millimetres");
                        break;
                    case "cm":
                        Console.WriteLine($"{num1} yards is equal to {num1 * 91.44m} centimetres");
                        break;
                    case "m":
                        Console.WriteLine($"{num1} yards is equal to {num1 / 1.094m} metres");
                        break;
                    case "km":
                        Console.WriteLine($"{num1} yards is equal to {num1 / 1094m} kilometres");
                        break;
                    case "mi":
                        Console.WriteLine($"{num1} yards is equal to {num1 / 1760m} miles");
                        break;
                }
            }
            // Converting from Miles to other units
            else if (firstUnit == "mi")
            {
                string mi = "Miles";
                Console.WriteLine($"You've chosen {mi}.\nPlease select the unit that you would like to convert {mi} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Miles:");

                num1 = Convert.ToDecimal(Console.ReadLine());

                switch (secondUnit)
                {
                    case "mm":
                        Console.WriteLine($"{num1} miles is equal to {num1 * 1.609000000m} millimetres");
                        break;
                    case "cm":
                        Console.WriteLine($"{num1} miles is equal to {num1 * 160900} centimetres");
                        break;
                    case "m":
                        Console.WriteLine($"{num1} miles is equal to {num1 * 1609} metres");
                        break;
                    case "km":
                        Console.WriteLine($"{num1} miles is equal to {num1 * 1.60934m} km");
                        break;
                    case "yrd":
                        Console.WriteLine($"{num1} miles is equal to {num1 * 1760} yards");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Sorry, unit not recognized. Please type in a unit from the list");
            }

        }
    }
}