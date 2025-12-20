using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public abstract class GenreComponent
    {
        internal int GenreId;

        internal string GenreName;

        internal int ?ParentId;

        public GenreComponent() { }
        public GenreComponent(int genreId, string genreName, int ?parentId)
        {
            GenreId = genreId;
            GenreName = genreName;
            ParentId = parentId;
        }
        public abstract void DisplayGenre();
        public abstract bool IsLeaf();
        public abstract int GetGenreId();
        public abstract string GetGenreName();
        public abstract int ?GetParentId();

    }

    }
