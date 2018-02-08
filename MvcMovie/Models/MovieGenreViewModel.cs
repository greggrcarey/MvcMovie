using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public SelectList genres;
        public List<Movie> movies;
        public string movieGenre { get; set; }
    }
}