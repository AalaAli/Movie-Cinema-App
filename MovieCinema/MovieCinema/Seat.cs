using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public abstract  class Seat
    {
         int SeatId;
         int HallId;
         int RowNumber;
         int SeatNumber;
         string SeatType;
         bool IsAvailable;
        public Seat(int StId, int HId, int RwNum, int StNum,string StType, bool IsAv) {
            SeatId = StId;
            HallId = HId;
            RowNumber = RwNum;
            SeatNumber = StNum;
            SeatType = StType;
            IsAvailable = IsAv;
        }
        public void Display()
        {
            Console.WriteLine($"Seat ID: {SeatId}, Hall ID: {HallId}, Row Number: {RowNumber}, Seat Number: {SeatNumber}, Seat Type: {SeatType}, Is Available: {IsAvailable}");
        }
    }
   class VIPSeat: Seat
    {

        public VIPSeat(int StId, int HId, int RwNum, int StNum, string StType, bool IsAv) : base(StId, HId, RwNum, StNum, StType, IsAv)
        {
        }

    }
    class StandardSeat: Seat
    {
       public StandardSeat(int StId, int HId, int RwNum, int StNum, string StType, bool IsAv) : base(StId, HId, RwNum, StNum, StType, IsAv)
        {

        }
    }
     public class SeatFactory
    {
        public Seat CreateSeat(int StId, int HId, int RwNum, int StNum, string StType, bool IsAvstring )
        {
            switch (StType.ToLower())
            {
                case "vip":
                   return new VIPSeat(StId, HId, RwNum, StNum, StType, IsAvstring);
                case "standard":
                    return new StandardSeat(StId, HId, RwNum, StNum, StType, IsAvstring);
                default:
                    throw new ArgumentException("Invalid seat type");
            }
        }
    }
}
