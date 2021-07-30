using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class PodcastRepository : IDbRepository<Podcast>
    {
        public static List<Episodi> EpisodiList3 = new List<Episodi>();
        public  static List<Episodi> EpisodiList1 = new List<Episodi>();
       public static List<Episodi> EpisodiList2 = new List<Episodi>();
       public static List<Podcast> PodcastList = new List<Podcast>();
      
        public List<Podcast> CreationEmptyList()
        {
            return PodcastList;
        }
        DateTime a1 = new DateTime(1, 1, 1);


        public static List<Episodi> CreationList1()
        {
            EpisodiList1.Add(new Episodi("titolo4", new TimeSpan(1, 10, 1), false));
            EpisodiList1.Add(new Episodi("titolo5", new TimeSpan(0, 50, 1), false));
            EpisodiList1.Add(new Episodi("titolo6", new TimeSpan(1, 45, 1), false));
            EpisodiList1.Add(new Episodi("titolo7", new TimeSpan(0, 15, 1), false));
            EpisodiList1.Add(new Episodi("titolo8", new TimeSpan(0, 30, 1), false));
            EpisodiList1.Add(new Episodi("titolo9", new TimeSpan(1, 1, 1), false));
            return EpisodiList1;

        }
        public static List<Episodi> CreationList2()
        {
            EpisodiList2.Add(new Episodi("titolo10", new TimeSpan(1, 1, 1), false));
            EpisodiList2.Add(new Episodi("titolo11", new TimeSpan(2, 1, 1), false));
            EpisodiList2.Add(new Episodi("titolo12", new TimeSpan(3, 1, 1), false));
            EpisodiList2.Add(new Episodi("titolo13", new TimeSpan(4, 1, 1), false));


            return EpisodiList2;
        }

        public static List<Episodi> CreationList3()
        {
             
             EpisodiList3.Add(new Episodi("titolo1", new TimeSpan(0, 16, 1), false));
            EpisodiList3.Add(new Episodi("titolo2", new TimeSpan(1, 1, 1), false));
            EpisodiList3.Add(new Episodi("titolo3", new TimeSpan(0, 45, 1), false));
            return EpisodiList3;
        }

        public List<Podcast> CreationList()
        {
            PodcastList.Add(new Podcast("Storie", new Autore {Nome="Nome1", Cognome="Cognome1", AnnoDiNascita=new DateTime(1980, 1, 1)}, "Descrizione1", CreationList3()));
            PodcastList.Add(new Podcast("Lezioni di Letteratura", new Autore { Nome = "Nome2", Cognome = "Cognome2", AnnoDiNascita = new DateTime(1960, 2, 2) }, "Descrizione2", CreationList2()));
            PodcastList.Add(new Podcast("Harry Potter", new Autore { Nome = "Nome3", Cognome = "Cognome3", AnnoDiNascita = new DateTime(1970, 3, 3) }, "Descrizione3", CreationList1()));

            return PodcastList;
        }


    }
}
