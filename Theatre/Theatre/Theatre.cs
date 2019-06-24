using System;
using System.Collections.Generic;
using System.Text;

namespace Theatre
{
    class Theatre
    {
        private List<Show> shows;
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            foreach (Show show in shows)
            {
                Console.WriteLine(show);
            }
        }
        public void PrintShows(Genre genre)
        {
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(Day day)
        {
            foreach (Show show in shows)
            {
                if (show.Day==day)
                {
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(Time time) //confirm before submission
        {
            foreach (Show show in shows)
            {
                if (show.Time.Hours==time.Hours)
                {
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(string actor)
        {
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(Day day,Time time)
        {
            foreach (Show show in shows)
            {
                if (show.Day==day&&show.Time==time)
                {
                    Console.WriteLine(show);
                }
            }
        }

    }
}
