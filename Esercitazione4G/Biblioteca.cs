using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione4G
{
    class Biblioteca
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return Nome;
            }
            set
            {
                if (String.IsNullOrEmpty(Nome))
                {
                    throw new Exception("Il nome della biblioteca inserito non è valido");
                }
                else
                {
                    _nome = Nome;
                }
            }
        }

        private string _indirizzo;
        public string Indirizzo
        {
            get
            {
                return Indirizzo;
            }
            set
            {
                if (String.IsNullOrEmpty(Indirizzo))
                {
                    throw new Exception("L'indirizzo della biblioteca inserito non è valido");
                }
                else
                {
                    _indirizzo = Indirizzo;
                }
            }
        }

        private DateTime _orarioApertura;
        public DateTime OrarioApertura
        {
            get
            {
                return OrarioApertura;
            }
            set
            {
                if(OrarioApertura.Hour < 6 || OrarioApertura.Hour > 12)
                {
                    throw new Exception("La biblioteca deve aprire almeno alle 6 di mattina");
                }
                else
                {
                    _orarioApertura = OrarioApertura;
                }
            }
        }

        private DateTime _orarioChiusura;
        public DateTime OrarioChiusura
        {
            get
            {
                return OrarioChiusura;
            }
            set
            {
                if(OrarioChiusura.Hour > 18)
                {
                    throw new Exception("La biblioteca deve chiudere almeno alle 6 di sera");
                }
                else
                {
                    _orarioChiusura = OrarioChiusura;
                }
            }
        }

        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _orarioApertura = orarioApertura;
            _orarioChiusura = orarioChiusura;
        }

        public override string ToString()
        {
            return "Il nome della biblioteca è: " + _nome + "; l'indirizzo della biblioteca è: " + _indirizzo + "; l'orario di apertura della biblioteca è: " + _orarioApertura + "; l'orario di chiusura della biblioteca è: " + _orarioChiusura + ".";
        }
    }
}
