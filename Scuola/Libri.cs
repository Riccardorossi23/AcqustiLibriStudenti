using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    public class Libri
    {
        public string materia { get; private set; }
        public double prezzo { get; private set; }
        public string isbn { get; set; }

        public Libri(string materia, double prezzo, string isbn)
        {
            this.materia = materia;
            this.prezzo = prezzo;
            this.isbn = isbn;
        }

        public string GetISBN()
        {
            return ($"ISBN:{isbn} {materia} {prezzo}");
        }
        public string GetDescrizione()
        {
            return $"Libro di {materia} con ISBN {isbn} e prezzo di {prezzo}€";
        }
    }
}

