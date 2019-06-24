using System;
using System.Collections.Generic;
using System.Text;

namespace Theatre
{
    [Flags]
    enum Genre
    {
        Unrated=0,
        Action=1,
        Romance=2, 
        Documentary=4, 
        Mystery=8, 
        Musical=16,
        Horror=32, 
        Comedy=64, 
        Fantasy=128, 
        Animation=256, 
        Adventure=512
    }
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<String> Cast { get; }
        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
            Cast = new List<String>();
        }
        public void AddActor(String actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre(Genre genre)
        {
            Genre |= genre;
        }
        public override string ToString()
        {
            return $"\tTitle: {Title}\n\tGenre: {Genre}\n\tYear: {Year}\n\tLength: {Length} Minutes\n\tCast: {string.Join(",",Cast)}";
        }
    }
}
