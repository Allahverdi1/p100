using System;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files\Common Files\System\";
            Directory.CreateDirectory(path + "Files");
            File.Create(path + @" Files\files.json");

            if (!File.Exists(path + @"Files\files.json"))
            {
                var result = File.Create(path + "Files\files.json");
                result.Close();
            }

            string path = @"C:\Program Files\Common Files\System\";
            bool check = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Get Book By Id");
                Console.WriteLine("3. Remove Book ");
                Console.WriteLine("0. Quit");

                string Choise = Console.ReadLine();

            } while (check);

        }
    }
}
