using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_Isik__
{
    internal class opilane : isik
    {
        public string spetsialiseerumine;
        public string koolinimi;
        public string klass;
        string[] klassinimetus = { "TARpv20", "TARpe20", "LOGpv22", "KRRpv21", "KRRpv20", "KRRpe21", "LOGITpe21" };
        string[] koolinimetus = {"Tallinna Tööstushariduskeskus", "Tallinna Transpordikool" , "Tallinna Ehituskool", "Tallinna Teeninduskool" };
        string[] erialanimetus = { "tarkvaarendaja", "tööstusinformaatik", "logistika IT-süsteemide nooremspetsialist", "logistik", "rätsep-stilist" };
        public opilane(int koolinimi, int klass, int spetsialiseerumine ,string eesnimi, int synniAasta, char isiksugu) : base(eesnimi,  synniAasta,  isiksugu) 
        {
            this.koolinimi = koolinimetus[koolinimi];
            this.spetsialiseerumine = erialanimetus[spetsialiseerumine];
            this.klass = klassinimetus[klass];
        }

        public override double arvutaSissetulek(double maksvaba, double tulumaks)
        {
            Console.WriteLine("sul on ei olnud tootasu");
            return 0;
        }

        public override void print_info()
        {
            Console.WriteLine("Eesnimi:" + eesnimi + " Sünniaasta:" + synniAasta + " Eriala:" + spetsialiseerumine +" Koolinimi:"+koolinimi+ " Klass:" + klass + " Sugu:" + isiksugu);
            
        }
    }
}
