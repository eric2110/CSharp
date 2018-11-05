using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class Program
{
    public static void Main()
    {
        Task t = AsyncWithTPL();
        t.Wait();
        t = AsyncWithAwait();
        t.Wait();
    }

    static Task AsyncWithTPL()
    {
        Task<string> task1 = GetInfoAsync("Task 1");

        Task task2 = task1.ContinueWith(task =>
          Console.WriteLine(task1.Result), TaskContinuationOptions.NotOnFaulted);
        Task task3 = task1.ContinueWith(task =>
          Console.WriteLine(task1.Exception.InnerException), TaskContinuationOptions.OnlyOnFaulted);
        return Task.WhenAny(task2, task1);

    }

    async static Task AsyncWithAwait()
    {
        try
        {
            string result = await GetInfoAsync("Task 4");
            Console.WriteLine(result);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    async static Task<string> GetInfoAsync(string name)
    {

        await Task.Delay(TimeSpan.FromSeconds(2));
        //throw  new Exception("拋出異常信息！"); 

        return string.Format(" Task {0} 正在運行在線程 ID={1}上。這個工作線程是否是線程池中的線程：{2}", name,
Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsThreadPoolThread);

    }
}