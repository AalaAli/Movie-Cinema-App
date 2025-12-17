using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public class ShowTime
    {
        int ShowTimeId;
        int MovieId;
        int HallId;
        DateTime StartTime;
        DateTime EndTime;
        decimal Price;
        string Language;
        public ShowTime(int showTimeId, int movieId, int hallId, DateTime startTime, DateTime endTime, decimal price, string language)
        {
            ShowTimeId = showTimeId;
            MovieId = movieId;
            HallId = hallId;
            StartTime = startTime;
            EndTime = endTime;
            Price = price;
            Language = language;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(
                $"MovieId: {MovieId}, HallId: {HallId}, " +
                $"Start: {StartTime}, End: {EndTime}, " +
                $"Price: {Price}, Language: {Language}"
            );
        }
        public int GetShowTimeId() => ShowTimeId;
        public int GetMovieId() => MovieId;
        public int GetHallId() => HallId;
        public DateTime GetStartTime() => StartTime;
        public DateTime GetEndTime() => EndTime;
        public decimal GetPrice() => Price;
        public string GetLanguage() => Language;

    }
}
