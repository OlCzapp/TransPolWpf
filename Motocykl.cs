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
        protected override string Sciezka => "Motocykl.txt";

        public Motocykl(string marka, string model, string rok)
            : base(marka, model, rok)
        {
        }
    }
}

