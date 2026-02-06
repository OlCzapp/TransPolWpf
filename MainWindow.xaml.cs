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
                int drzwi = int.Parse(liczba_drzwi.Text);
                pojazd = new Osobowy(marka_cs, model_cs, rok_cs, drzwi);
            }
            else if (b.IsChecked == true)
            {
                pojazd = new Ciezarowy(marka_cs, model_cs, rok_cs, ladownosc.Text);
            }
            else if (c.IsChecked == true)
            {
                int miejsca = int.Parse(liczba_miejsc.Text);
                pojazd = new Motocykl(marka_cs, model_cs, rok_cs, miejsca);
            }


            pojazd.Zapisz();

            marka.Clear();
            model.Clear();
            rok_produkcji.Clear();

            WczytajPojazdy();
        }

        private void a_Checked(object sender, RoutedEventArgs e)
        {
            if (a.IsChecked == true)
            {
                liczba_drzwi_lab.Visibility = Visibility.Visible;
                liczba_drzwi.Visibility = Visibility.Visible;

                ladownosc_lab.Visibility = Visibility.Collapsed;
                ladownosc.Visibility = Visibility.Collapsed;

                liczba_miejsc_lab.Visibility = Visibility.Collapsed;
                liczba_miejsc.Visibility = Visibility.Collapsed;
            }
            else
            {
                liczba_drzwi_lab.Visibility = Visibility.Collapsed;
                liczba_drzwi.Visibility = Visibility.Collapsed;
            }
        }

        private void b_Checked(object sender, RoutedEventArgs e)
        {
            if (b.IsChecked == true)
            {
                ladownosc_lab.Visibility = Visibility.Visible;
                ladownosc.Visibility = Visibility.Visible;

                liczba_drzwi_lab.Visibility = Visibility.Collapsed;
                liczba_drzwi.Visibility = Visibility.Collapsed;

                liczba_miejsc_lab.Visibility = Visibility.Collapsed;
                liczba_miejsc.Visibility = Visibility.Collapsed;
            }
            else
            {
                ladownosc_lab.Visibility = Visibility.Collapsed;
                ladownosc.Visibility = Visibility.Collapsed;
            }
        }

        private void c_Checked(object sender, RoutedEventArgs e)
        {
            if (c.IsChecked == true)
            {
                liczba_miejsc_lab.Visibility = Visibility.Visible;
                liczba_miejsc.Visibility = Visibility.Visible;

                liczba_drzwi_lab.Visibility = Visibility.Collapsed;
                liczba_drzwi.Visibility = Visibility.Collapsed;
                
                ladownosc_lab.Visibility = Visibility.Collapsed;
                ladownosc.Visibility = Visibility.Collapsed;
            }
            else
            {
                liczba_miejsc_lab.Visibility = Visibility.Collapsed;
                liczba_miejsc.Visibility = Visibility.Collapsed;
            }
        }
    }
}
