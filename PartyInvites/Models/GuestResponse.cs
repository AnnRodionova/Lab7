using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter ur name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter ur email")] 
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter ur phone number")] 
        public string Phone {  get; set; }

        [Required(ErrorMessage = "Please enter ur age")] 
        [Range(18, int.MaxValue, ErrorMessage = "Sorry, the party is for adults only")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please specify whether u'll attend")] 
        public bool? WillAttend { get; set; }
        
    }
}
