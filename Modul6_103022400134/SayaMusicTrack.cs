using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Modul6_103022400134
{
    internal class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;
        
        public SayaMusicTrack(string title)
        {
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 200);
            this.title = title;

            Random rand = new Random();
            id = rand.Next(10000, 99999);

            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(playCount <= 25000000);
            Contract.Requires(playCount > 0);
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
