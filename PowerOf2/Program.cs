namespace PowerOf2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int user = Convert.ToInt32(Console.ReadLine());
            int value = 2;
            for (int power = 0; power <= user; power++)
            {
                if (user > 31)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");
                }

            }

        }
    }
}