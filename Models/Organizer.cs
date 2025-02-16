namespace ConferenceManagementSystem.Models{

    public class Organizer : User
    {
        public List<Conference> Conferences { get; set; } = new();
    }
}