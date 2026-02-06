using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace TransPolWpf
{
    internal abstract class Pojazd
    {
        protected string Marka { get; }
        protected string Model { get; }
        protected string RokProdukcji { get; }

        protected abstract string Sciezka { get; }

        protected Pojazd(string marka, string model, string rokProdukcji)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
        }

        public void Zapisz()
        {
            File.AppendAllText(
                Sciezka,
                $"marka: {Marka}\nmodel: {Model}\nrok produkcji: {RokProdukcji}\n\n"
            );
        }
    }
}

