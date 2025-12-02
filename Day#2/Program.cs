using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            string[] ranges = input.Split(',');
            Int64 sum = 0;
            foreach (string range in ranges)
            {
                Console.Write($"{range} ");
                Int64 start = Int64.Parse(range.Split('-')[0]);
                Int64 end = Int64.Parse(range.Split('-')[1]);
                Console.WriteLine($"{start} -> {end}");

                for (Int64 i = start; i <= end; i++)
                {
                    //Console.Write($"{i} ");
                    var aux = i.ToString();
                    if (aux.Length % 2 == 0)
                    {
                        var firstHalf = aux.Remove(0, aux.Length / 2);
                        if (firstHalf + firstHalf == aux)
                        {
                            sum += i;
                        }
                    }

                }

            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}