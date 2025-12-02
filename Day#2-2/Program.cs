using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input2.txt");
            string[] ranges = input.Split(',');
            Int64 sum = 0;
            foreach (string range in ranges)
            {
                //Console.Write($"{range} ");
                Int64 start = Int64.Parse(range.Split('-')[0]);
                Int64 end = Int64.Parse(range.Split('-')[1]);
                //Console.WriteLine($"{start} -> {end}");

                for (Int64 i = start; i <= end; i++)
                {
                    string aux=i.ToString();
                    for(int j=1;j<=aux.Length/2;j++)
                    {
                        string seq=aux.Remove(j);
                        //Console.Write($"seq: {seq} ");
                        string aux3="";
                        for(int k=0;k<aux.Length/j;k++)
                        {
                            aux3+=seq;
                        }
                        //Console.WriteLine($" ; combined: {aux3} == {i.ToString()} {aux3==i.ToString()}");
                        if(aux3==i.ToString())
                        {
                            j=aux.Length;
                            sum+=i;
                        }
                        
                    }

                }

            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}