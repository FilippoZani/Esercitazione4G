using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione4G
{
    public class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoPubblicazione;
        private string _editore;
        private int _nPagine;

        public string Autore
        {
            get => default;
            set
            {
                _autore = value;
            }
        }

        public string Titolo
        {
            get => default;
            set
            {
                _titolo = value;
            }
        }

        public int AnnoPubblicazione
        {
            get => default;
            set
            {
                _annoPubblicazione = value;
            }
        }

        public string Editore
        {
            get => default;
            set
            {
                _editore = value;
            }
        }

        public int NPagine
        {
            get => default;
            set
            {
                _nPagine = value;
            }
        }

        
    }
}