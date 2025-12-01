using System;

public class Test
{
	public static void Main()
	{
		string input;
        string[] lines = File.ReadAllLines("input.txt");
		char instr;
		int amount;
		int dial=50;
        int zeros=0;
		foreach(string line in lines)
		{
			instr=line[0];
            amount=Int32.Parse(line.Remove(0,1));
            amount=amount%100;
            Console.Write($"dial: {dial} - {instr} {amount} -> ");
			if(instr=='L')
            {
                if(dial>=amount)
                {
                    dial-=amount;
                }
                else
                {
                    zeros++;
                    dial=100-(amount-dial);
                }
            }
            else
            {
                if(100-dial>=amount)
                {
                    dial+=amount;
                }
                else
                {
                    zeros++;
                    dial=amount-(100-dial);
                }
                if(dial==100){dial=0;}
            }
			
            Console.WriteLine(dial.ToString());

            if(dial==0)
            {
                zeros++;
            }
		}
        Console.WriteLine($"Zeros: {zeros}");
	}
}
