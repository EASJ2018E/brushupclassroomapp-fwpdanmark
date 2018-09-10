using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasse = new KlasseRum();
            klasse.KlasseNavn = "3B";
            klasse.Klasseliste = new List<Studerende>();
            klasse.SemesterStart = new DateTime(2018,9,4);

            klasse.Klasseliste.Add(new Studerende("Frederik",5,3));
            klasse.Klasseliste.Add(new Studerende("Jesper",11,2));


        }
    }
}
