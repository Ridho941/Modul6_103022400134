using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Modul6_103022400134
{
    internal class SayaMusicUser
    {
        private int id;
        public string Username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(string title)
        {
            Contract.Requires(Username.Length <= 100);
            Contract.Requires(Username != null);
            this.Username = Username;
            this.uploadedTracks = new List<SayaMusicTrack>();
        }

        public int GetTotalPlayCount()
        {
            int totalPlayCount = 0;
            return totalPlayCount;
        }

        public void AddTrack(SayaMusicTrack track)
        {

        }

        public void PrintAllTracks()
        {

        }
    }
}
