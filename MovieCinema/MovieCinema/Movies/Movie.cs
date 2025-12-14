using MovieCinema.Actors;
using MovieCinema.Genr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public  class Movie
    {
        internal int MovieId { get; set; }
        internal string Title;
        internal String Description;
        internal int Duration; // in minutes
        internal string PosterPath;
        internal float Rating;
        internal List<Genre> Genres;
        internal List<Actor> Actors;
        public Movie() { }
        public  Movie(int MvId, string Tit, string Desc, int Dur, string PstPth, float Rt)
        {
            MovieId = MvId;
            Title = Tit;
            Description = Desc;
            Duration = Dur; 
            PosterPath = PstPth;
            Rating = Rt;
            Genres = new List<Genre>();
            Actors = new List<Actor>();

        }
        public void AddGenre(Genre Genre)
        {
            if(Genre.IsLeaf())
                Genres.Add(Genre);
        }
        public void AddActor(Actor Actor)
        {
            Actors.Add(Actor);
        }
        public void RemoveGenre(Genre Genre)
        {
            Genres.Remove(Genre);
        }
        public List<Genre> GetGenres()
        {
            return Genres;
        }
        public List<Actor> GetActors()
        {
            return Actors;
        }
        public string GetDescription()
        {
            return Description;
        }
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
