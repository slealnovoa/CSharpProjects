using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwitterApp.Models
{
    static class TweetManager
    {
        private static List<Tweet> tweets;
        private static string filename;

        static TweetManager()
        {
            tweets = new List<Tweet>();
            filename = @"..\..\TweetFile.txt";

            using (StreamReader file = new StreamReader(filename))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    tweets.Add(Tweet.Parse(line));
                }

                file.Close();
            }
        }

        public static void Initialize(string line)
        {
            tweets.Add(new Tweet("Ford", "Trudeau", "Bieber", "Go Raptors! Go!"));
            tweets.Add(new Tweet("WeTheNorth", "Drake", "Obama", "Go Raptors! Go!"));
            tweets.Add(new Tweet("Raptors", "Tory", "Drake", "Yes Toronto will get them!"));
            tweets.Add(new Tweet("Ford", "Trudeau", "Obama", "Toronto joins cities around the world to celebrate International Day Against Homophobia & Transphobia"));
            tweets.Add(new Tweet("Ford", "Drake", "Bieber", "Go Raptors! Go!"));
        }

        public static void ShowAll()
        {
            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine($"{tweet}\n\n");
            }
        }

        public static void ShowAll(string tag)
        {
            for (int i = 0; i < tweets.Count; i++)
            {
                if (tweets.ElementAt(i).Tag.Equals(tag))
                    Console.WriteLine(tweets.ElementAt(i).ToString());
            }
        }
    }

}
