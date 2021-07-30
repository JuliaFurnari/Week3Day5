using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class CanzoniRepository : IDbRepository<Canzoni>
    {
        static List<Canzoni> CanzoniList = new List<Canzoni>();
       
       
        public List<Canzoni> CreationEmptyList()
        {
            return CanzoniList;  
        }

        public List<Canzoni> CreationList()
        {
            CanzoniList.Add(new Canzoni("CanzoneClassica1", new Autore { Nome = "Nome1", Cognome = "Cognome1", AnnoDiNascita = new DateTime(1980, 1, 1) }, EnumGenere.Classica));
            CanzoniList.Add(new Canzoni("CanzoneClassica2", new Autore { Nome = "Nome1", Cognome = "Cognome1", AnnoDiNascita = new DateTime(1980, 1, 1) }, EnumGenere.Classica));
            CanzoniList.Add(new Canzoni("CanzonePop1", new Autore { Nome = "Nome2", Cognome = "Cognome2", AnnoDiNascita = new DateTime(1960, 2, 2) }, EnumGenere.Pop));
            CanzoniList.Add(new Canzoni("CanzonePop2", new Autore { Nome = "Nome2", Cognome = "Cognome2", AnnoDiNascita = new DateTime(1960, 2, 2) }, EnumGenere.Pop));
            CanzoniList.Add(new Canzoni("CanzoneRock1", new Autore { Nome = "Nome3", Cognome = "Cognome3", AnnoDiNascita = new DateTime(1970, 3, 3) }, EnumGenere.Rock));
            CanzoniList.Add(new Canzoni("CanzoneRock2", new Autore { Nome = "Nome3", Cognome = "Cognome3", AnnoDiNascita = new DateTime(1970, 3, 3) }, EnumGenere.Rock));
            return CanzoniList;
        }
    }
}
