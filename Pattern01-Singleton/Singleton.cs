using System;
using System.Reflection;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("***Singleton Pattern Demo***\n");
        Console.WriteLine(Singleton.MyInt);

        Console.WriteLine("***Singleton Pattern Demo***\n");
        //Console.WriteLine(Singleton.MyInt);
        // Private Constructor.So,we cannot use 'new' keyword.
        Console.WriteLine("Trying to create instance s1.");
        Singleton s1 = Singleton.Instance;
        Console.WriteLine("Trying to create instance s2.");
        Singleton s2 = Singleton.Instance;
        if (s1.Equals(s2))
        {
            Console.WriteLine("Only one instance exists.");
        }
        else
        {
            Console.WriteLine("Different instances exist.");
        }

    }
}

public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();
    private int numberOfInstances = 0;
    //Private constructor is used to prevent
    //creation of instances with 'new' keyword outside this class
    private Singleton()
    {
        Console.WriteLine("Instantiating inside the private constructor.");
        numberOfInstances++;
        Console.WriteLine("Number of instances ={0}", numberOfInstances);
    }

    public static Singleton Instance
    {
        get
        {
            Console.WriteLine("We already have an instance now.Use it.");
            return instance;
        }
    }

    public static int MyInt = 25;
}


public class SingletonInsingleThreaded
{
    private static SingletonInsingleThreaded instance;
    private SingletonInsingleThreaded() { }
    public static SingletonInsingleThreaded Instance
    {
        get
        {
			//This will create another new instance in multithread.
            if (instance == null)
            {
                instance = new SingletonInsingleThreaded();
            }
            return instance;
        }
    }
}