using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string AnswerText { get; set; }

        public int QuestionID { get; set; }
        public Question Question { get; set; }

        public List<UserAnswers> UserAnswers { get; set; }
    }
}
