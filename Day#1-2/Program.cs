using System;

public class Test
{
	public static void Main()
	{
        string[] lines = File.ReadAllLines("input.txt");
		char instr;
		int amount;
		int dial=50;
        int zeros=0;
		foreach(string line in lines)
		{
			instr=line[0];
            amount=Int32.Parse(line.Remove(0,1));
            //Console.Write($"dial: {dial} - {instr} {amount} -> ");
			if(instr=='L')
            {
                for(int i=0;i<amount;i++)
                {
                    dial--;
                    
                    if(dial==-1)
                    {
                        
                        dial=99;
                    }
                    if(dial==0)
                    {
                        zeros++;
                        //Console.Write("Stepped ");
                    }

                    
                }
            }
            else
            {
                for(int i=0;i<amount;i++)
                {
                    dial++;
                    
                    if(dial==100)
                    {
                        
                        dial=0;
                    }
                    if(dial==0)
                    {
                        //Console.Write("Stepped ");
                        zeros++;
                    }
                    
                }

            }
			
            //Console.WriteLine($"{dial} --- zeros: {zeros}");
		}
        Console.WriteLine($"Zeros: {zeros}");
	}
}
