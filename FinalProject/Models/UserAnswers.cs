using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class UserAnswers
    {
        [Key]
        public int Id { get; set; }
        public string DateCreated { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
