using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    class Menù
    {
        //Richiamo nel menù tutte le liste di prodotti e dei prodotti di default 
        //Da utilizzare nei metodi

        public static CanzoniRepository canzoniRep = new CanzoniRepository();
        public static PodcastRepository podcastRep = new PodcastRepository();
        public static List<Canzoni> canzoniList = canzoniRep.CreationList();
        public static List<Podcast> podcastList = podcastRep.CreationList();
        public static Canzoni canzone = new Canzoni();
        public static Podcast podcast = new Podcast();
        public static void Start()
        {
            //   Un utente può
            //- Visualizzare tutte le canzoni – stampare a video le proprietà;
            // -Visualizzare tutti i podcast – stampare a video le proprietà esclusi gli episodi;
            //  -Scelto un genere, visualizzare tutte le canzoni di quel genere
            //-Scelto un podcast, visualizzare tutti i suoi episodi
            //-Scelta una durata, visualizzare tutti gli episodi con durata minore o uguale alla durata inserita –
            //stampare le proprietà degli episodi e il titolo del podcast a cui appartiene l’episodio
            //- (facoltativo)Crearsi una playlist di canzoni
            //-(facoltativo)Scegliere quale episodio riprodurre e aggiornare il flag ad ascoltato.



            Console.WriteLine("*********Benvenuto!*********");

            char scelta;

            do
            {
                Console.WriteLine("Premi 1 per visualizzare tutte le canzoni.");
                Console.WriteLine("Premi 2 per visualizzare tutti i podcast");//Non stampare gli episodi
                Console.WriteLine("Premi 3 per visualizzare le canzoni per genere.");
                Console.WriteLine("Premi 4 per visualizzare tutti gli episodi di un podcast.");
                Console.WriteLine("Premi 5 per visualizzare tutti gli episodi con filtro durata.");//Durata inferiore a quella inserita
                Console.WriteLine("Premi 6 per creare una playlist di canzoni.");
                Console.WriteLine("Premi 7 per riprodurre un episodio di un podcast.");//Flag a vero

                Console.WriteLine("Premi Q per uscire");

                scelta = Console.ReadKey().KeyChar;

                switch (scelta)
                {
                    case '1':
                        //Visualizza tutte le canzoni;
                        Console.WriteLine();
                        VisualizzaCanzoni();
                        Console.WriteLine();
                        break;
                    case '2':
                        //Visualizza tutti i podcast
                        Console.WriteLine();
                        VisualizzaPodcast();
                        Console.WriteLine();
                        break;
                    case '3':
                        //Visualizza canzoni per genere
                        Console.WriteLine();
                        VisualizzaCanzoniGenere();
                        Console.WriteLine();
                        break;
                    case '4':
                        //Visualizza tutti gli episodi di un podcast
                        Console.WriteLine();
                        VisualizzaEpisodiPodcast();
                        Console.WriteLine();
                        break;
                    case '5':
                        //Visualizza tutti gli episodi con filtro durata
                        Console.WriteLine();
                       VisualizzaEpisodiFiltroDurata();
                        Console.WriteLine();
                        break;
                    case '6':
                        //Creare una playlist di canzoni
                        Console.WriteLine();
                         CreazionePlaylist();
                        Console.WriteLine();
                        break;
                    case '7':
                        //Riprodurre un episodio di un podcast
                        Console.WriteLine();
                         RiprodurreEpisodio();
                        Console.WriteLine();
                        break;

                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("\nScelta non disponibile");
                        break;
                }
            }
            while (!(scelta == 'Q'));

        }

        private static void RiprodurreEpisodio()
        {
            Console.WriteLine("Inserisci il titolo di uno dei seguenti Podcast");
            VisualizzaPodcast();
            Console.WriteLine();
            string titolo=Console.ReadLine();
            int controllo1 = 0;
            int controllo2 = 0;
            foreach (Podcast p in podcastList)
            {
                if (titolo == p.Titolo)
                {
                    controllo1 = 1;
                    List<Episodi> listaEpisodi = p.Episodi1;
                    foreach(Episodi e in listaEpisodi)
                    {
                        e.PrintInfo1();
                    }
                    Console.WriteLine("\nInserisci il titolo di uno dei seguenti Episodi");
                    string titolo2 = Console.ReadLine();
                    foreach (Episodi e in listaEpisodi)
                    {
                        if (titolo2 == e.Titolo)
                        {
                            controllo2 = 1;
                            e.Flag = true;
                            e.PrintInfo1();
                        }
                        
                    }
                if (controllo2 !=1) Console.WriteLine("\nIl titolo inserito non è presente nella lista episodi.");
                }

            }
            if (controllo1 != 1) Console.WriteLine("\nIl titolo inserito non è presente nella lista.");
           
        }

        private static void ScegliEpisodio(Podcast podcast)
        {
            
        }

        private static void CreazionePlaylist()
        {
            //Visualizza canzoni
            Console.WriteLine("Scegli dalla seguente lista le canzoni che vuoi inserire nella tua playlist.");
            VisualizzaCanzoni();
            Console.WriteLine();
            string risposta;
            List<Canzoni> Playlist = new List<Canzoni>();
            int controllo = 0;
            do
            {
                Console.WriteLine("Digita il titolo di una canzone.");
                string titolo = Console.ReadLine();

                foreach (Canzoni c in canzoniList)
                {
                    
                    if (titolo == c.Titolo)
                    {
                        controllo = 1;
                        Playlist.Add(c); 
                    }
                    
                }
                if (controllo != 1) Console.WriteLine("Il titolo inserito non è presente nella lista.");
                Console.WriteLine("Vuoi inserire un altro titolo? Digita si per continuare");
                 risposta = Console.ReadLine();
            } while (risposta == "si");
            Console.WriteLine("La tua playlist è:");
            foreach (Canzoni c in Playlist) c.PrintInfo();
        }

        private static void VisualizzaEpisodiFiltroDurata()
        {
            Console.WriteLine("Inserisci la durata massima di un episodio.");
            TimeSpan durata;
            int ore, minuti, secondi;
            Console.WriteLine("Inserisci le ore:");
            while (!int.TryParse(Console.ReadLine(), out ore) || ore > 99 || ore < 0)
            {
                Console.WriteLine("Scelta errata! Devi inserire un numero tra 0 e 99.");
            }
            Console.WriteLine("Inserisci i minuti:");
            while (!int.TryParse(Console.ReadLine(), out minuti) || minuti > 59 || minuti < 0)
            {
                Console.WriteLine("Scelta errata! Devi inserire un numero tra 0 e 59.");
            }
            Console.WriteLine("Inserisci i secondi:");
            while (!int.TryParse(Console.ReadLine(), out secondi) || secondi > 59 || secondi < 1)
            {
                Console.WriteLine("Scelta errata! Devi inserire un numero tra 1 e 59.");
            }
            durata = new TimeSpan(ore, minuti, secondi);

            
            foreach (Podcast p in podcastList)
            {
             
               
                foreach(Episodi e in p.Episodi1) { 
                    if (durata > e.Durata)
                    { 
                        e.PrintInfo1();
                        Console.Write($"\t {p.Titolo}");
                    }
                   
                    
                }
                
            }
          
        
    }

        private static void VisualizzaEpisodiPodcast()
        {
            //Visualizzo tutti i podcast
            Console.WriteLine("Inserisci il titolo di uno dei podcast della seguente:");
            VisualizzaPodcast();
            //Scegli il podcast inserendo il titolo
          
           SceltaPodcast();

        }

        private static void SceltaPodcast()
        {
            Console.WriteLine();
            string titolo = Console.ReadLine();
            int controllo = 0;

            foreach (Podcast p in podcastList)
            {
                if (titolo == p.Titolo)
                {
                    List<Episodi> listaEpisodi = new List<Episodi>();
                    listaEpisodi = p.Episodi1;
                    foreach (Episodi e in listaEpisodi)
                    {
                        e.PrintInfo1();
                    }
                    controllo = 1;

                }

            }
            if (controllo != 1) Console.WriteLine("Il podcast non è presente nella lista.");
        }
    

        private static void VisualizzaCanzoniGenere()
        {
            EnumGenere sceltaGenere = ScegliGerere();
            foreach (Canzoni c in canzoniList)
            {
              if(c.Genere==sceltaGenere)  c.PrintInfo();
            }
        }

        private static EnumGenere ScegliGerere()
        {
            Console.WriteLine("");
            Console.WriteLine($"Premi {(int)EnumGenere.Classica} per scegliere {EnumGenere.Classica}");
            Console.WriteLine($"Premi {(int)EnumGenere.Pop} per scegliere {EnumGenere.Pop}");
            Console.WriteLine($"Premi {(int)EnumGenere.Rock} per scegliere {EnumGenere.Rock}");


            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
            {
                Console.WriteLine("Scelta non corretta, riprova.");
            }

            return (EnumGenere)scelta;
        }

        private static void VisualizzaPodcast()
        {
            foreach (Podcast p in podcastList) p.PrintInfo();
        }

        private static void VisualizzaCanzoni()
        {
            foreach (Canzoni c in canzoniList) c.PrintInfo(); 
            //ToDo: da sistemare la visualizzazione della data di nascita dell'autore
        }
    }
}
