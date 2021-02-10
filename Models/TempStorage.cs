using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    // this is the temp storage class for suggestions. This will create an empty list and add new suggestions to the list
    public class TempStorage
    {
        private static List<Suggestion> resturants = new List<Suggestion>();

        public static IEnumerable<Suggestion> Resturants => resturants;

        public static void AddSuggestion(Suggestion resturant)
        {
            resturants.Add(resturant);
        }
    }
}
