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

                if (secondUnit == "cm")
                {
                    decimal sumConverted = num1 / 10;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} centimetres");
                }
                
                else if (secondUnit == "m")
                {
                    decimal sumConverted = num1 / 1000;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} metres");
                }
              
                else if (secondUnit == "km")
                {

                    decimal sumConverted = num1 / 1000000;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "yrd")
                {

                    decimal sumConverted = num1 / 914.4m;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} yards");
                }
                else if (secondUnit == "mi")
                {

                    decimal sumConverted = num1 / 1609350;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} miles");
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

                if (secondUnit == "mm")
                {
                    decimal sumConverted = num1 * 10;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} millimetres");
                }
                else if (secondUnit == "m")
                {
                    decimal sumConverted = num1 / 100;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} metres");
                }
                else if (secondUnit == "km")
                {
                    decimal sumConverted = num1 / 10000;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "yrd")
                {
                    decimal sumConverted = num1 / 91.44m;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} yards");
                }
                else if (secondUnit == "mi")
                {
                    decimal sumConverted = num1 / 160900;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} miles");
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

                if (secondUnit == "mm")
                {
                    decimal sumConverted = num1 * 1000;

                    Console.WriteLine($"{num1} metres is equal to {sumConverted} millimetres");
                }
                else if (secondUnit == "cm")
                {
                    decimal sumConverted = num1 * 100;

                    Console.WriteLine($"{num1} metres is equal to {sumConverted} metres");
                }
                else if (secondUnit == "km")
                {
                    decimal sumConverted = num1 / 1000;

                    Console.WriteLine($"{num1} metres is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "yrd")
                {
                    decimal sumConverted = num1 * 1.094m;

                    Console.WriteLine($"{num1} metres is equal to {sumConverted} yards");
                }
                else if (secondUnit == "mi")
                {
                    decimal sumConverted = num1 / 1609m;

                    Console.WriteLine($"{num1} metres is equal to {sumConverted} miles");
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

                if (secondUnit == "mm")
                {
                    decimal sumConverted = num1 * 1000000;

                    Console.WriteLine($"{num1} kilometres is equal to {sumConverted} millimetres");
                }
                else if (secondUnit == "cm")
                {
                    decimal sumConverted = num1 * 100000;

                    Console.WriteLine($"{num1} kilometres is equal to {sumConverted} metres");
                }
                else if (secondUnit == "m")
                {
                    decimal sumConverted = num1 * 1000;

                    Console.WriteLine($"{num1} kilometres is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "yrd")
                {
                    decimal sumConverted = num1 * 1093.61m;

                    Console.WriteLine($"{num1} kilometres is equal to {sumConverted} yards");
                }
                else if (secondUnit == "mi")
                {
                    decimal sumConverted = num1 / 1.609m;

                    Console.WriteLine($"{num1} kilometres is equal to {sumConverted} miles");
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

                if (secondUnit == "mm")
                {
                    decimal sumConverted = num1 * 914.4m;

                    Console.WriteLine($"{num1} yards is equal to {sumConverted} millimetres");
                }
                else if (secondUnit == "cm")
                {
                    decimal sumConverted = num1 * 91.44m;

                    Console.WriteLine($"{num1} yards is equal to {sumConverted} centimetres");
                }
                else if (secondUnit == "m")
                {
                    decimal sumConverted = num1 / 1.094m;

                    Console.WriteLine($"{num1} yards is equal to {sumConverted} metres");
                }
                else if (secondUnit == "km")
                {
                    decimal sumConverted = num1 / 1094m;

                    Console.WriteLine($"{num1} yards is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "mi")
                {
                    decimal sumConverted = num1 / 1760m;

                    Console.WriteLine($"{num1} yards is equal to {sumConverted} miles");
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

                if (secondUnit == "mm")
                {
                    decimal sumConverted = num1 * 1.609000000m;

                    Console.WriteLine($"{num1} miles is equal to {sumConverted} millimetres");
                }
                else if (secondUnit == "cm")
                {       
                    decimal sumConverted = num1 * 160900;

                    Console.WriteLine($"{num1} miles is equal to {sumConverted} centimetres");
                }
                else if (secondUnit == "m")
                {
                    decimal sumConverted = num1 * 1609;

                    Console.WriteLine($"{num1} miles is equal to {sumConverted} metres");
                }
                else if (secondUnit == "km")
                {
                    decimal sumConverted = num1 * 1.60934m;

                    Console.WriteLine($"{num1} miles is equal to {sumConverted} km");
                }
                else if (secondUnit == "yrd")
                {
                    decimal sumConverted = num1 * 1760;

                    Console.WriteLine($"{num1} miles is equal to {sumConverted} yards");
                }
            }
            else
            {
                //Console.WriteLine($"{num1} miles is equal to {sumConverted} yards");
                Console.WriteLine("Sorry, unit not recognized. Please type in a unit from the list");
            }
        }
    }
}