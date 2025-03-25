using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300137
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> videos;
        public string username;

        public SayaTubeUser(string username)
        {
            if (username == null || username.Length > 100)
            {
                throw new ArgumentException("Username tidak boleh kosong dan tidak boleh lebih dari 50 karakter");
            }
            Random random = new Random();
            this.id = random.Next(1000, 9999);
            this.username = username;
            this.videos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in videos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }


        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentException("Video tidak boleh kosong");
            }
            videos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("Total play count for user " + username + ": ");
            for(int i = 0; i < Math.Min(videos.Count, 8); i++)
            {
                Console.WriteLine($"Video {i+1} judul: {videos[i].getTitle()}");
            }
        }
    }
}
