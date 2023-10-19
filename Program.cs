namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unit Converter\nPlease type in your unit.\nmm = Milimetres, cm = Centimetres, m= Metres, km = Kilometres, yrd = Yards, mi = Miles");
            string? firstUnit = Console.ReadLine();

            if (firstUnit == "mm")
            {
                string mm = "Millimetres";
                Console.WriteLine($"You've chosen {mm}.\nPlease select the unit that you would like to convert {mm} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Millimetres:");

                if (secondUnit == "cm")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 10;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} centimetres");
                }
                else if (secondUnit == "m")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 1000;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} metres");
                }
                else if (secondUnit == "km")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 1000000;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "yrd")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 914.4m;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} yards");
                }
                else if (secondUnit == "mi")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 1609350;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} miles");
                }
            }
            else if (firstUnit == "cm")
            {
                string cm = "Centimetres";
                Console.WriteLine($"You've chosen {cm}.\nPlease select the unit that you would like to convert {cm} to:");

                string? secondUnit = Console.ReadLine();

                Console.WriteLine("Write measurement in Centimetres:");

                if (secondUnit == "mm")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 * 10;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} millimetres");
                }
                else if (secondUnit == "m")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 100;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} metres");
                }
                else if (secondUnit == "km")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 10000;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} kilometres");
                }
                else if (secondUnit == "yrd")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 914.4m;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} yards");
                }
                else if (secondUnit == "mi")
                {
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());

                    decimal sumConverted = num1 / 1609350;

                    Console.WriteLine($"{num1} centimetres is equal to {sumConverted} miles");
                }
            }
            else if (firstUnit == "m")
            {
                string m = "Metres";
                Console.WriteLine($"You've chosen {m}.\nPlease select the unit that you would like to convert {m} to:");
            }
            else if (firstUnit == "km")
            {
                string km = "Kilometres";
                Console.WriteLine($"You've chosen {km}.\nPlease select the unit that you would like to convert {km} to:");
            }
            else if (firstUnit == "yrd")
            {
                string yrd = "Yards";
                Console.WriteLine($"You've chosen {yrd}.\nPlease select the unit that you would like to convert {yrd} to:");
            }
            else if (firstUnit == "mi")
            {
                string mi = "Miles";
                Console.WriteLine($"You've chosen {mi}.\nPlease select the unit that you would like to convert {mi} to:");
            }
            else
            {
                Console.WriteLine("Sorry, unit not recognized. Please type in a unit from the list");
            }                
        }
    }
}