using System;
					
public class Program
{
	public static void Main()
	{
        ///
        Console.WriteLine("***CSharp6 ?. Operator Left Side Null Evaluated Once Operator Demo***");
		var cat = new Cat {Friend = new Cat()};
        Console.WriteLine(cat?.Friend.Mew());
        Console.WriteLine(cat?.Friend?.Friend?.Mew() ?? "Null");
        Console.WriteLine(cat?.Friend?.Friend?.TailLength ?? 0);
	}
}

public class Cat
{
    public int TailLength { get; set; } = 4;

    public Cat Friend { get; set; }

    public string Mew() { return "Mew!"; }
}