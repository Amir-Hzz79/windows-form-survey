using FinalProject.Models;
using FinalProject.Services;
using System.ComponentModel;

namespace FinalProject.UserControls
{
    public partial class UserManageControl : UserControl
    {
        UserService _userService = MyServices.UserService;
        BindingList<User> users;

        List<User> editedUsers = new List<User>();

        public UserManageControl()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();

            users = new BindingList<User>(_userService.GetAll());
            usersDataGridView.DataSource = users;
            usersDataGridView.Columns["UserAnswers"].Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int updatedCount = 0;
            //foreach (DataGridViewRow row in usersDataGridView.Rows)
            //{
            //    if (row.IsNewRow)
            //    {
            //        object username = row.Cells[1].Value;
            //        object password = row.Cells[2].Value;
            //        object isAdmin = row.Cells[3].Value;
            //        if (username != null && password != null && isAdmin != null)
            //        {
            //            User user = new User();
            //            user.Username = username.ToString();
            //            user.Password = password.ToString();
            //            user.IsAdmin = Convert.ToBoolean(isAdmin);

            //            bool isAdded = _userService.Add(user);

            //            if (isAdded)
            //            {
            //                addedCount++;
            //            }
            //        }
            //        else
            //        {
            //            if (usersDataGridView.Rows[usersDataGridView.Rows.Count - 1].Index == row.Index)
            //            {
            //                MessageBox.Show("لطفا تمامی فیلدها را تکمیل نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //        }
            //    }
            //}

            foreach (User user in editedUsers)
            {
                bool isUpdated = _userService.Update(user);
                if (isUpdated)
                {
                    updatedCount++;
                }
            }

            MessageBox.Show($"{updatedCount} کاربر بروز یا اضافه شدند.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

            usersDataGridView.DataSource = _userService.GetAll();
            usersDataGridView.Columns["UserAnswers"].Visible = false;
        }

        private void usersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = usersDataGridView.Rows[e.RowIndex];

            object Id = editedRow.Cells[0].Value;
            object username = editedRow.Cells[1].Value;
            object password = editedRow.Cells[2].Value;
            object isAdmin = editedRow.Cells[3].Value;

            if (Id != null && username != null && password != null && isAdmin != null)
            {
                User user = new User()
                {
                    Id = Convert.ToInt32(Id),
                    Username = username.ToString(),
                    Password = password.ToString(),
                    IsAdmin = Convert.ToBoolean(isAdmin)
                };

                if (!editedUsers.Contains(user))
                {
                    editedUsers.Add(user);
                }
            }
        }
    }
}
