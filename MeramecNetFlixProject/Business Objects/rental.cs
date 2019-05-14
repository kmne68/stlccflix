using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.Business_Objects
{
    class Rental
    {
        public Rental(int movie_number, int member_number, DateTime media_checkout_date, DateTime media_return_date)
        {
            Movie_number = movie_number;
            Member_number = member_number;
            Media_checkout_date = media_checkout_date;
            Media_return_date = media_return_date;
        }

        public int Movie_number { get; set; }
        public int Member_number { get; set; }
        public DateTime Media_checkout_date { get; set; }
        public DateTime Media_return_date { get; set; }
    }
}
