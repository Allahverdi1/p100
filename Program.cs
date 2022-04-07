using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Telebeye imtahan elave et");
                Console.WriteLine("3.Telebenin bir imtahan balina bax");
                Console.WriteLine("4.Telebenin butun imtahanlarini goster");
                Console.WriteLine("5.Telebenin imtahan ortalamasini goster");
                Console.WriteLine("6.Telebeden imtahan sil");
                Console.WriteLine("0.Program bitdi");
            } while (true);

        }
    }
}
