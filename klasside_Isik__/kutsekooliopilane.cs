﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_Isik__
{
    internal class kutsekooliopilane:isik
    {
        public int kursus;
        public string oppeasutus;
        public string eriala;
        string[] koolinimetus = { "Tallinna Tööstushariduskeskus", "Tallinna Transpordikool", "Tallinna Ehituskool", "Tallinna Teeninduskool"};
        string[] erialanimetus = { "tarkvaarendaja", "tööstusinformaatik", "logistika IT-süsteemide nooremspetsialist", "logistik", "rätsep-stilist" };
        public kutsekooliopilane(int oppeasutus, int eriala, int kursus,int toetus, string eesnimi, int synniAasta, char isiksugu) : base(eesnimi, synniAasta, isiksugu)
        {
            this.oppeasutus = koolinimetus[oppeasutus];
            this.eriala=erialanimetus[eriala];
            this.kursus = kursus;
        }

        public override void arvutaSissetulek(double maksvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }


        public override void print_info()
        {
            Console.WriteLine("Eesnimi:" + eesnimi + " Sünniaasta:" + synniAasta + " Eriala:" + eriala + " Oppeasutus:" + oppeasutus + " Kursus:" + kursus + " Sugu:" + isiksugu);
        }
    }
}
