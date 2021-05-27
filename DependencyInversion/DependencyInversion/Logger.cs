namespace DependencyInversion
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine($"Write to the console: {message}");
        }
    }
}
