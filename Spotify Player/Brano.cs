using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player
{
    internal class Brano : IContenutoRiproducibile
    {
        public string nome;
        public int durata;
        public string artist;
        public string album;

            public Brano (string nome, int durata, string artist, string album)
        {
            this.nome = nome;
            this.durata = durata;
            this.artist = artist;
            this.album = album;
        }
        
        public void PlayMethod()
        {
            Console.WriteLine("Riproduzione del brano Billie Jean di Michael Jackson");
    }
    }

  public void PauseMethod()
    {
        Console.WriteLine("Messo in pausa il brano Billie Jean di Michael Jackson");
    }

    public void StopMethod()
    {
        Console.WriteLine("Messo in stop il brano Billie Jean di Michael Jackson e riavvolto all'inizio del brano");
    }
}