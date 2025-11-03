using System;
using System.Diagnostics.Contracts;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        // HER KALLER VI PÅ "ls"
        Console.WriteLine("Type: ls, cat or ???");
        string? input = Console.ReadLine();
        if (input == "ls")
        {
            magnusclass.LsCommand.Run();
        }
        if (input == "cat")
        {
            Console.WriteLine("Type in which file:");
            string? catInput = Console.ReadLine();
            magnusclass.CatCommand.Run(catInput);
        }
        if (input == "echo")
        {
            Console.WriteLine("Type something:");
            string echoInput = Console.ReadLine();
            Console.WriteLine(echoInput);
        }



    }
}