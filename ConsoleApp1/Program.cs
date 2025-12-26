namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"30 C = {ConvertTemperature(30, "C", "K")} K");
            Console.WriteLine($"30 C = {ConvertTemperature(100, "F", "K")} K");
            Console.WriteLine($"30 C = {ConvertTemperature(-10, "C", "F")} K");
        }

        static double ConvertTemperature(double value, string from, string to)
        {
            double celsius = from switch
            {
                "C" => value,
                "F" => (value - 32) * 5 / 9,
                "K" => value - 273.15,
                _ => throw new ArgumentException($"Неподдерживаемая единица: {from}")
            };

            return to switch
            {
                "C" => celsius,
                "F" => (celsius * 9 / 5) + 32,
                "K" => celsius + 273.15,
                _ => throw new ArgumentException($"Неподдерживаемая единица: {to}")
            };
        }
    }
}
