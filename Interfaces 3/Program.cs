using System;

class Program
{
    static void Main(string[] args)
    {
        Piano piano = new Piano();
        Guitar guitar = new Guitar();
         piano.Play();
         guitar.Play();
    }

    public interface IPlayable
    {
        void Play();
    }

    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("GUITAR IS NOW PLAYING!");
        }
    }

    public class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("PIANO IS NOW PLAYING!");
        }
    }
}
