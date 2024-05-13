using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreProgram
{
    enum MovieDay
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }

    enum MovieGenre
    {
        Unrated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        Mystery = 8,
        Musical = 16,
        Horror = 32,
        Comedy = 64
    }

    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes + ":" + Seconds;
        }
    }

    class Movie
    {
        public int Length { get; set; }
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
        public List<string> Cast { get; set; }

        public Movie(string title, int length)
        {
            this.Title = title;
            this.Length = length;
            Cast = new List<string>();
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(MovieGenre genre)
        {
            this.Genre = genre;
        }

        public override string ToString()
        {
            string toReturn;
            toReturn = "Title: " + Title + "\n";
            toReturn += "Genre: " + Genre + "\n";
            toReturn += "Length: " + Length + "\n";
            toReturn += "Actors: ";
            foreach (string actor in Cast)
            {
                toReturn += actor + " ";
            }

            return toReturn;
        }
    }

    class Show
    {
        public double Price { get; set; }
        public MovieDay Day { get; set; }
        public Movie Movie { get; set; }
        public Time Time { get; set; }

        public Show(Movie movie, MovieDay day, double price, Time time)
        {
            this.Movie = movie;
            this.Day = day;
            this.Price = price;
            this.Time = time;
        }

        public override string ToString()
        {
            string toReturn = "Movie: \n" + Movie.ToString() + "\n";
            toReturn += "Day: " + Day + "\n";
            toReturn += "Price: " + Price + "\n";
            toReturn += "Time: " + Time + "\n";

            return toReturn;
        }
    }

    class Theater
    {
        public List<Show> Shows { get; set; }
        public string Name { get; set; }

        public Theater(string name)
        {
            this.Name = name;
            Shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            this.Shows.Add(show);
        }

        public void PrintShows()
        {
            foreach (Show show in Shows)
            {
                Console.WriteLine(show);
            }
        }

        public void PrintShows(MovieGenre genre)
        {
            foreach (Show show in Shows)
            {
                if (show.Movie.Genre == genre)
                    Console.WriteLine(show);
            }
        }

        public void PrintShows(MovieDay day)
        {
            foreach (Show show in Shows)
            {
                if (show.Day == day)
                    Console.WriteLine(show);
            }
        }

        public void PrintShows(Time time)
        {
            foreach (Show show in Shows)
            {
                if (show.Time == time)
                    Console.WriteLine(show);
            }
        }

        public void PrintShows(string actor)
        {
            foreach (Show show in Shows)
            {
                if (show.Movie.Cast.Contains(actor))
                    Console.WriteLine(show);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Movie terminator = new Movie("Judgement Day", 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(MovieGenre.Horror | MovieGenre.Action);
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, MovieDay.Mon, 5.95, new Time(11, 35, 0));

            Console.WriteLine(s1);
            Theater eglinton = new Theater("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();                                   //displays one object

            Movie godzilla = new Movie("Godzilla 2014", 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(MovieGenre.Action);

            Movie trancendence = new Movie("Transendence", 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(MovieGenre.Comedy);
            eglinton.AddShow(new Show(trancendence, MovieDay.Sun, 7.87, new Time(18, 5, 0)));

            Movie m1 = new Movie("The Shawshank Redemption", 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(MovieGenre.Action);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(14, 5, 0)));


            m1 = new Movie("Olympus Has Fallen", 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(MovieGenre.Action);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("The Mask of Zorro", 136);
            m1.AddActor("Antonio Banderas");
            m1.AddActor("Anthony Hopkins");
            m1.AddActor(" Catherine Zeta-Jones");
            m1.SetGenre(MovieGenre.Action | MovieGenre.Romance);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("Four Weddings and a Funeral", 117);
            m1.AddActor("Hugh Grant");
            m1.AddActor("Andie MacDowell");
            m1.AddActor("Kristin Scott Thomas");
            m1.SetGenre(MovieGenre.Comedy | MovieGenre.Romance);
            eglinton.AddShow(new Show(m1, MovieDay.Sat, 8.87, new Time(15, 5, 0)));

            m1 = new Movie("You've Got Mail", 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(MovieGenre.Comedy | MovieGenre.Romance);
            eglinton.AddShow(new Show(m1, MovieDay.Sat, 8.87, new Time(15, 5, 0)));

            Show s2 = new Show(godzilla, MovieDay.Mon, 6.89, new Time(13, 15, 0));
            eglinton.AddShow(s2);

            s2 = new Show(godzilla, MovieDay.Sun, 6.89, new Time(14, 15, 0));
            eglinton.AddShow(s2);

            s2 = new Show(godzilla, MovieDay.Sun, 6.89, new Time(16, 55, 0));
            eglinton.AddShow(s2);

            eglinton.PrintShows();                                       //displays ten objects

            eglinton.PrintShows(MovieDay.Sun);                           //displays six objects

            eglinton.PrintShows(MovieGenre.Action);                      //displays seven objects

            eglinton.PrintShows(MovieGenre.Romance);                     //displays three objects

            eglinton.PrintShows(MovieGenre.Action | MovieGenre.Romance); //displays one object

            eglinton.PrintShows("Morgan Freeman");                       //displays three objects

            eglinton.PrintShows(new Time(14, 30, 0));                    //displays two objects

            Console.ReadKey();

        }


    }
}
