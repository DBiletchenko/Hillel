namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}