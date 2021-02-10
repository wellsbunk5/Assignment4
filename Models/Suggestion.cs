using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Suggestion
    {
        // model for any suggestions. Set phone to the correct format only
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestName { get; set; }
        public string? FavDish { get; set; }
        [Required]
        [RegularExpression(@"^(([0-9]{3})+([-]{1})+([0-9]{3})+([-]{1})+([0-9]{4}))$", ErrorMessage = "Input Phone number in xxx-xxx-xxxx format")]
        public string Phone { get; set; }
    }
}
