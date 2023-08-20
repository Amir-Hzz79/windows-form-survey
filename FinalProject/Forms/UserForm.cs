using FinalProject.UserControls;

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
            containerPanel.Controls.Add(new ShowPollsControl());
        }

        private void pollHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
