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
        public enum sugu { mees, näine };
        public sugu isiksugu;
        public isik() { }
        public isik(string eesnimi, int synniAasta,sugu isiksugu) 
        {
            this.eesnimi = eesnimi;
            this.synniAasta = synniAasta;
            this.isiksugu = isiksugu;
        }
        public abstract void print_info();
        public abstract void arvutaVanus();
        public abstract void muudaNimi();
        public abstract void arvutaSissetulek();

    }
}
