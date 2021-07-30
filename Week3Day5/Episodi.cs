using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class Episodi
    {
        public string Titolo;
        public TimeSpan Durata;
        public bool Flag;

        public Episodi() { }

        public Episodi(string titolo, TimeSpan durata, bool flag)
        {
            Titolo = titolo;
            Durata = durata;
            Flag = flag;
        }

        
        public void PrintInfo1()
        {
            Console.Write($"\nTitolo: {Titolo}" + $"\tDurata: {Durata}" + $"\tAscoltato: {Flag}");
        }
    }
}
