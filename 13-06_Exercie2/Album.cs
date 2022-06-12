using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_06_Exercie2
{
    class Album
    {
        List<Track> tracks = new List<Track>();
        List<Artist> artists = new List<Artist>();
        List<Band> band = new List<Band>();
        public List<string> GetAllAlbums() 
        { 
            return File.ReadAllLines("..\\..\\..\\SongCSV.csv").Skip(1).Select(
                x => x.Split(',')
            ).Select(x => x[3].Replace("b'", "")).GroupBy(x => x).Select(x => x.First()).ToList(); 
        }

        public Album()
        { }

    }
}
