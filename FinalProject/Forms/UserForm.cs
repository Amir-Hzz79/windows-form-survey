using FinalProject.UserControls;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
			
		}

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void avaiablePolls_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            ShowAvaiablePollsControl polls = new ShowAvaiablePollsControl();
			polls.QuestionClicked += UserControl_QuestionClicked;
            polls.PollFormClosed += NextForm_FormClosed;
			containerPanel.Controls.Add(polls);
        }

        private void pollHistory_Click(object sender, EventArgs e)
        {
            
        }

		private void NextForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Show(); // Show the previous form when the next form is closed
		}

		private void UserControl_QuestionClicked(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
