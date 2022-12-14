using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_Isik__
{
    internal class tootaja:isik
    {
        public string asutus;
        public string amet;
        public int tootasu ;
        string[] koolinimetus = { "Tallinna Tööstushariduskeskus", "Tallinna Transpordikool", "Tallinna Ehituskool", "Tallinna Teeninduskool" };
        string[] erialanimetus = { "juhtkond", "valdkondade juhid", "üldainete õpetaja", "tugipersonal", "eriala õpetaja" };
        public tootaja(int asutus, int amet, int tootasu, string eesnimi, int synniAasta, char isiksugu) : base(eesnimi, synniAasta, isiksugu)
        {
            this.asutus = koolinimetus[asutus];
            this.amet = erialanimetus[amet];
            this.tootasu = tootasu; 
        }

        public override double arvutaSissetulek(double maksvaba, double tulumaks)
        {
            double SedaTeNae = (tootasu - maksvaba) + (1-tulumaks / 100)+maksvaba;
            double netpalk = tootasu - SedaTeNae;
            Console.WriteLine("sul netpalk on: "+netpalk);
            return netpalk;
        }

        public override void print_info()
        {
            Console.WriteLine("Eesnimi:" + eesnimi + " Sünniaasta:" + synniAasta + " Amet:" + amet + " Asutus:" + asutus +" Tootasu:"+tootasu+ " Sugu:" + isiksugu);
        }
    }
}
