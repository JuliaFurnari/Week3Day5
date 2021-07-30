using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class Canzoni:FileMultimediali
    {
       
        public EnumGenere Genere;

        public Canzoni() { }

        public Canzoni(string titolo, Autore autore, EnumGenere genere)
            : base(titolo, autore)
        {

            Genere = genere;
            
        }


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($"\tGenere: {Genere}" );
        }
    }

    public enum EnumGenere
    {
        Classica,
        Pop,
        Rock
    }
}
