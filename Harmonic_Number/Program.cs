namespace Harmonic_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int count = 1; count <= number; count++)
            {
                Console.Write("1/{0} + ", count);
            }
        }
    }
}