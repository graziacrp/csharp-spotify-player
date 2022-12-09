using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player
{
    internal class Podcast : IContenutoRiproducibile
    {
        public string nome;
        public string autore;
        public int durata;
        public Podcast (string nome, string autore, int durata)
        {
            this.nome = nome;
            this.autore = autore;
            this.durata = durata;
        }
       
        
        public static void PlayMethod()
        {
            Console.WriteLine("Riproduzione del podcast Un uomo di Oriana Fallaci");
        }

    }
    public static void StopMethod()
    {
        Console.WriteLine("Messo in stop il podcast Un uomo di Oriana Fallaci");
    }

    public static void PauseMethod()
    {
        Console.WriteLine("Messo in pausa il podcast Un uomo di Oriana Fallaci");
    }
}
