using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_06_Exercie2
{
    class Artist
    {
        
        public List<string> GetAllArtists()
        {
            return File.ReadAllLines("..\\..\\..\\SongCSV.csv").Skip(1).Select(
                x => x.Split(',')
            ).Select(x => x[3].Replace("b'", "")).GroupBy(x => x).Select(x => x.First()).ToList();
        }

        public Artist()
        { }
    }
}