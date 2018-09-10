using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {

        public string Navn { get; }
        public int fødselsmåned { get;}
        public int fødselsdag { get;}

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            this.fødselsmåned = fødselsmåned;
            this.fødselsdag = fødselsdag;
        }

        public string årstid()
        {
            if (fødselsmåned == 12 || fødselsmåned==1 || fødselsmåned ==2)
            {
                return "Vinter";
            } 
            else if (fødselsmåned == 3 || fødselsmåned == 4 || fødselsmåned == 5)
            {
                return "Forår";
            }
            else if (fødselsmåned == 6 || fødselsmåned == 7 || fødselsmåned == 8)
            {
                return "Sommer";
            }
            return "Efterår";
        }

    }
}
