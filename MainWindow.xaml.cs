using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransPolWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WczytajPojazdy();
        }

        private void WczytajPojazdy()
        {
            string osobowy = "Osobowy.txt";
            string ciezarowy = "Ciezarowy.txt";
            string motocykl = "Motocykl.txt";

            StringBuilder sb = new StringBuilder();

            if (File.Exists(osobowy))
            {
                sb.AppendLine("=== OSOBOWY ===");
                sb.AppendLine(File.ReadAllText(osobowy));
            }

            if (File.Exists(ciezarowy))
            {
                sb.AppendLine("=== CIEZAROWY ===");
                sb.AppendLine(File.ReadAllText(ciezarowy));
            }

            if (File.Exists(motocykl))
            {
                sb.AppendLine("=== MOTOCYKL ===");
                sb.AppendLine(File.ReadAllText(motocykl));
            }

            wyswietlany_text.Text = sb.ToString();
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            string marka_cs = marka.Text;
            string model_cs = model.Text;
            string rok_cs = rok_produkcji.Text;

            if (string.IsNullOrWhiteSpace(marka_cs) ||
                string.IsNullOrWhiteSpace(model_cs) ||
                string.IsNullOrWhiteSpace(rok_cs))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            Pojazd pojazd = null;

            if (a.IsChecked == true)
            {
                pojazd = new Osobowy(marka_cs, model_cs, rok_cs);
            }
            else if (b.IsChecked == true)
            {
                pojazd = new Ciezarowy(marka_cs, model_cs, rok_cs);
            }
            else if (c.IsChecked == true)
            {
                pojazd = new Motocykl(marka_cs, model_cs, rok_cs);
            }
            else
            {
                MessageBox.Show("Wybierz typ pojazdu!");
                return;
            }

            pojazd.Zapisz();

            marka.Clear();
            model.Clear();
            rok_produkcji.Clear();

            WczytajPojazdy();
        }
    }
}
