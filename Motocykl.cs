using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TransPolWpf
{
    internal class Motocykl : Pojazd
    {
        private int LiczbaMiejsc;

        protected override string Sciezka => "Motocykl.txt";

        public Motocykl(string marka, string model, string rok, int liczbaMiejsc)
            : base(marka, model, rok)
        {
            LiczbaMiejsc = liczbaMiejsc;
        }

        protected override string DodatkoweDane()
        {
            return $"liczba miejsc: {LiczbaMiejsc}\n";
        }
    }

}

