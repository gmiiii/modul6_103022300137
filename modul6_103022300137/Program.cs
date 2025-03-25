namespace modul6_103022300137
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeUser user = new SayaTubeUser("Gumilar Hari Subagja");

                string[] films = new string[] { "The Avengers", "The Avengers: Age of Ultron", "The Avengers: Infinity War", "The Avengers: Endgame", "Fight Club", "Black Panther", "Captain America", "Maverick", "Transformers" };

                foreach (var film in films)
                {
                    string title = $"review Film {film} oleh Gumilar Hari Subagja";
                    SayaTubeVideo video = new SayaTubeVideo(title);

                    Random rnd = new Random();
                    video.increasePlayCount(rnd.Next(1000, 1000000));

                    user.AddVideo(video);
                }

                user.PrintAllVideoPlaycount();
                Console.WriteLine("Total play count: " + user.GetTotalVideoPlayCount());

                TestException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        static void TestException()
        {
            try
            {
                string longTitle = new string('a', 201);
                var video = new SayaTubeVideo(longTitle);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("test 1 berhasil: " + ex.Message);
            }

            try
            {
                var video = new SayaTubeVideo("Judul Film");
                video.increasePlayCount(-1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("test 2 berhasil: " + ex.Message);
            }
            try
            {
                var video = new SayaTubeVideo("Judul Film");
                for (int i = 0; i < 10; i++)
                {
                    video.increasePlayCount(int.MaxValue / 2);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("test 3 berhasil: " + ex.Message);
            }
        }
    }
}



