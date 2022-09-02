using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_Isik__
{
    internal class opilane : isik
    {
        public string koolinimi;
        string[] koolinimetus = {"Tallinna Tööstushariduskeskus", "Tallinna Transpordikool" , "Tallinna Ehituskool", "Tallinna Teeninduskool" };
        public opilane(int koolinimi, int klass, int spetsialiseerumine ,string eesnimi, int synniAasta, sugu isiksugu) : base(eesnimi,  synniAasta,  isiksugu) 
        {
            this.koolinimi = koolinimetus[koolinimi];
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
