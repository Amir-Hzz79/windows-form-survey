using FinalProject.Services;

namespace FinalProject.UserControls
{
    public partial class ShowPollsControl : UserControl
    {
        PollService PollService = MyServices.PollService;
        public ShowPollsControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PollService.GetAll();
        }
    }
}
