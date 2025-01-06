using System.Diagnostics;
namespace Aufgabe_2;

public class OutputLogger : ILogger
{
    //Methode mit implementierung
    public void Log(string message)
    {
        //"Debug" class sorgt dafür, dass es im Output Fenster ausgegeben wird
        Debug.WriteLine(message);
    }
}