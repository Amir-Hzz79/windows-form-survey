using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Services
{
    public class QuestionService
    {
        MyDbContext _db;
        public QuestionService(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public List<Question> GetAll()
        {
            return _db.Questions.Include(q => q.Answers).ToList();
        }

        public bool Add(QuestionVM question)
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    Question dbQuestion = new Question() { Text = question.QuestionText };

                    _db.Questions.Add(dbQuestion);

                    _db.SaveChanges();

                    List<Answer> answers = new List<Answer>()
                    {
                        new Answer()
                        {
                            AnswerText=question.Answer1,
                            QuestionID=dbQuestion.Id
                        },
                        new Answer()
                        {
                            AnswerText=question.Answer2,
                            QuestionID=dbQuestion.Id
                        },
                        new Answer()
                        {
                            AnswerText=question.Answer3,
                            QuestionID=dbQuestion.Id
                        },
                        new Answer()
                        {
                            AnswerText=question.Answer4,
                            QuestionID=dbQuestion.Id
                        },
                    };

                    _db.Answers.AddRange(answers);

                    _db.SaveChanges();

                    // Commit the transaction
                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }

        }
    }
}
