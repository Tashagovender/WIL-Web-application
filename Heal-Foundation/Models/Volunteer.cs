using System.ComponentModel.DataAnnotations;

namespace Heal_Foundation.Models
{
    public class Volunteer
    {
        [Key]
        public int VolunteerID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string ContactNumber { get; set; }
        [Required]
        [StringLength(150)]
        public string Message { get; set; }
    }
}
