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

        protected Pojazd(string marka, string model, string rok)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rok;
        }

        protected virtual string DodatkoweDane()
        {
            return "";
        }

        public void Zapisz()
        {
            File.AppendAllText(
                Sciezka,
                $"marka: {Marka}\nmodel: {Model}\nrok produkcji: {RokProdukcji}\n" +
                DodatkoweDane() +
                "\n"
            );
        }
    }

}

