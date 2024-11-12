using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Entry
{
    public string Date{ get; }
    public string Prompt { get; }
    public string Response{ get; }
//constructor to initialize the entry
public Entry(string date, string prompt, string response)
{
    Date = date;
    Prompt = prompt;
    Response =response;
}
    public override string ToString()
    {
        return "$ {Date}|{Prompt}|{Response}";
    }

        
    
}