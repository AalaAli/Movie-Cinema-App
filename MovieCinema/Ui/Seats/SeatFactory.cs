using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Seats
{
    public class SeatFactory
    {
        private readonly SeatFlyweightFactory flyFactory;

        public SeatFactory(SeatFlyweightFactory flyFactory)
        {
            this.flyFactory = flyFactory;
        }

        public Seat CreateSeat(
            int seatId,
            int hallId,
            int rowNumber,
            int seatNumber,
            string seatType,
            bool isAvailable)
        {
            SeatFlyweight flyweight = flyFactory.GetSeatType(seatType);

            return new Seat(
                seatId,
                hallId,
                rowNumber,
                seatNumber,
                flyweight,
                isAvailable
            );
        }
    }
}
