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
            string sciezka_osobowy = "Osobowy.txt";
            string sciezka_ciezarowe = "Ciezarowy.txt";
            string sciezka_motocykl = "Motocykl.txt";

            if (File.Exists(sciezka_osobowy)&& File.Exists(sciezka_ciezarowe)&& File.Exists(sciezka_motocykl))
            {
                for (int i = 0; i < sciezka_osobowy.Length; i++)
                {
                    wyswietlany_text.Text = File.ReadAllText(sciezka_osobowy, Encoding.UTF8);

                }
                for (int j = 0; j < sciezka_ciezarowe.Length; j++)
                {
                    wyswietlany_text.Text = File.ReadAllText(sciezka_ciezarowe, Encoding.UTF8);
                }
                for (int k = 0; k < sciezka_motocykl.Length; k++)
                {
                    wyswietlany_text.Text = File.ReadAllText(sciezka_motocykl, Encoding.UTF8);
                }
            }
            
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