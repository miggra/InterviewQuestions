using System.Text;

class Program
{
    const int MAX_THREAD_COUNT = 42;
    private static StringBuilder stringBuilder = new StringBuilder();

    public static async Task Main()
    {
        Task[] myTasks = new Task[MAX_THREAD_COUNT];
        for (int i = 0; i < MAX_THREAD_COUNT; i++)
        {
            myTasks[i] = (MyTestMethod(i));
        }
        Task.WaitAll(myTasks);
        Console.WriteLine(stringBuilder);
    }

    public static async Task MyTestMethod(int threadNum)
    {
        stringBuilder.AppendLine($"Я поток {threadNum} стартовал");
        await Task.Delay(1000);
        stringBuilder.AppendLine($"Я поток {threadNum} завершился");
    }
}