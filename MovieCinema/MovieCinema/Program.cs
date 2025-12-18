using MovieCinema.Actors;
using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using MovieCinema.Seats;
using MovieCinema.ShowTimes;
using MovieCinema.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MovieCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flyweightFactory = new SeatFlyweightFactory();
            var seatFactory = new SeatFactory(flyweightFactory);

            Seat seat1 = seatFactory.CreateSeat(1, 2, 5, 10, "VIP", true);
            Seat seat2 = seatFactory.CreateSeat(2, 1, 5, 11, "VIP", true);
            Seat seat3 = seatFactory.CreateSeat(3, 1, 6, 1, "Standard", true);

            seat1.DisplaySeatInfo();
            seat2.DisplaySeatInfo();
            seat3.DisplaySeatInfo();
            string ConnectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            IRepository<ShowTime> showTimeRepo = new ShowTimeRepository(ConnectionString);
            var showTimeService = new ShowTimeService(showTimeRepo);

           //Add showTime
            showTimeService.CreateShowTime(
                movieId: 4,
                hallId:2,
                start: DateTime.Today.AddHours(18),
                end: DateTime.Today.AddHours(20),
                price: 10m,
                language: "English"
            );

            // إضافة عرض متعارض
            showTimeService.CreateShowTime(
                movieId: 4,
                hallId: 2,
                start: DateTime.Today.AddHours(19),
                end: DateTime.Today.AddHours(21),
                price: 12m,
                language: "English"
            );

            // جلب العروض
            var shows = showTimeService.GetShowTimesByMovie(1);

            foreach (var s in shows)
            {
                Console.WriteLine($"{s.StartTime:t} - {s.EndTime:t} | {s.Price}$");
            }
        }
    }

}
  


