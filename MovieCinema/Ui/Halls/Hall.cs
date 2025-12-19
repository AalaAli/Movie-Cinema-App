using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCinema;
namespace MovieCinema
{
    public class Hall
    {
        int HallId;
        string HallName;
        int CinemaId;
        int SeatCount;
        public Hall(int hallId, string hallName, int cinemaId, int seatCount)
        {
            HallId = hallId;
            HallName = hallName;
            CinemaId = cinemaId;
            SeatCount = seatCount;
        }
        public int GetHallId() => HallId;
        public string GetHallName() => HallName;
        public int GetCinemaId() => CinemaId;
        public int GetSeatCount() => SeatCount;


    }
}
