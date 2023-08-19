using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<UserAnswers> UserAnswers { get; set; }
    }
}
