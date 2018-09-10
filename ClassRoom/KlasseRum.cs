using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {

        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public void counter()
        {
            int forår = 0;
            int sommer = 0;
            int efterår = 0;
            int vinter = 0;

            foreach (Studerende student in Klasseliste)
            {
                if (student.årstid() == "Forår")
                {
                    forår++;
                }
                else if (student.årstid() == "Sommer")
                {
                    sommer++;
                }
                else if (student.årstid() == "Efterår")
                {
                    efterår++;
                }
                else if (student.årstid() == "Vinter")
                {
                    vinter++;
                }

                
            }
            Console.WriteLine("Forår: " + forår);
            Console.WriteLine("Sommer: " + sommer);
            Console.WriteLine("Efterår: " + efterår);
            Console.WriteLine("Vinter: " + vinter);
        }
    }
}
