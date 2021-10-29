using System;
using System.Collections.Generic;

//Diego Hernandez
//Student ID: 301175438
namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie terminator = new Movie("Terminator 2: Judgement Day", 1991, 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(Genre.Horror | Genre.Action);
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, Day.Mon, 5.95, new Time(11, 35, 0));

            Console.WriteLine(s1);              //displays one object
            Theatre eglinton = new Theatre("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();              //displays one object

            Movie godzilla = new Movie("Godzilla 2014", 2014, 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(Genre.Action | Genre.Documentary | Genre.Comedy);

            Movie trancendence = new Movie("Transendence", 2014, 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(Genre.Comedy);
            eglinton.AddShow(new Show(trancendence, Day.Sun, 7.87, new Time(18, 5, 0)));

            Movie m1 = new Movie("The Shawshank Redemption", 1994, 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(Genre.Action);
            eglinton.AddShow(new Show(m1, Day.Sun, 8.87, new Time(14, 5, 0)));

            Movie avengers = new Movie("Avengers: Endgame", 2019, 120);
            avengers.AddActor("Robert Downey Jr.");
            avengers.AddActor("Chris Evans");
            avengers.AddActor("Chris Hemsworth");
            avengers.AddActor("Scarlett Johansson");
            avengers.AddActor("Mark Ruffalo");
            avengers.SetGenre(Genre.Action | Genre.Fantasy | Genre.Adventure);
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));

            m1 = new Movie("Olympus Has Fallen", 2013, 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(Genre.Action);
            eglinton.AddShow(new Show(m1, Day.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("The Mask of Zorro", 1998, 136);
            m1.AddActor("Antonio Banderas");
            m1.AddActor("Anthony Hopkins");
            m1.AddActor("Catherine Zeta-Jones");
            m1.SetGenre(Genre.Action | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("Four Weddings and a Funeral", 1994, 117);
            m1.AddActor("Hugh Grant");
            m1.AddActor("Andie MacDowell");
            m1.AddActor("Kristin Scott Thomas");
            m1.SetGenre(Genre.Comedy | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sat, 8.87, new Time(15, 5, 0)));
            eglinton.AddShow(new Show(m1, Day.Tue, 6.50, new Time(16, 5, 0)));

            m1 = new Movie("You've Got Mail", 1998, 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(Genre.Comedy | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sat, 8.87, new Time(15, 5, 0)));

            m1 = new Movie("The Poison Rose", 2019, 98);
            m1.AddActor("John Travolta");
            m1.AddActor("Morgan Freeman");
            m1.AddActor("Brendan Fraser");
            m1.SetGenre(Genre.Action | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sun, 10.25, new Time(22, 5, 0)));

            Movie car3 = new Movie("Cars 3", 2017, 109);
            car3.AddActor("Owen Williams");
            car3.AddActor("Cristela Alonzo");
            car3.AddActor("Arnie Hammer");
            car3.AddActor("Chris Cooper");
            car3.SetGenre(Genre.Comedy | Genre.Animation | Genre.Romance);
            eglinton.AddShow(new Show(car3, Day.Sat, 6.40, new Time(09, 55, 0)));
            eglinton.AddShow(new Show(car3, Day.Sat, 6.50, new Time(11, 05, 0)));

            Movie toys4 = new Movie("Toys Story 4", 2019, 89);
            toys4.AddActor("Keanu Reeves");
            toys4.AddActor("Christina Hendricks");
            toys4.AddActor("Tom Hanks");
            toys4.AddActor("Tim Allen");
            toys4.SetGenre(Genre.Comedy | Genre.Fantasy | Genre.Animation);
            eglinton.AddShow(new Show(toys4, Day.Sat, 6.40, new Time(14, 10)));

            eglinton.AddShow(new Show(godzilla, Day.Mon, 6.89, new Time(13, 55, 0)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));
            eglinton.AddShow(new Show(godzilla, Day.Sun, 6.89, new Time(14, 0)));
            eglinton.AddShow(new Show(toys4, Day.Sat, 6.40, new Time(14, 10)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));
            eglinton.AddShow(new Show(godzilla, Day.Sun, 6.89, new Time(16, 55, 0)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));
            eglinton.AddShow(new Show(m1, Day.Sat, 10.25, new Time(20, 35, 0)));
            eglinton.AddShow(new Show(godzilla, Day.Wed, 8.50, new Time(22, 5)));
            eglinton.AddShow(new Show(avengers, Day.Tue, 10.75, new Time(20, 30)));
            eglinton.AddShow(new Show(godzilla, Day.Thu, 8.50, new Time(20, 15)));
            eglinton.AddShow(new Show(avengers, Day.Wed, 10.75, new Time(20, 30)));
            eglinton.AddShow(new Show(godzilla, Day.Fri, 8.50, new Time(18, 25)));
            eglinton.AddShow(new Show(avengers, Day.Sun, 10.75, new Time(14, 15)));

            eglinton.PrintShows();                              //displays 27 objects
            eglinton.PrintShows(Day.Sun);                       //displays 8 objects
            eglinton.PrintShows(Genre.Action);                  //displays 19 objects
            eglinton.PrintShows(Genre.Romance);                 //displays 8 objects
            eglinton.PrintShows(Genre.Action | Genre.Romance);  //displays 3 objects
            eglinton.PrintShows("Morgan Freeman");              //displays 5 objects

            Time time = new Time(14, 05, 0);
            eglinton.PrintShows(time);                          //displays 6 objects

            eglinton.PrintShows(Day.Sun, time);                 //displays 3 objects
        }
    }
}

public enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat }

[Flags]
public enum Genre
{
    Unrated = 0x0,
    Action = 0x1,
    Adventure = 0x2,
    Animation = 0x4,
    Comedy = 0x8,
    Documentary = 0x10,
    Fantasy = 0x20,
    Horror = 0x40,
    Musical = 0x80,
    Mystery = 0x100,
    Romance = 0x200
}

struct Time
{

    public int Hours { get; }
    public int Minutes { get; }



    public Time(int hours, int minutes = 0, int aux = 0)
    {
        this.Hours = hours;
        this.Minutes = minutes;
    }

    public override string ToString()
    {
        return $"{Hours}:{Minutes:d2}";
    }

    public static bool operator ==(Time lhs, Time rhs)
    {
        bool state;
        int totalMinLhs = (lhs.Hours * 60) + lhs.Minutes;
        int totalMinRhs = (rhs.Hours * 60) + rhs.Minutes;
        if (Math.Abs(totalMinLhs - totalMinRhs) < 15 || Math.Abs(totalMinRhs - totalMinLhs) < 15) state = true;
        else state = false;
        return state;
    }

    public static bool operator !=(Time lhs, Time rhs)
    {
        bool state;
        int totalMinLhs = (lhs.Hours * 60) + lhs.Minutes;
        int totalMinRhs = (rhs.Hours * 60) + rhs.Minutes;
        if ((totalMinLhs - totalMinRhs < 15 || (totalMinRhs - totalMinLhs) < 15)) state = false;
        else state = true;
        return state;
    }

}

class Movie
{

    public int Lenght { get; }
    public int Year { get; }
    public string Title { get; }
    public Genre Genre { get; private set; }
    public List<string> Cast;

    public Movie(string name, int year, int lenght)
    {
        Title = name;
        Year = year;
        Lenght = lenght;

        Cast = new List<string>();
    }

    public void AddActor(string actor)
    {
        Cast.Add(actor);
    }

    public void SetGenre(Genre genre)
    {
        this.Genre = genre;
    }

    public override string ToString()
    {
        return $"{Title} ({Year}) {Lenght} min ({Genre}), {string.Join(",", Cast)}";
    }
}

struct Show
{

    public double Price { get; }
    public Day Day { get; }
    public Movie Movie { get; }
    public Time Time { get; }

    public Show(Movie movie, Day day, double price, Time time)
    {
        Price = price;
        Day = day;
        Movie = movie;
        Time = time;
    }

    public override string ToString()
    {
        return $"{Day} {Time} {Movie} ${Price}";

    }
}

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
        Console.WriteLine($"\n{Name}");
        Console.WriteLine($"All shows");
        Console.WriteLine("==================");
        int i = 1;
        foreach (Show show in shows)
        {
            Console.WriteLine($"{i++}: { show}");
        }
    }

    public void PrintShows(Genre genre)
    {
        Console.WriteLine($"\n{Name}");
        Console.WriteLine($"{genre} movies");
        Console.WriteLine("==================");
        int i = 1;
        foreach (Show show in shows)
        {
            if (show.Movie.Genre.HasFlag(genre)) Console.WriteLine($"{i++}: { show}");
        }
    }

    public void PrintShows(Day day)
    {

        Console.WriteLine($"\n{Name}");
        Console.WriteLine($"movies on {day}");
        Console.WriteLine("==================");
        int i = 1;
        foreach (Show show in shows)
        {
            if (show.Day == day) Console.WriteLine($"{i++}: { show}");
        }
    }

    public void PrintShows(Time time)
    {
        Console.WriteLine($"\n{Name}");
        Console.WriteLine($"movies @{time}");
        Console.WriteLine("==================");
        int i = 1;
        foreach (Show show in shows)
        {
            if (show.Time == time) Console.WriteLine($"{i++}: { show}");
        }
    }

    public void PrintShows(string actor)
    {
        Console.WriteLine($"\n{Name}");
        Console.WriteLine($"{actor} movies");
        Console.WriteLine("==================");
        int i = 1;
        foreach (Show show in shows)
        {
            if (show.Movie.Cast.Contains(actor)) Console.WriteLine($"{i++}: { show}");
        }
    }

    public void PrintShows(Day day, Time time)
    {
        Console.WriteLine($"\n{Name}");
        Console.WriteLine($"{day} movies @ {time}");
        Console.WriteLine("==================");
        int i = 1;
        foreach (Show show in shows)
        {
            if (show.Day == day && show.Time == time) Console.WriteLine($"{i++}: { show}");
        }
    }





}


