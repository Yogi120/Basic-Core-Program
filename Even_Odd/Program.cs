namespace Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}