using System.ComponentModel.DataAnnotations;

namespace ConferenceManagementSystem.Models
{
    public class Attendee : User
    {
        public List<Conference> Conferences { get; set; } = new();
    }
}