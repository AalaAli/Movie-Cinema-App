using MovieCinema.Genres;
using MovieCinema.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MovieCinema.Repositories;
using MovieCinema.Actors;
namespace MovieCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ticket T1 = new Ticket();
            TicketProxy TP1 = new TicketProxy(T1);
            T1 = TP1.CreateTicket(1, 101, 1800, 12, 15.50, DateTime.Now, true);
            TP1.PrintTicket();

            Movie M1 = new Movie(1, "Inception", "A mind-bending thriller", 148, "/path/to/poster.jpg", 8.8f);
            M1.DisplayMovieInfo();
            Movie M2 = M1.CloneMovie();
            M2.DisplayMovieInfo();

            var G = new GenreComponent(1, "Action");
            var G1 = new GenreGroup(4, "Popular Genre: ");
            G1.AddGenre(G);
            G1.AddGenre(new GenreComponent(2, "Comedy"));
            G1.AddGenre(new GenreComponent(3, "Drama"));
            G1.AddGenre(new GenreComponent(5, "Horror"));
            G.DisplayGenre();
            G1.DisplayGenre();*/

            string ConnectionString="server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";

            IRepository<Hall> H = new HallRepository(ConnectionString);
            IRepository<Movie> M = new MovieRepository(ConnectionString);
            Movie m = new Movie(0, "The help", "A Dramatic Movie", 2012, 120, "\\C:\\images", 4.2m);
          Movie movie = M.GetById(4);
          
            //Hall hall= H.GetById(2);
            // Console.WriteLine($"HallId:{hall.GetHallId()} HallName:{hall.GetHallName()} CinemaId:{hall.GetCinemaId()} Seatcount:{hall.GetSeatCount()}");

            /*            H.Delete(5);
            */
            //        H.Update(new Hall(2, "H2", 2, 10));

            // IRepository<Actor> AR = new ActorRepository(ConnectionString);
              IRepository<GenreComponent> Gn = new GenreRepository(ConnectionString);
             GenreComponent genre = new Genre(1,"Action");

            //     Console.WriteLine($"GenreId; {g.GetGenreId()} GenreName: {g.GetGenreName()}");

            Gn.Add(genre);
             Gn.Update(new Genre(2, "Drama"));
             IEnumerable<GenreComponent> genres =Gn.GetAll();
               foreach (var g in genres)
               {
               Console.WriteLine($"GenreId; {g.GetGenreId()} GenreName: {g.GetGenreName()}");
                }
            //Gn.Delete(1);
            /*            IRepository<Actor>AR= new ActorRepository(ConnectionString);
                           Actor a= new Actor(1, "Leonardo DiCaprio", "An American actor and producer.", new DateTime(1974, 11, 11));
                        AR.Add(a);
                        Actor actor = AR.GetById(2);
                         Console.WriteLine($"ID: {actor.GetActorId()}, Name: {actor.GetActorName()}, Bio: {actor.GetBio()}, Birth Date: {actor.GetBirthDate().ToShortDateString()}");
                                    List<Actor> actors = AR.GetAll();
             */



            // AR.Update(new Actor(2, "Leonardo", "An American actor and environmental activist.", new DateTime(1985, 11, 11)));
            //AR.Add(a);
            //AR.Delete(1);
            //User u1 = new User(2, "Aala", "0000", "aala@gmail.com", "0915963905");
            // UR.Add(u1);
            //UR.Delete(2);
            // User u2 = new User(3, "Malak", "0000", "malak@gmail.com", "0915963905");
            //UR.Update(u2);
            // List<User> users = UR.GetAll();
            /*  foreach (User user in users)
              {
                  Console.WriteLine($"ID: {user.GetUserId()}, Name: {user.GetUserName()}, Email: {user.GetEmail()}, Phone: {user.GetPhone()}");
              }*/

            //User u = UR.GetById(3);
            //Console.WriteLine($"ID: {u.GetUserId()}, Name: {u.GetUserName()}, Email: {u.GetEmail()}, Phone: {u.GetPhone()}");

        }
    }
}
