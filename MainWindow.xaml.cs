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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WczytajPojazdy();
        }

        void WczytajPojazdy()
        {
            string osobowy = "Osobowy.txt";
            string ciezarowy = "Ciezarowy.txt";
            string motocykl = "Motocykl.txt";

            StringBuilder sb = new StringBuilder();

            if (File.Exists(osobowy))
                sb.AppendLine("OSOBOWY:")
                  .AppendLine(File.ReadAllText(osobowy));

            if (File.Exists(ciezarowy))
                sb.AppendLine("\nCIĘŻAROWY:")
                  .AppendLine(File.ReadAllText(ciezarowy));

            if (File.Exists(motocykl))
                sb.AppendLine("\nMOTOCYKL:")
                  .AppendLine(File.ReadAllText(motocykl));

            wyswietlany_text.Text = sb.ToString();

        }
        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            string marka_cs = marka.Text;
            string model_cs = model.Text;
            string rok_cs = rok_produkcji.Text;

            if (a.IsChecked == true)
            {
                Osobowy.Zapisz(marka_cs, model_cs, rok_cs);
                wyswietlany_text.Text = "Zapisano do Osobowy.txt";
            }
            else if (b.IsChecked == true)
            {
                Ciezarowy.Zapisz(marka_cs, model_cs, rok_cs);
                wyswietlany_text.Text = "Zapisano do Ciezarowy.txt";
            }
            else if (c.IsChecked == true)
            {
                Motocykl.Zapisz(marka_cs, model_cs, rok_cs);
                wyswietlany_text.Text = "Zapisano do Motocykl.txt";
            }
            WczytajPojazdy();

        }
    }
}