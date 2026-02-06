using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TransPolWpf
{
    internal class Osobowy : Pojazd
    {
        private int LiczbaDrzwi;
        protected override string Sciezka => "Osobowy.txt";

        public Osobowy(string marka, string model, string rok, int liczbaDrzwi)
            : base(marka, model, rok)
        {
            LiczbaDrzwi = liczbaDrzwi;
        }

        protected override string DodatkoweDane()
        {
            return $"liczba drzwi: {LiczbaDrzwi}\n";
        }
    }

}
