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

        public Libro(string a, string t, int ap, string e, int n)
        {
            _autore = a;
            _titolo = t;
            _annoPubblicazione = ap;
            _editore = e;
            _nPagine = n;
        }

        public string Autore
        {
            get => _autore;
            set
            {
                _autore = value;
            }
        }

        public string Titolo
        {
            get => _titolo;
            set
            {
                _titolo = value;
            }
        }

        public int AnnoPubblicazione
        {
            get => _annoPubblicazione;
            set
            {
                _annoPubblicazione = value;
            }
        }

        public string Editore
        {
            get => _editore;
            set
            {
                _editore = value;
            }
        }

        public int NPagine
        {
            get => _nPagine;
            set
            {
                _nPagine = value;
            }
        }

        public override string ToString()
        {
            return "Autore: " + _autore + "  Titolo: " + _titolo + "  Anno di pubblicazione: " + _annoPubblicazione + "  Editore: " + _editore + "  Numero di pagine: " + _nPagine;
        }


    }
}