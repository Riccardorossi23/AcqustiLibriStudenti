using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    public class Studenti
    {
        public string nome { get; private set; }
        public string cognome { get; private set; }
        public int matricola { get; set; }

        public Studenti(string nome, string cognome, int matricola)
        {
           this.nome = nome;
            this.cognome = cognome;
            this.matricola = matricola;
        }

        public string GetMatricola()
        {
            return ($"Matricola:{matricola} {nome} {cognome}");
        }
        public string Presentati()
        {
            return $"Studente {nome} {cognome} di matricola {matricola}";
        }

    }
}
