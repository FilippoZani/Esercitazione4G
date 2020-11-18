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
        //Biblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();

            LeggiDaFile();

            ScriviSuLista();
        }

        public void LeggiDaFile()
        {
            using (StreamReader file = new StreamReader("biblioteca.txt")) 
            {
                //List<Libro> libri = new List<Libro>();
                string rigaBiblioteca = file.ReadLine();
                string[] elementiBiblioteca = rigaBiblioteca.Split('|');

                using (StreamReader fileLibri = new StreamReader(elementiBiblioteca[4] + ".txt")) 
                {
                    while (!fileLibri.EndOfStream)
                    {
                        string rigaLibri = file.ReadLine();
                        string[] elementiLibri = rigaLibri.Split('|');

                        //Libro l = new Libro(...);
                        //libri.Add(l);
                    }
                }

                //biblioteca = new Biblioteca(...);
            }
        }

        public void ScriviSuLista()
        {
            /*
            foreach(Libro l in bibblioteca.Libri)
            {
                lstLibri.Items.Add(l.ToString());
            }
            */
        }
    }
}
