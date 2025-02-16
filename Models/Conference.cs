using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceManagementSystem.Models
{
    public class Conference
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Location { get; set; }

        public List<Organizer> Organizers { get; set; } = new();
        public List<Attendee> Attendees { get; set; } = new();
    }
}

