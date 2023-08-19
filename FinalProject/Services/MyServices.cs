namespace FinalProject.Services
{
    public class MyServices
    {
        public static UserService UserService;

        public static QuestionService QuestionService;

        public static PollService PollService;

        public MyServices(MyDbContext context)
        {
            UserService = new UserService(context);
            QuestionService = new QuestionService(context);
            PollService = new PollService(context);
        }
    }
}
