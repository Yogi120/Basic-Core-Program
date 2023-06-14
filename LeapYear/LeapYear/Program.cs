using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year: ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("It's a leap year");
            }

            else
            {
                Console.WriteLine("it's NOT a leap year");
            }
        }
    }
}