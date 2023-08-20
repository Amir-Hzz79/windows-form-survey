using FinalProject.Models;
using FinalProject.Services;
using FinalProject.UserControls;
using FinalProject.ViewModels;

namespace FinalProject.Forms
{
	public partial class PollForm : Form
	{
		PollService _pollService = MyServices.PollService;

		Poll poll;

		List<QuestionControl> questionControls=new List<QuestionControl>();

		public PollForm(int id)
		{
			poll = _pollService.Get(id);

			InitializeComponent();


			foreach (Question question in poll.Questions)
			{
				QuestionControl questionControl = new QuestionControl(question);
				questionControls.Add(questionControl);
				containerPanel.Controls.Add(questionControl);
			}

			//int rowCount = poll.Questions.Count;

			//// Calculate row height
			//int rowHeight = 200;

			//// Set RowStyles for each row
			//for (int i = 0; i < rowCount; i++)
			//{
			//	questionTable.RowStyles.Add(new RowStyle(SizeType.Absolute, rowHeight));
			//}

			//List<Question> questions = poll.Questions.ToList();
			//for (int i = 0; i < rowCount; i++)
			//{
			//	QuestionControl questionControl = new QuestionControl(questions[i]);
			//	questionControl.Dock = DockStyle.Fill;
			//	questionTable.Controls.Add(questionControl, 0, i);
			//}
			//// Call PerformLayout to apply the new row styles
			//questionTable.SuspendLayout();
			//questionTable.ResumeLayout();

			//containerPanel.Controls.Add(questionTable);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			foreach (var item in questionControls)
			{
				_pollService.AddUserAnswer(poll.Id, item.selectedAnswer, AppData.User.Id);
			}
		}
	}
}
