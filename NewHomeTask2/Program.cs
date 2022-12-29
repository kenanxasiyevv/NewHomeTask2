namespace NewHomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int number = int.Parse(Console.ReadLine());
            int r;
            int count = 0;
            while (number >= 9)
            {
                r = number % 10;
                number /= 10;
                if (r == 0)
                    count++;
            }Console.WriteLine(count);
        }
    }
}