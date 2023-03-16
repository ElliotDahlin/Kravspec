using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kravspec
{
    internal class Movie
    {
        
        public string Title { get; set; }
        public string Director { get; set; }
        public string Moviereldate { get; set; }

        public string Rating { get; set; }

        public Movie(string title, string director, string moviereldate, string rating)
        {

            Title = title;
            Director = director;
            Moviereldate = moviereldate;
            Rating = rating;
        }

    }
    
}
