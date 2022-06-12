using System;
using System.IO;
using System.Linq;

namespace _13_06_Exercie2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var fichier = File.ReadAllLines("..\\..\\..\\SongCSV.csv");
            var donnees = fichier.Select(x => x.Split(",")).ToList();
            foreach (string column in donnees[0])
                Console.WriteLine(column);
            Console.WriteLine();
            foreach (string Donne1 in donnees[1])
                Console.WriteLine(Donne1);
            */

            var readFile = File.ReadAllLines("..\\..\\..\\SongCSV.csv");

            var donneesFile = readFile.Skip(1).Select(x => x.Split(',')).ToList();
            var musicsByYear = donneesFile.Skip(1).GroupBy(x => x[17]).OrderBy(x => x.Count()).Reverse().ToList();

            Artist artists = new Artist();
            Band bands = new Band();
            Album albums = new Album();


            var getArtists = artists.GetAllArtists();
            var getAlbums = albums.GetAllAlbums();
            
            Console.WriteLine("Top 50 du nombre de chansons sortie par années : ");
            for (int i = 0; i < 50; i++)
            {    
                Console.WriteLine("En " + musicsByYear[(i + 1)].Key + " nombre de musiques produites : " + musicsByYear[i].Count());
            }
        }
    }
}