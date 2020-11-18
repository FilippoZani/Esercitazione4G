using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Esercitazione4G
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca biblioteca;
        int index;

        public MainWindow()
        {
            InitializeComponent();

            btnRimuovi.IsEnabled = false;
            btnTempoLettura.IsEnabled = false;

            LeggiDaFile();

            ScriviSuLista();
        }

        public void LeggiDaFile()
        {
            using (StreamReader file = new StreamReader("biblioteca.txt")) 
            {
                List<Libro> libri = new List<Libro>();
                string rigaBiblioteca = file.ReadLine();
                string[] elementiBiblioteca = rigaBiblioteca.Split('|');

                using (StreamReader fileLibri = new StreamReader(elementiBiblioteca[5] + ".txt")) 
                {
                    while (!fileLibri.EndOfStream)
                    {
                        string rigaLibri = file.ReadLine();
                        string[] elementiLibri = rigaLibri.Split('|');

                        Libro l = new Libro(elementiLibri[0], elementiLibri[1], int.Parse(elementiLibri[2]), elementiLibri[3], int.Parse(elementiLibri[4]));
                        libri.Add(l);
                    }
                }

                string[] apertura = elementiBiblioteca[2].Split('/');
                DateTime oraApertura = new DateTime(int.Parse(apertura[0]), int.Parse(apertura[1]), int.Parse(apertura[3]));

                string[] chiusura = elementiBiblioteca[3].Split('/');
                DateTime oraChiusura = new DateTime(int.Parse(chiusura[0]), int.Parse(chiusura[1]), int.Parse(chiusura[3]));


                biblioteca = new Biblioteca(elementiBiblioteca[0], elementiBiblioteca[1], oraApertura, oraChiusura, libri);
            }
        }

        public void ScriviSuLista()
        {
            foreach(Libro l in bibblioteca.Libri)
            {
                lstLibri.Items.Add(l.ToString());
            }
        }

        private void lstLibri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstLibri.SelectedIndex >= 0)
            {
                btnRimuovi.IsEnabled = true;
                btnTempoLettura.IsEnabled = true;
                index = lstLibri.SelectedIndex;
            }
            else
            {
                btnRimuovi.IsEnabled = false;
                btnTempoLettura.IsEnabled = false;
            }
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            //valori già inseriti

            Libro aggiunta = new Libro("Autore", "Titolo", 2000, "Editore", 300);
            biblioteca.Libri.Add(aggiunta);
        }

        private void btnRimuovi_Click(object sender, RoutedEventArgs e)
        {
            lstLibri.Items.RemoveAt(index);
            biblioteca.Libri.RemoveAt(index);
            lstLibri.SelectedIndex = -1;
        }

        private void btnNumeroLibri_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I libri nella biblioteca " + biblioteca.Nome + " sono " + biblioteca.Libri.Count());
        }

        private void btnRicercaDaAutore_Click(object sender, RoutedEventArgs e)
        {
            string autore = txtRicercaDaAutore.Text.ToLower();

            foreach (Libro l in biblioteca.Libri())
            {
                if (l.Autore == autore)
                {
                    MessageBox.Show("Il brano " + l.Nome + " è stato scritto dall'autore inserito");
                }
            }
        }

        private void btnTempoLettura_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Il tempo di lettura del libro selezionato è: " + biblioteca.Libri[index].readingTime());
        }

        private void btnRicercaDaNome_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtRicercaDaNome.Text.ToLower();

            foreach (Libro l in biblioteca.Libri())
            {
                if (l.Autore == nome)
                {
                    MessageBox.Show("Il brano inserito ha le seguenti proprietà " + l.ToString());
                }
            }
        }
    }
}
