using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_Isik__
{
    internal class kutsekooliopilane:isik
    {
        public kutsekooliopilane(string oppeasutus, string eriala, int kursus,int toetus, string eesnimi, int synniAasta, sugu isiksugu) : base(eesnimi, synniAasta, isiksugu)
        {
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
