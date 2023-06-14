namespace Quotient_Remainder
{
    public class Program
    {
        static void Main(string[] args)
        {
            int remainder;

            Console.WriteLine("Enter the Dividen");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Divisor");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = (dividend / divisor);
            remainder = (dividend % divisor);


            Console.WriteLine("Qutoient is: " + quotient );
            Console.WriteLine("Remainder is: " + remainder);


        }
    }
}