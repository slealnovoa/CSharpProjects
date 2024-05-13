using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApp.Models;

namespace TwitterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TweetManager.Initialize("0");
            TweetManager.ShowAll();
            TweetManager.ShowAll("Raptors");

            Console.ReadKey();
        }
    }
}
