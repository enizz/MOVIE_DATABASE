using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE_DATABASE
{
    public class Movie
    {
        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }


        public string Title { get; set; }
        public string Category { get; set; }

    }





}
