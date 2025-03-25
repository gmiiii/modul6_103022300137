using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300137
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 200) 
            {
                throw new ArgumentException("Judul tidak boleh kosong dan tidak boleh lebih dari 200 karakter");
            }
            Random random = new Random();
            this.id = random.Next(1000, 9999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
            {
                throw new ArgumentException("Invalid play count: error increment");
            }

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Invalid play count: Play count overflow");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Video Title: " + title);
            Console.WriteLine("Video Play Count: " + playCount);
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return title;
        }
    }
}
