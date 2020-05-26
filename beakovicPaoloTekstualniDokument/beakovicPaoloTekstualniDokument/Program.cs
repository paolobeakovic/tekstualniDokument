using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace beakovicPaoloTekstualniDokument
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\Users\Paolo\Documents\";
            string fileName = "CSharpCornerAuthors.txt";
            string fullPath = folder + fileName;

            string[] authors = { "Mahesh Chand", "Allen O'Neill", "David McCarter", "Raj Kumar", "Dhananjay Kumar" };
            File.WriteAllLines(fullPath, authors);
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);

            Console.ReadKey();
        }
    }
}