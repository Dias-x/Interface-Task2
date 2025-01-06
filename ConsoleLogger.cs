namespace Aufgabe_2;

public class ConsoleLogger : ILogger
{
    
    //Methode mit implementierung
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}