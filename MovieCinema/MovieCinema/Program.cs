using MovieCinema.Genr;
using MovieCinema.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ticket T1 =new Ticket();
            TicketProxy TP1=new TicketProxy(T1);
            T1=TP1.CreateTicket(1,101,1800,12,15.50,DateTime.Now,true);
            TP1.PrintTicket();

            Movie M1=new Movie(1,"Inception","A mind-bending thriller",148,"/path/to/poster.jpg",8.8f);
            M1.DisplayMovieInfo();
            Movie M2=M1.CloneMovie();
            M2.DisplayMovieInfo();

            var G = new GenreComponent(1, "Action");
            var G1=new GenreGroup(4,"Popular Genre: ");
            G1.AddGenre(G);
            G1.AddGenre(new GenreComponent(2,"Comedy"));
            G1.AddGenre(new GenreComponent(3, "Drama"));
            G1.AddGenre(new GenreComponent(5, "Horror"));
            G.DisplayGenre();
            G1.DisplayGenre();*/
            Movie m1=new Movie(1,"Inception","cool movie", 120,"C:\\", 4.5f);
            Movie m2=new Movie(2,"The Dark Knight","great movie", 150,"C:\\", 4.8f);
            Movie m3=new Movie(3,"Interstellar","amazing movie", 180,"C:\\", 4.7f);
            m1.AddGenre(new Genre(1,"Action"));
            m2.AddGenre(new Genre(1,"Action"));//add component
            m3.AddGenre(new Genre ( 2, "Sci-Fi"));

            List<Movie> movies = new List<Movie>();
            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);

            SearchStrategy s = new SearchByTitleStrategy();

            MovieSearchContext m = new MovieSearchContext(s);
          List<Movie> result = m.Search("The Dark Knight", movies);

            foreach (Movie movie in result)
            {
                movie.DisplayMovieInfo();
            }
            }
    }
}
