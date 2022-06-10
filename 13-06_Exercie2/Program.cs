using System;
using System.IO;
using System.Linq;

namespace _13_06_Exercie2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fichier = File.ReadAllLines("..\\..\\..\\SongCSV.csv");
            var donnees = fichier.Select(x => x.Split(",")).ToList();
        }
    }
}
