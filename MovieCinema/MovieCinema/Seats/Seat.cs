using MovieCinema.Seats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public class Seat
    {
        public int SeatId { get; }
        public int HallId { get; }
        public int RowNumber { get; }
        public int SeatNumber { get; }

        public SeatFlyweight SeatTypeRef { get; }
        public bool IsAvailable { get; private set; }

        public Seat(
            int seatId,
            int hallId,
            int rowNumber,
            int seatNumber,
            SeatFlyweight seatTypeRef,
            bool isAvailable)
        {
            SeatId = seatId;
            HallId = hallId;
            RowNumber = rowNumber;
            SeatNumber = seatNumber;
            SeatTypeRef = seatTypeRef;
            IsAvailable = isAvailable;
        }

        public bool Reserve()
        {
            if (!IsAvailable)
                return false;

            IsAvailable = false;
            return true;
        }

        public void CancelReservation()
        {
            IsAvailable = true;
        }

        public void DisplaySeatInfo()
        {
            Console.WriteLine(
                $"SeatId: {SeatId}, Hall: {HallId}, Row: {RowNumber}, Number: {SeatNumber}, Available: {IsAvailable}");
            SeatTypeRef.ShowFlyweightInfo();
        }
        public int GetSeatId() => SeatId;
        public int GetHallId() => HallId;
        public int GetRowNumber() => RowNumber;
        public int GetSeatNumber() => SeatNumber;
        public string GetSeatType() => SeatTypeRef.TypeName;
        public bool GetIsAvailable() => IsAvailable;

    }

}
