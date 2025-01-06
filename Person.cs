namespace Aufgabe_2;

public class Person
{
    /*Interface Datenspeicher = new "class" Outputlogger
    damit wird in von der Klasse "OutputLogger" abgerufen*/
    private ILogger logger = new OutputLogger();
    
    /* Damit wird es von der Klasse "ConsoleLogger" abgerufen
     "private ILogger logger = new ConsoleLogger();" */

    //Datenspeicher private
    private string name;

    //Datenspeicher in public umwandeln 
    public string Name //(Dias)
    {
        //"get" mit implementierung
        get
        {
            //wird im Output Fenster ausgeführt
            logger.Log($"Getter von Name wurde Aufgerufen");
            return name;
        }
        //"set" mit implementierung
        set
        {
            //wird im Output Fenster ausgeführt
            logger.Log($"Setter von Name wurde Aufgerufen");
            name = value;
        }
    }
}