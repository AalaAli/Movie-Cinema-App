using System.Collections.Generic;
using System.Linq;
using Ui;

namespace Ui
{
    public interface ISearchStrategy
    {
        List<Movie> Search(string query, List<Movie> movies);
    }




    public class SearchByTitle : ISearchStrategy
    {
        public List<Movie> Search(string query, List<Movie> movies) =>
            movies.Where(m => m.Title.ToLower().StartsWith(query.ToLower().Trim())).ToList();
    }
}