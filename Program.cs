namespace UnitConventer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unit Conventer\nPlease type in your unit.\nmm = Milimetres, cm = Centimetres, m= Metres, km = Kilometres, yrd = Yards, mi = Miles");
            string? firstUnit = Console.ReadLine();

            if (firstUnit == "mm")
            {
                string mm = "Millimetres";
                Console.WriteLine($"You've chosen {mm}.\nPlease select the unit that you would like to convert {mm} to:");

                string? secondUnit = Console.ReadLine();
                if (secondUnit == "cm")
                {
                    Console.WriteLine("Write measurement in Millimetres:");
                    decimal num1 = Convert.ToInt32(Console.ReadLine());

                    decimal sumConverted = num1 / 10;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} centimetres");
                }
                else if (secondUnit == "m")
                {
                    Console.WriteLine("Write measurement in Millimetres:");
                    decimal num1 = Convert.ToInt32(Console.ReadLine());

                    decimal sumConverted = num1 / 1000;

                    Console.WriteLine($"{num1} millimetres is equal to {sumConverted} metres");
                }
            }
            else if (firstUnit == "cm")
            {
                string cm = "Centimetres";
                Console.WriteLine($"You've chosen {cm}.\nPlease select the unit that you would like to convert {cm} to:");
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

           /* string? secondUnit = Console.ReadLine();
            
            if (firstUnit == "mm" && secondUnit == "cm")
            {
                Console.WriteLine("You're converting Millimetres to Centimetres");
            }
           */
                
        }
    }
}