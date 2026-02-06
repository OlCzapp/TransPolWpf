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
        protected override string Sciezka => "Osobowy.txt";

        public Osobowy(string marka, string model, string rok)
            : base(marka, model, rok)
        {
        }
    }
}
