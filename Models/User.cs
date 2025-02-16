using System.ComponentModel.DataAnnotations;

namespace ConferenceManagementSystem.Models
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(100)]
        public string Name { get; set; }
        
        [Required, EmailAddress]
        public string Email { get; set; }
        
        [Required, Phone]
        public string Phone { get; set; }
        
    }

}
