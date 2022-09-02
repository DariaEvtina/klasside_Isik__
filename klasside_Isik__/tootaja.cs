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
        string[] koolinimetus = { "Tallinna Tööstushariduskeskus", "Tallinna Transpordikool", "Tallinna Ehituskool", "Tallinna Teeninduskool" };
        public tootaja(int asutus, int amet, int tootasu, string eesnimi, int synniAasta, sugu isiksugu) : base(eesnimi, synniAasta, isiksugu)
        {
            this.asutus = koolinimetus[asutus];
        }

        public override void arvutaSissetulek()
        {
            throw new NotImplementedException();
        }

        public override void arvutaVanus()
        {
            throw new NotImplementedException();
        }

        public override void muudaNimi()
        {
            throw new NotImplementedException();
        }

        public override void print_info()
        {
            throw new NotImplementedException();
        }
    }
}
