using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    internal class Cinema
    {
        int CinemaId;
        string CinemaName;
        string Address;

        public Cinema (int cinemaId, string cinemaName, string address)
        {
            CinemaId = cinemaId;
            CinemaName = cinemaName;
            Address = address;
        }
        public int GetCinemaId() => CinemaId;
        public string GetCinemaName()=> CinemaName;
        public string GetAddress() => Address;
    }
}
