using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class FileMultimediali
    {
       
        public string Titolo;
        public Autore AnagraficaAutore;

        public FileMultimediali() { }

        public FileMultimediali(string titolo, Autore anagraficaAutore)
        {
            Titolo = titolo;
            AnagraficaAutore = anagraficaAutore;
        }

        //public virtual string GetTitolo()
        //{
        //    return Titolo;
        //}
        public virtual void PrintInfo()
        {
            Console.Write($"\nTitolo: {Titolo}" + $"\tAnagrafica Autore: { AnagraficaAutore.Nome} {AnagraficaAutore.Cognome} {AnagraficaAutore.AnnoDiNascita.Date}");
        }
    }
    internal struct Autore
    {
      public string Nome;
      public string Cognome;
      public DateTime AnnoDiNascita;
         
        public Autore(string nome, string cognome, DateTime annoDiNascita)
        {
                Nome = nome;
                Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
        }
    }
    
}
