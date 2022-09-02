using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_Isik__
{
    abstract class isik
    {
        public string eesnimi;
        public int synniAasta;
        public char isiksugu;

        public isik(string eesnimi="---", int synniAasta=0,char isiksugu ='x') 
        {
            this.eesnimi = eesnimi;
            this.synniAasta = synniAasta;
            this.isiksugu = isiksugu;
        }
        public isik(isik ob)
        {
            this.eesnimi = ob.eesnimi;
            this.synniAasta = ob.synniAasta;
            this.isiksugu = ob.isiksugu;
        }
        public abstract void print_info();
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            Console.WriteLine($"{vanus} - {vanus-1} aastat vana");
            return vanus;
        }
        public void muudaNimi(string uusnimi) { eesnimi = uusnimi; }
        public abstract double arvutaSissetulek(double maksvaba,double tulumaks);

    }
}
