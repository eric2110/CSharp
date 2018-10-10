using System;
using System.Reflection;

public class Program
{
	public static void Main()
	{
		FieldInfo[] orderFieldInfo;
		Type type = typeof(Order);
		orderFieldInfo = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance
            | BindingFlags.Public);
        Console.WriteLine("\nThe fields of " + 
            "FieldInfoClass are \n");
		for(int i = 0; i < orderFieldInfo.Length; i++)
        {
            Console.WriteLine("\nName          : {0}", orderFieldInfo[i].Name);
            Console.WriteLine("Declaring Type  : {0}", orderFieldInfo[i].DeclaringType);
            Console.WriteLine("IsPublic        : {0}", orderFieldInfo[i].IsPublic);
            Console.WriteLine("MemberType      : {0}", orderFieldInfo[i].MemberType);
            Console.WriteLine("FieldType       : {0}", orderFieldInfo[i].FieldType);
            Console.WriteLine("IsFamily        : {0}", orderFieldInfo[i].IsFamily);
        }
	}	 
}

public class Order
{
	public int Id {get;set;}
	public string OrderNo {get;set;}
	public decimal Amount {get;set;}
}

