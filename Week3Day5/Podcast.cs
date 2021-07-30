using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class Podcast:FileMultimediali
    {
        public string Descrizione;
        public List<Episodi> Episodi1 = new List<Episodi>();

        public Podcast() { }

        public Podcast(string titolo, Autore autore1, string descrizione, List<Episodi> episodi)
            :base(titolo, autore1)
        {
           
            Descrizione = descrizione;
            Episodi1 = episodi;
        }

      
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"\tDescrizione: {Descrizione}");
        }
    }
}
