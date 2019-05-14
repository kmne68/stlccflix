using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.Business_Objects
{
    class Movie
    {
        public Movie(int movie_number, string title, string description, int movie_year_made, int genre_id, char movie_rating, string media_type, double movie_retail_cost, int copies_on_hand, string image, string trailer)
        {
            Movie_number = movie_number;
            Title = title;
            Description = description;
            Movie_year_made = movie_year_made;
            Genre_id = genre_id;
            Movie_rating = movie_rating;
            Media_type = media_type;
            Movie_retail_cost = movie_retail_cost;
            Copies_on_hand = copies_on_hand;
            Image = image;
            Trailer = trailer;
        }

        public int Movie_number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Movie_year_made { get; set; }
        public int Genre_id { get; set; }
        public char Movie_rating { get; set; }
        public string Media_type { get; set; }
        public double Movie_retail_cost { get; set; }
        public int Copies_on_hand { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
    }
}
