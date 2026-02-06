using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TransPolWpf
{
    internal class Ciezarowy : Pojazd
    {
        private string Ladownosc;
        protected override string Sciezka => "Ciezarowy.txt";

        public Ciezarowy(string marka, string model, string rok, string ladownosc)
            : base(marka, model, rok)
        {
            Ladownosc = ladownosc;
        }

        protected override string DodatkoweDane()
        {
            return $"ładowność: {Ladownosc}\n";
        }
    }

}

