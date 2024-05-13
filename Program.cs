using System.Windows.Markup;

namespace SwitchMoodle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pick a number between 1 and 7, if not press '0' to exit!");
                var NumberInput = Console.ReadLine();
                if (NumberInput == "0") break;
                switch (NumberInput)
                {
                    case "1":
                        Console.WriteLine("Monday");
                        break;
                    case "2":
                        Console.WriteLine("Tuesday");
                        break;
                    case "3":
                        Console.WriteLine("Wednesday");
                        break;
                    case "4":
                        Console.WriteLine("Thursday");
                        break;
                    case "5":
                        Console.WriteLine("Friday");
                        break;
                    case "6":
                        Console.WriteLine("Saturday");
                        break;
                    case "7":
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Not able to follow simple instructions?");
                        break;
                }
            }
        }
    }
}
