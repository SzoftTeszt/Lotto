using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Huzas
    {

        public Huzas()
        {
        }

        public Huzas(string sor)
        {
            var t = sor.Split(';');
            Szam1 = Convert.ToInt32(t[0]);
            Szam2 = Convert.ToInt32(t[1]); 
            Szam3 = Convert.ToInt32(t[2]);
            Szam4 = Convert.ToInt32(t[3]);
            Szam5 = Convert.ToInt32(t[4]);
        }

        public Huzas(List<int> adatok)
        {
            
            Szam1 = adatok[0];
            Szam2 = adatok[1];
            Szam3 = adatok[2];
            Szam4 = adatok[3];
            Szam5 = adatok[4];
        }

        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }

        public override string? ToString()
        {
            return Szam1+";"+ Szam2 + ";" + Szam3 + ";" + Szam4 + ";" + Szam5;
        }
    }
}
