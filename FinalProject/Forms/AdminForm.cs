using FinalProject.UserControls;

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
    }
}
