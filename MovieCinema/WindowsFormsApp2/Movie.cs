using System.Collections.Generic;

namespace Ui
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public string PosterPath { get; set; }
        public decimal Rating { get; set; }
        public List<string> Actors { get; set; } = new List<string>();
        public List<string> Genres { get; set; } = new List<string>();

        public Movie(int id, string title, string desc, int year, string poster, decimal rating)
        {
            MovieId = id;
            Title = title;
            Description = desc;
            ReleaseYear = year;
            PosterPath = poster;
            Rating = rating;
        }
    }
}