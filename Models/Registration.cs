using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceManagementSystem.Models
{

    public class Registration
    {
        public int Id { get; set; }

        [Required]
        public int ConferenceId { get; set; }

        [Required]
        public int AttendeeId { get; set; }

        // Navigation properties (not marked as required)
        public Conference? Conference { get; set; }  
        public Attendee? Attendee { get; set; }  
    }
    
}
