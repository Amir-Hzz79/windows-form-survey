using FinalProject.Services;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        UserService _userService = MyServices.UserService;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (username == String.Empty && password == String.Empty)
            {
                MessageBox.Show("نام کاربری و رمز عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == String.Empty)
            {
                MessageBox.Show("نام کاربری را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == String.Empty)
            {
                MessageBox.Show("رمز عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUserExist = _userService.Login(username, password);

                if (isUserExist)
                {
                    if (AppData.User.IsAdmin)
                    {
                        Hide();
                        Form adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        Hide();
                        Form userForm = new UserForm();
                        userForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("کاربری با این مشخصات یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
