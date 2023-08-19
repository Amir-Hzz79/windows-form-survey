using FinalProject.Services;
using FinalProject.ViewModels;

namespace FinalProject.UserControls
{
    public partial class CreateQuestionControl : UserControl
    {
        QuestionService _questionService = MyServices.QuestionService;
        public CreateQuestionControl()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void CreateQuestionButton_Click(object sender, EventArgs e)
        {
            string questionText = QuestionTextTextBox.Text;
            string answer1 = Answer1TextBox.Text;
            string answer2 = Answer2TextBox.Text;
            string answer3 = Answer3TextBox.Text;
            string answer4 = Answer4TextBox.Text;

            if (questionText == String.Empty || answer1 == String.Empty || answer2 == String.Empty || answer3 == String.Empty || answer4 == String.Empty)
            {
                MessageBox.Show("لطفا تمام مقادیر را وارد کنید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QuestionVM question = new QuestionVM()
                {
                    QuestionText = questionText,
                    Answer1 = answer1,
                    Answer2 = answer2,
                    Answer3 = answer3,
                    Answer4 = answer4,
                };

                bool isAdded = _questionService.Add(question);
                if (isAdded)
                {
                    MessageBox.Show("سوال با موفقیت اضافه شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
