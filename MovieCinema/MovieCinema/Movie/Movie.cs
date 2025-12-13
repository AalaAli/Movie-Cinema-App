using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public class Movie
    {
        int MovieId;
        string Title;
        String Description;
        int Duration; // in minutes
        string PosterPath;
        float Rating;
        public Movie(int MvId, string Tit, string Desc, int Dur, string PstPth, float Rt)
        {
            MovieId = MvId;
            Title = Tit;
            Description = Desc;
            Duration = Dur; 
            PosterPath = PstPth;
            Rating = Rt;

        }
        public Movie CloneMovie()
        {
            return (Movie)this.MemberwiseClone();
        }

        public void DisplayMovieInfo()
        {
            Console.WriteLine($"MovieId: {MovieId} Title: {Title} Description: {Description} Duration: {Duration} PosterPath: {PosterPath} Rating: {Rating}");
        }
    }
   
}
