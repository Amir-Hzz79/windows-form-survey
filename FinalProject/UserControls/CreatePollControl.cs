using FinalProject.Models;
using FinalProject.Services;
using System.ComponentModel;

namespace FinalProject.UserControls
{
    public partial class CreatePollControl : UserControl
    {
        public CreatePollControl()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            questions = new BindingList<Question>(_questionService.GetAll());

            questionDataGrid.DataSource = questions;
            questionDataGrid.Columns["Id"].Visible = false;
            questionDataGrid.Columns["Polls"].Visible = false;
            questionDataGrid.Columns["Answers"].Visible = false;


            selectedQuestionsDataGrid.DataSource = _selectedQuestions;
            selectedQuestionsDataGrid.Columns["Id"].Visible = false;
            selectedQuestionsDataGrid.Columns["Polls"].Visible = false;
            selectedQuestionsDataGrid.Columns["Answers"].Visible = false;
        }

        QuestionService _questionService = MyServices.QuestionService;
        PollService _pollService = MyServices.PollService;

        private BindingList<Question> _selectedQuestions = new BindingList<Question>();
        private BindingList<Question> questions;

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in questionDataGrid.SelectedRows)
            {
                Question selectedQuestion = (Question) row.DataBoundItem;
                _selectedQuestions.Add(selectedQuestion);
                questions.Remove(selectedQuestion); // Remove from the BindingList
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedQuestionsDataGrid.SelectedRows)
            {
                Question selectedQuestion = (Question) row.DataBoundItem;
                _selectedQuestions.Remove(selectedQuestion);

                questions.Add(selectedQuestion);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_selectedQuestions.Count <= 0 && pollNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("نام نظرسنجی و توضیحات را وارد کنید و حداقل یک سوال را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_selectedQuestions.Count <= 0)
            {
                MessageBox.Show("حداقل یک سوال انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pollNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("نام نظرسنجی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (descriptionTextBox.Text == String.Empty)
            {
                MessageBox.Show("توضیحات را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Poll poll = new Poll()
                {
                    Title = pollNameTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Questions = _selectedQuestions,
                };

                bool isAdded = _pollService.Add(poll);
                if (isAdded)
                {
                    MessageBox.Show("نظرسنجی با موفقیت ساخته شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("خطایی در هنگام ساختن نظرسنجی رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
