using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Switch {
    class Movie {

        public string movieName;
        public string author;
        private string rating;
        public static int movieCount = 0;

        public Movie()
        {

        }

        public Movie(string aMovieName, string aAuthor, string aRating)
        {
            movieName = aMovieName;
            author = aAuthor;
            Rating = aRating;
            movieCount++;
        }

        public string Rating
        {
            get { return rating; }  
            set 
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") 
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }

        }

        public int GetMovieCount()
        {
            return movieCount;
        }

    }

}

