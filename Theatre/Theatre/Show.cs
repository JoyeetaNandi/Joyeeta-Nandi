using System;
using System.Collections.Generic;
using System.Text;

namespace Theatre
{
    enum Day
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }
    class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie,Day day,double price,Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }
        public override string ToString()
        {
            return $"Movie information \n{Movie}\nShow Information \n\tDay: {Day}\n\tPrice: {Price:C2}\n\tTime: {Time}\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++";
        }
    }
}
