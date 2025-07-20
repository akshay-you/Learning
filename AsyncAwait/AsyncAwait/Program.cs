public class AsyncAwait
{
    static async Task Main()
    {
        //var mt1 = Method1();
        //var mt2 = Method2();

        await Method2();
        Console.WriteLine("Main Method End");
        //Console.ReadKey();
    }

    public static async Task Method1()
    {
        Console.WriteLine("Method 1 started");
        await Task.Delay(2000);
        Console.WriteLine("Method 1 ending");
    }

    public static async Task Method2()
    {
        Console.WriteLine("method 2 started : " + Thread.CurrentThread.ManagedThreadId);
        await Task.Delay(1000);
        Console.WriteLine("method 2 ending: " + Thread.CurrentThread.ManagedThreadId);
    }
}