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
        protected override string Sciezka => "Ciezarowy.txt";

        public Ciezarowy(string marka, string model, string rok)
            : base(marka, model, rok)
        {
        }
    }
}

