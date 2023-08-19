using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public ICollection<Poll> Polls { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
