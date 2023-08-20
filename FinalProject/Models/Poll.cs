using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Poll
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<UserAnswers> UserAnswers { get; set; }
    }
}
