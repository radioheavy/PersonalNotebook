using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "notes.txt";

            while (true)
            {
                Console.WriteLine("1. Add Note");
                Console.WriteLine("2. View Notes");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter your note: ");
                        string note = Console.ReadLine();
                        File.AppendAllText(filePath, note + Environment.NewLine);
                        break;
                    case "2":
                        string notes = File.ReadAllText(filePath);
                        Console.WriteLine(notes);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
