using System.Collections.Generic;
using System.Collections.Immutable;

namespace MvcMovie.Models
{
    public static class Genres
    {
        public static readonly List<string> values = new List<string>{
            "Action",
            "Adventure",
            "Biography",
            "Comedy",
            "Drama",
            "Documentary",
            "Period Drama",
            "Romance",
            "Historical Fiction"
        };

        public static List<string> GetGenres()
        {
            List<string> sortedValues = new List<string>(values);
            sortedValues.Sort();
            return sortedValues;
        }

    }
}
