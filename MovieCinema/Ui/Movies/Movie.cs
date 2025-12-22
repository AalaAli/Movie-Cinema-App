using MovieCinema.Actors;
using MovieCinema.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public  class Movie
    {
        internal int MovieId { get; set; }
        internal string Title;
        internal String Description;
        internal int ReleaseYear;
        internal int Duration; // in minutes
        internal string PosterPath;
        internal decimal Rating;
        internal IEnumerable<GenreComponent> Genres;
        internal List<Actor> Actors;
        public Movie() { }
        public  Movie(int MvId, string Tit, string Desc,int releasYear, int Dur, string PstPth, decimal Rt)
        {
            MovieId = MvId;
            Title = Tit;
            Description = Desc;
            ReleaseYear = releasYear;
            Duration = Dur; 
            PosterPath = PstPth;
            Rating = Rt;
            Genres = new List<GenreComponent>();
            Actors = new List<Actor>();

        }
        public void AddGenres(IEnumerable<GenreComponent> genres)
        {
                this.Genres=genres;
        }

        public int GetMovieId()=> MovieId;
        public string GetTitle() => Title;
        public string GetDescription() => Description;
        public int GetReleaseYear() => ReleaseYear;
        public int GetDuration() => Duration;
        public string GetPosterPath()=> PosterPath;
        public decimal GetRating() => Rating;
        public IEnumerable<GenreComponent> GetGenres() => Genres; 
        public List<Actor> GetActors() => Actors;

        public bool HasGenre(string GenreName)
        {
            foreach(var genre in Genres)
            {
                if (genre.GenreName == GenreName)
                    return true;
            }
            return false;
        }
        public bool HasActor(string Actor)
        {
            foreach (var actor in Actors)
            {
                if (actor.ActorName == Actor)
                    return true;
            }
            return false;
        }

        public Movie Clone()
        {
            return (Movie)this.MemberwiseClone();
        }

        public void DisplayMovieInfo()
        {
            Console.WriteLine($"MovieId: {MovieId} Title: {Title} Description: {Description} Duration: {Duration} PosterPath: {PosterPath} Rating: {Rating}");
            foreach(var genre in Genres)
            {
                Console.WriteLine($"Genre: {genre.GenreName}");
            }
        }
    }
   
}
