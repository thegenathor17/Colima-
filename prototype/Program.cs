using System;
using Interpreter;
class Program
{
    static void Main(string[] args)
    {
        string choice;
        // First loop
        Console.WriteLine("Hello World! What will we program today?");
        Console.WriteLine("Write your code:");
        choice = Console.ReadLine();
        //Is Null?
        if (choice == null)
        {
            while(choice == null)
            {
                Console.WriteLine("Error 001, null line");
                choice = Console.ReadLine();
            }
        }
        //calling the reader
        Reader reader = new Reader();
        reader.Spliter(choice);
        // Main loop
        /*while(true)
        {

        }*/
    }
}