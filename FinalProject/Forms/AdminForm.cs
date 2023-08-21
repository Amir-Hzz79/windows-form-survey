using FinalProject.Forms;
using FinalProject.Services;
using FinalProject.UserControls;
using FinalProject.ViewModels;

namespace FinalProject
{
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void NextForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Show(); // Show the previous form when the next form is closed
		}

		private void createQuestionButton_Click(object sender, EventArgs e)
		{
			ContainerPanel.Controls.Clear();
			ContainerPanel.Controls.Add(new CreateQuestionControl());
		}

		private void createPollButton_Click(object sender, EventArgs e)
		{
			ContainerPanel.Controls.Clear();
			ContainerPanel.Controls.Add(new CreatePollControl());
		}

		private void manageUsersButton_Click(object sender, EventArgs e)
		{
			ContainerPanel.Controls.Clear();
			ContainerPanel.Controls.Add(new UserManageControl());
		}

		private void answerPercentButton_Click(object sender, EventArgs e)
		{
			

			PollAnswersPercentForm pollAnswersPercentForm = new PollAnswersPercentForm(1);

			pollAnswersPercentForm.Show();
		}
	}
}
