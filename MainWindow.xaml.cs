using System;
using System.IO;
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
            string sciezka = "lista_pojazdow.txt";

            if (File.Exists(sciezka))
            {
                wyswietlany_text.Text = File.ReadAllText(sciezka, Encoding.UTF8); //wyswietlany_text - textblock po prawej stronie, w którym wyświetlamy dane z pliku
            }
            else
            {
                wyswietlany_text.Text = "Brak danych.";
            }
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            string marka_cs = marka.Text;
            string model_cs = model.Text;
            string rok_cs = rok_produkcji.Text;

            string rodzaj_cs = "";
            if (a.IsChecked == true)
            {
                rodzaj_cs = "Osobowy";
            }
            else if (b.IsChecked == true)
            {
                rodzaj_cs = "Ciężarowy";
            }
            else
            {
                rodzaj_cs = "Motocykl";
            }

            string linia = $"Dane: \nMarka: {marka_cs}\nModel: {model_cs}\nRok produkcji: {rok_cs}\nRodzaj: {rodzaj_cs}\n...";

            File.AppendAllText("lista_pojazdow.txt", linia + Environment.NewLine);

            WczytajPojazdy(); //odświeżenie TextBlocka

            //wyswietlany_text.Text = $"Dane: \nMarka: {marka_cs}\nModel: {model_cs}\nRok produkcji: {rok_cs}\nRodzaj: {rodzaj_cs}\n...";

            //MessageBox.Show($"Dodano pojazd:\nMarka: {marka_cs}\nModel: {model_cs}\nRok produkcji: {rok_cs}\nRodzaj: {rodzaj_cs}", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}