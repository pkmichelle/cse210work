using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("\nWelcome to the Journal Program!\n");

        int _selection = 0;

        while (_selection !=5 )
        {
            Console.WriteLine(
                "Please select one of the following choices:\n"+
                "1. Write\n"+
                "2. Display\n"+
                "3. Load\n"+
                "4. Save\n"+
                "5. Quit\n"
            );

            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            _selection = int.Parse(response);


            if (_selection == 1)
                {
                    journal.Add();
                }
            if (_selection == 2)
                {
                    journal.Display();
                }
            if (_selection == 3)
                {
                    journal.LoadFile();
                }
            if (_selection == 4)
                {
                    journal.SaveFile();
                }
            if (_selection == 5)
                {
                    Console.WriteLine("Thank you for using this journal!");
                }

            
        }
        
    }
}