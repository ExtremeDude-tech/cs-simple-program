using System;
					
public class Program
{
	public static void Main()
	{	
	    Console.Title = "C# Example";
		Console.WriteLine("Enter the code:");
		int age = Convert.ToInt32(Console.ReadLine()); 
		int code = 500;
		if (age==code) 
		{
			Console.WriteLine("The code is correct!");
		}
		else 
		{
		    Console.WriteLine("The code is incorrect\nThe value should've be: [" + code + "]");
		}
	}
}
