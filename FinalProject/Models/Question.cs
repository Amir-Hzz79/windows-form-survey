using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public List<Poll> Polls { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
