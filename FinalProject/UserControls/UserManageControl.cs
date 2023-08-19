using FinalProject.Models;
using FinalProject.Services;
using System.ComponentModel;

namespace FinalProject.UserControls
{
    public partial class UserManageControl : UserControl
    {
        UserService _userService = MyServices.UserService;
        BindingList<User> users;
        public UserManageControl()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();

            users = new BindingList<User>(_userService.GetAll());
            usersDataGridView.DataSource = users;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            usersDataGridView.UserAddedRow += (sender, e) =>
            {

            };
        }
    }
}
