using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("***String Interpolation Demo***");
		StringInterpolation obj = new StringInterpolation("Eric", null);
		Console.WriteLine($"{nameof(obj)} {obj.FullName}" );
	}
}

public class StringInterpolation
{
	public string FirstName {get;set;}
	public string LastName {get;set;}
	public string FullName => $"{FirstName} {LastName}";
	
	public StringInterpolation(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}	
}