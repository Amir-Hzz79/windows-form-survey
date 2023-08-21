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

		List<QuestionControl> questionControls = new List<QuestionControl>();

		public PollForm(int id)
		{
			poll = _pollService.Get(id);

			InitializeComponent();

			nameLable.Text = poll.Title;
			descriptionLable.Text = poll.Description;

			foreach (Question question in poll.Questions)
			{
				QuestionControl questionControl = new QuestionControl(question,true, -1);
				questionControls.Add(questionControl);
				containerPanel.Controls.Add(questionControl);
			}
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
