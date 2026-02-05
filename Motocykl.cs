using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TransPolWpf
{
    internal class Motocykl
    {
        private const string Sciezka = "Motocykl.txt";

        public static void Zapisz(string marka, string model, string rok_produkcji)
        {
            File.AppendAllText(Sciezka, "marka: " + marka + "; model " + model + "; rok produkcji " + rok_produkcji + System.Environment.NewLine);
        }
    }
}
