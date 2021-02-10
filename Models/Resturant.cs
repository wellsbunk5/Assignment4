using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    // Hold the model for the Top 5 Resturants
    public class Resturant
    {
        // set rank in the constructor and have it be read only
        public Resturant (int rank)
        {
            Rank = rank;
        }

        [Required]
        public int Rank { get; }
        [Required]
        public string RestName { get; set; }
        // fav dish and other optional items can be null
        public string? FavDish { get; set; }
        [Required]
        public string Address { get; set; }
        // make sure phone is correct
       
        [RegularExpression(@"^(([0-9]{3})+([-]{1})+([0-9]{3})+([-]{1})+([0-9]{4}))$", ErrorMessage = "Input Phone number in xxx-xxx-xxxx format")]

        public string? Phone { get; set; }
        public string? Website { get; set; } = "Coming Soon";


        public static Resturant[] GetResturants()
        {
            // set the top 5 resturants info and then pass it to an array
            Resturant r1 = new Resturant(1)
            {
                RestName = "Wells's Dope Eatery",
                FavDish = null,
                Address = "500N 119E",
                Phone = "801-404-8666",
                Website = "https://espn.go.com"

            };
            Resturant r2 = new Resturant(2)
            {
                RestName = "Ernies",
                FavDish = "The Champ",
                Address = "100W Center Street",
                Phone = "801-225-8666"
            };
            Resturant r3 = new Resturant(3)
            {
                RestName = "Wendys",
                FavDish = "4 for 4",
                Address = "500N 5000E",
                Phone = "801-404-8669",
                Website = "wendys.com"

            };
            Resturant r4 = new Resturant(4)
            {
                RestName = "Mcdonksies",
                FavDish = null,
                Address = "1000N Univ",
                Phone = "801-404-9999",
                Website = "mcdonkskies.com"

            };
            Resturant r5 = new Resturant(5)
            {
                RestName = "Cafe Rio",
                FavDish = "Pork Salad",
                Address = "Over the Rainbow",
                Phone = "801-111-8666",

            };
            return new Resturant[] { r1, r2, r3, r4, r5 };
        }
    }

}
